using Npgsql;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PatientAidApp
{
    public class DatabaseManager
    {
        private readonly string connectionString;
        private NpgsqlConnection connection;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Connect()
        {
            try
            {
                this.connection = new NpgsqlConnection(this.connectionString);
                this.connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (this.connection != null && this.connection.State == System.Data.ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while closing the database connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CreateAccount(string username, string password)
        {
            try
            {
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = "SELECT COUNT(*) FROM Patient WHERE username = @username;";
                    command.Parameters.AddWithValue("username", username);
                    var result = (long)command.ExecuteScalar();
                    if (result > 0)
                    {
                        return false;
                    }
                }
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = "INSERT INTO Patient (username, password) VALUES (@username, @password);";
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the patient account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool Login(string username, string password)
        {
            password = Encryption.EncryptWithMD5(password);
            try
            {
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = "SELECT COUNT(*) FROM Patient WHERE username = @username AND password = @password;";
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);
                    var result = (long)command.ExecuteScalar();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while logging in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool RecoverPassword(string username, string newPassword)
        {
            try
            {
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = "SELECT COUNT(*) FROM Patient WHERE username = @username;";
                    command.Parameters.AddWithValue("username", username);
                    var result = (long)command.ExecuteScalar();
                    if (result == 0)
                    {
                        return false;
                    }
                }
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = "UPDATE Patient SET password = @newPassword WHERE username = @username;";
                    command.Parameters.AddWithValue("newPassword", newPassword);
                    command.Parameters.AddWithValue("username", username);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while recovering the password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable DisplayMedicines()
        {
            try
            {
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = @"SELECT m.id AS ""No."", m.medicine_name AS ""Medicine name"", m.quantity AS ""Quantity each day"", m.time_to_take AS ""Time to take each day""
                                 FROM Patient p
                                 INNER JOIN Patient_Medicine pm ON p.id = pm.patient_id
                                 INNER JOIN Medicine m ON pm.medicine_id = m.id
                                 WHERE p.username = @username;";
                    command.Parameters.AddWithValue("username");
                    using (var npgsqlDataAdapter = new NpgsqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        npgsqlDataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while displaying the list of medicines: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public bool AddMedicine(string medicineName, int quantity, TimeSpan timeToTake, string patientUsername)
        {
            try
            {
                int patientID, medicineID;
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = "INSERT INTO Medicine (medicine_name, quantity, time_to_take) VALUES (@medicineName, @quantity, @timeToTake) RETURNING id;";
                    command.Parameters.AddWithValue("medicineName", medicineName);
                    command.Parameters.AddWithValue("quantity", quantity);
                    command.Parameters.AddWithValue("timeToTake", timeToTake);
                    medicineID = (int)command.ExecuteScalar();
                }
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = "SELECT id FROM Patient WHERE username = @patientUsername;";
                    command.Parameters.AddWithValue("patientUsername", patientUsername);
                    patientID = (int)command.ExecuteScalar();
                }
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = "INSERT INTO Patient_Medicine (patient_id, medicine_id) VALUES (@patientID, @medicineID);";
                    command.Parameters.AddWithValue("patientID", patientID);
                    command.Parameters.AddWithValue("medicineID", medicineID);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the new medication: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool EditMedicine(int medicineID, string medicineName, int quantity, TimeSpan timeToTake)
        {
            try
            {
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = "UPDATE Medicine SET medicine_name = @medicineName, quantity = @quantity, time_to_take = @timeToTake WHERE id = @medicineID;";
                    command.Parameters.AddWithValue("medicineName", medicineName);
                    command.Parameters.AddWithValue("quantity", quantity);
                    command.Parameters.AddWithValue("timeToTake", timeToTake);
                    command.Parameters.AddWithValue("medicineID", medicineID);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while editing the selected medication: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool DeleteMedicine(int medicineID)
        {
            try
            {
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = this.connection;
                    command.CommandText = "DELETE FROM Medicine WHERE id = @medicineID;";
                    command.Parameters.AddWithValue("medicineID", medicineID);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the selected medication: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
