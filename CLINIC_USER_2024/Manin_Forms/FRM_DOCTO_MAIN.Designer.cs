namespace CLINIC_USER_2024.Manin_Forms
{
    partial class FRM_DOCTO_MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DOCTO_MAIN));
            DevExpress.Utils.ContextButton contextButton1 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton2 = new DevExpress.Utils.ContextButton();
            btnEdite_DOCTOR = new DevExpress.XtraEditors.TileControl();
            tileControl1 = new DevExpress.XtraEditors.TileControl();
            SuspendLayout();
            // 
            // btnEdite_DOCTOR
            // 
            btnEdite_DOCTOR.AllowDrop = true;
            btnEdite_DOCTOR.AllowHtmlText = DevExpress.Utils.DefaultBoolean.False;
            btnEdite_DOCTOR.AllowItemHover = true;
            btnEdite_DOCTOR.AllowSelectedItem = true;
            btnEdite_DOCTOR.AppearanceGroupText.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdite_DOCTOR.AppearanceGroupText.Options.UseFont = true;
            btnEdite_DOCTOR.AppearanceItem.Disabled.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdite_DOCTOR.AppearanceItem.Disabled.Options.UseFont = true;
            btnEdite_DOCTOR.AppearanceItem.Hovered.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdite_DOCTOR.AppearanceItem.Hovered.Options.UseFont = true;
            btnEdite_DOCTOR.AppearanceItem.Normal.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdite_DOCTOR.AppearanceItem.Normal.Options.UseFont = true;
            btnEdite_DOCTOR.AppearanceItem.Pressed.BackColor = Color.Cyan;
            btnEdite_DOCTOR.AppearanceItem.Pressed.BorderColor = Color.Red;
            btnEdite_DOCTOR.AppearanceItem.Pressed.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdite_DOCTOR.AppearanceItem.Pressed.Options.UseBackColor = true;
            btnEdite_DOCTOR.AppearanceItem.Pressed.Options.UseBorderColor = true;
            btnEdite_DOCTOR.AppearanceItem.Pressed.Options.UseFont = true;
            btnEdite_DOCTOR.AppearanceText.BackColor = Color.DeepSkyBlue;
            btnEdite_DOCTOR.AppearanceText.Font = new Font("Constantia", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnEdite_DOCTOR.AppearanceText.ForeColor = Color.Black;
            btnEdite_DOCTOR.AppearanceText.Options.UseBackColor = true;
            btnEdite_DOCTOR.AppearanceText.Options.UseFont = true;
            btnEdite_DOCTOR.AppearanceText.Options.UseForeColor = true;
            btnEdite_DOCTOR.AppearanceText.Options.UseTextOptions = true;
            btnEdite_DOCTOR.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            btnEdite_DOCTOR.BackColor = Color.Transparent;
            btnEdite_DOCTOR.BackgroundImage = (Image)resources.GetObject("btnEdite_DOCTOR.BackgroundImage");
            btnEdite_DOCTOR.BackgroundImageLayout = ImageLayout.Center;
            btnEdite_DOCTOR.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            contextButton1.Id = new Guid("2d1b1e9f-f06a-44e4-bc78-ebce17010c82");
            contextButton1.ImageOptionsCollection.ItemNormal.UseDefaultImage = true;
            contextButton1.Name = "contextButton1";
            btnEdite_DOCTOR.ContextButtons.Add(contextButton1);
            btnEdite_DOCTOR.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            btnEdite_DOCTOR.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown;
            btnEdite_DOCTOR.Location = new Point(648, 124);
            btnEdite_DOCTOR.Name = "btnEdite_DOCTOR";
            btnEdite_DOCTOR.ShowText = true;
            btnEdite_DOCTOR.Size = new Size(520, 300);
            btnEdite_DOCTOR.TabIndex = 1;
            btnEdite_DOCTOR.Text = " ДОБАВИТЬ ИЛИ ИЗМЕНИТЬ ВРАЧА";
            btnEdite_DOCTOR.Click += btnEdite_DOCTOR_Click;
            btnEdite_DOCTOR.MouseEnter += Red;
            // 
            // tileControl1
            // 
            tileControl1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.False;
            tileControl1.AllowItemHover = true;
            tileControl1.AllowSelectedItem = true;
            tileControl1.AppearanceGroupHighlighting.HoveredMaskColor = Color.PaleTurquoise;
            tileControl1.AppearanceGroupHighlighting.MaskColor = Color.LightSkyBlue;
            tileControl1.AppearanceGroupText.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tileControl1.AppearanceGroupText.Options.UseBackColor = true;
            tileControl1.AppearanceGroupText.Options.UseBorderColor = true;
            tileControl1.AppearanceGroupText.Options.UseFont = true;
            tileControl1.AppearanceGroupText.Options.UseForeColor = true;
            tileControl1.AppearanceGroupText.Options.UseTextOptions = true;
            tileControl1.AppearanceItem.Disabled.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tileControl1.AppearanceItem.Disabled.Options.UseFont = true;
            tileControl1.AppearanceItem.Hovered.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tileControl1.AppearanceItem.Hovered.Options.UseFont = true;
            tileControl1.AppearanceItem.Normal.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tileControl1.AppearanceItem.Normal.Options.UseFont = true;
            tileControl1.AppearanceItem.Pressed.BackColor = Color.FromArgb(128, 128, 255);
            tileControl1.AppearanceItem.Pressed.BorderColor = Color.FromArgb(128, 128, 255);
            tileControl1.AppearanceItem.Pressed.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tileControl1.AppearanceItem.Pressed.Options.UseBackColor = true;
            tileControl1.AppearanceItem.Pressed.Options.UseBorderColor = true;
            tileControl1.AppearanceItem.Pressed.Options.UseFont = true;
            tileControl1.AppearanceText.BackColor = Color.SkyBlue;
            tileControl1.AppearanceText.Font = new Font("Constantia", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            tileControl1.AppearanceText.ForeColor = Color.Black;
            tileControl1.AppearanceText.Options.UseBackColor = true;
            tileControl1.AppearanceText.Options.UseFont = true;
            tileControl1.AppearanceText.Options.UseForeColor = true;
            tileControl1.AppearanceText.Options.UseTextOptions = true;
            tileControl1.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tileControl1.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileControl1.BackColor = Color.WhiteSmoke;
            tileControl1.BackgroundImage = (Image)resources.GetObject("tileControl1.BackgroundImage");
            tileControl1.BackgroundImageLayout = ImageLayout.Center;
            tileControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            contextButton2.Id = new Guid("2d1b1e9f-f06a-44e4-bc78-ebce17010c82");
            contextButton2.ImageOptionsCollection.ItemNormal.UseDefaultImage = true;
            contextButton2.Name = "contextButton1";
            tileControl1.ContextButtons.Add(contextButton2);
            tileControl1.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileControl1.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown;
            tileControl1.Location = new Point(80, 120);
            tileControl1.Name = "tileControl1";
            tileControl1.SelectionColor = Color.SkyBlue;
            tileControl1.ShowText = true;
            tileControl1.Size = new Size(520, 300);
            tileControl1.TabIndex = 2;
            tileControl1.Text = "СПИСОК ВРАЧЕЙ";
            tileControl1.Click += tileControl1_Click;
            // 
            // FRM_DOCTO_MAIN
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 604);
            Controls.Add(tileControl1);
            Controls.Add(btnEdite_DOCTOR);
            Name = "FRM_DOCTO_MAIN";
            Text = "FRM_DOCTO_MAIN";
            Load += FRM_DOCTO_MAIN_Load;
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.TileControl btnEdite_DOCTOR;
        private DevExpress.XtraEditors.TileControl tileControl1;
    }
}