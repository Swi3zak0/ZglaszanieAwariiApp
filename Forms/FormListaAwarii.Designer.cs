namespace ZglaszanieAwariiApp.Forms
{
    partial class FormListaAwarii
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
            dgvLista = new DataGridView();
            lblFiltruj = new Label();
            cmbFiltr = new ComboBox();
            btnZmienStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(28, 93);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowTemplate.Height = 25;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(746, 249);
            dgvLista.TabIndex = 0;
            // 
            // lblFiltruj
            // 
            lblFiltruj.AutoSize = true;
            lblFiltruj.Location = new Point(28, 56);
            lblFiltruj.Name = "lblFiltruj";
            lblFiltruj.Size = new Size(100, 15);
            lblFiltruj.TabIndex = 1;
            lblFiltruj.Text = "Filtruj po statusie:";
            // 
            // cmbFiltr
            // 
            cmbFiltr.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltr.FormattingEnabled = true;
            cmbFiltr.Location = new Point(134, 53);
            cmbFiltr.Name = "cmbFiltr";
            cmbFiltr.Size = new Size(121, 23);
            cmbFiltr.TabIndex = 2;
            // 
            // btnZmienStatus
            // 
            btnZmienStatus.Location = new Point(300, 359);
            btnZmienStatus.Name = "btnZmienStatus";
            btnZmienStatus.Size = new Size(203, 54);
            btnZmienStatus.TabIndex = 3;
            btnZmienStatus.Text = "Zmień status";
            btnZmienStatus.UseVisualStyleBackColor = true;
            // 
            // FormListaAwarii
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnZmienStatus);
            Controls.Add(cmbFiltr);
            Controls.Add(lblFiltruj);
            Controls.Add(dgvLista);
            Name = "FormListaAwarii";
            Text = "FormListaAwarii";
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLista;
        private Label lblFiltruj;
        private ComboBox cmbFiltr;
        private Button btnZmienStatus;
    }
}