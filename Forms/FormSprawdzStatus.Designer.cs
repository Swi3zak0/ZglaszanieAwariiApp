namespace ZglaszanieAwariiApp.Forms
{
    partial class FormSprawdzStatus
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
            lblInfo = new Label();
            txtId = new TextBox();
            btnSprawdz = new Button();
            lblWynik = new Label();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(316, 17);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(111, 15);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Wprowadź ID awarii";
            // 
            // txtId
            // 
            txtId.Location = new Point(290, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(163, 23);
            txtId.TabIndex = 1;
            // 
            // btnSprawdz
            // 
            btnSprawdz.Location = new Point(634, 352);
            btnSprawdz.Name = "btnSprawdz";
            btnSprawdz.Size = new Size(154, 86);
            btnSprawdz.TabIndex = 2;
            btnSprawdz.Text = "Sprawdź";
            btnSprawdz.UseVisualStyleBackColor = true;
            btnSprawdz.Click += btnSprawdz_Click;
            // 
            // lblWynik
            // 
            lblWynik.AutoSize = true;
            lblWynik.Location = new Point(27, 132);
            lblWynik.Name = "lblWynik";
            lblWynik.Size = new Size(67, 15);
            lblWynik.TabIndex = 3;
            lblWynik.Text = "Tutaj wynik";
            lblWynik.Click += label1_Click;
            // 
            // FormSprawdzStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWynik);
            Controls.Add(btnSprawdz);
            Controls.Add(txtId);
            Controls.Add(lblInfo);
            Name = "FormSprawdzStatus";
            Text = "FormSprawdzStatus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private TextBox txtId;
        private Button btnSprawdz;
        private Label lblWynik;
    }
}