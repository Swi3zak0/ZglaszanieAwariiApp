namespace ZglaszanieAwariiApp.Forms
{
    partial class FormZgloszenie
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
            txtOpis = new TextBox();
            txtKategoria = new TextBox();
            txtUzytkownik = new TextBox();
            txtEmail = new TextBox();
            lblOpis = new Label();
            lblKategoria = new Label();
            label1 = new Label();
            lblEmail = new Label();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(12, 165);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(284, 134);
            txtOpis.TabIndex = 0;
            // 
            // txtKategoria
            // 
            txtKategoria.Location = new Point(12, 121);
            txtKategoria.Name = "txtKategoria";
            txtKategoria.Size = new Size(284, 23);
            txtKategoria.TabIndex = 1;
            // 
            // txtUzytkownik
            // 
            txtUzytkownik.Location = new Point(12, 33);
            txtUzytkownik.Name = "txtUzytkownik";
            txtUzytkownik.Size = new Size(284, 23);
            txtUzytkownik.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Location = new Point(12, 147);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(65, 15);
            lblOpis.TabIndex = 5;
            lblOpis.Text = "Opis awarii";
            // 
            // lblKategoria
            // 
            lblKategoria.AutoSize = true;
            lblKategoria.Location = new Point(12, 103);
            lblKategoria.Name = "lblKategoria";
            lblKategoria.Size = new Size(57, 15);
            lblKategoria.TabIndex = 6;
            lblKategoria.Text = "Kategoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 7;
            label1.Text = "Imię zgłaszającego";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 59);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(116, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail zgłaszającego";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(587, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status Awarii";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(587, 33);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(201, 23);
            cmbStatus.TabIndex = 10;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(636, 335);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(152, 103);
            btnDodaj.TabIndex = 11;
            btnDodaj.Text = "Zgłoś";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // FormZgloszenie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblEmail);
            Controls.Add(label1);
            Controls.Add(lblKategoria);
            Controls.Add(lblOpis);
            Controls.Add(txtEmail);
            Controls.Add(txtUzytkownik);
            Controls.Add(txtKategoria);
            Controls.Add(txtOpis);
            Name = "FormZgloszenie";
            Text = "FormZgloszenie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOpis;
        private TextBox txtKategoria;
        private TextBox txtUzytkownik;
        private TextBox txtEmail;
        private Label lblOpis;
        private Label lblKategoria;
        private Label label1;
        private Label lblEmail;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnDodaj;
    }
}