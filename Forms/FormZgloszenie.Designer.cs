﻿namespace ZglaszanieAwariiApp.Forms
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
            txtUzytkownik = new TextBox();
            txtEmail = new TextBox();
            lblOpis = new Label();
            lblKategoria = new Label();
            label1 = new Label();
            lblEmail = new Label();
            btnDodaj = new Button();
            btnZamknij = new Button();
            lblNumerBudynku = new Label();
            lblPietro = new Label();
            txtNumerBudynku = new TextBox();
            txtPietro = new TextBox();
            cmbKategoria = new ComboBox();
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
            // btnDodaj
            // 
            btnDodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDodaj.Location = new Point(636, 335);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(152, 103);
            btnDodaj.TabIndex = 11;
            btnDodaj.Text = "Zgłoś";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnZamknij
            // 
            btnZamknij.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnZamknij.Location = new Point(466, 335);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Size = new Size(152, 103);
            btnZamknij.TabIndex = 12;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = true;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // lblNumerBudynku
            // 
            lblNumerBudynku.AutoSize = true;
            lblNumerBudynku.Location = new Point(466, 15);
            lblNumerBudynku.Name = "lblNumerBudynku";
            lblNumerBudynku.Size = new Size(94, 15);
            lblNumerBudynku.TabIndex = 13;
            lblNumerBudynku.Text = "Numer Budynku";
            // 
            // lblPietro
            // 
            lblPietro.AutoSize = true;
            lblPietro.Location = new Point(466, 59);
            lblPietro.Name = "lblPietro";
            lblPietro.Size = new Size(38, 15);
            lblPietro.TabIndex = 14;
            lblPietro.Text = "Piętro";
            // 
            // txtNumerBudynku
            // 
            txtNumerBudynku.Location = new Point(466, 33);
            txtNumerBudynku.Name = "txtNumerBudynku";
            txtNumerBudynku.Size = new Size(185, 23);
            txtNumerBudynku.TabIndex = 15;
            // 
            // txtPietro
            // 
            txtPietro.Location = new Point(466, 77);
            txtPietro.Name = "txtPietro";
            txtPietro.Size = new Size(185, 23);
            txtPietro.TabIndex = 16;
            // 
            // cmbKategoria
            // 
            cmbKategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoria.FormattingEnabled = true;
            cmbKategoria.Location = new Point(12, 121);
            cmbKategoria.Name = "cmbKategoria";
            cmbKategoria.Size = new Size(284, 23);
            cmbKategoria.Sorted = true;
            cmbKategoria.TabIndex = 17;
            // 
            // FormZgloszenie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbKategoria);
            Controls.Add(txtPietro);
            Controls.Add(txtNumerBudynku);
            Controls.Add(lblPietro);
            Controls.Add(lblNumerBudynku);
            Controls.Add(btnZamknij);
            Controls.Add(btnDodaj);
            Controls.Add(lblEmail);
            Controls.Add(label1);
            Controls.Add(lblKategoria);
            Controls.Add(lblOpis);
            Controls.Add(txtEmail);
            Controls.Add(txtUzytkownik);
            Controls.Add(txtOpis);
            Name = "FormZgloszenie";
            Text = "FormZgloszenie";
            Load += FormZgloszenie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOpis;
        private TextBox txtUzytkownik;
        private TextBox txtEmail;
        private Label lblOpis;
        private Label lblKategoria;
        private Label label1;
        private Label lblEmail;
        private Button btnDodaj;
        private Button btnZamknij;
        private Label lblNumerBudynku;
        private Label lblPietro;
        private TextBox txtNumerBudynku;
        private TextBox txtPietro;
        private ComboBox cmbKategoria;
    }
}