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
            btnClearFiltr = new Button();
            btnZamknij = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvLista.Location = new Point(28, 93);
            dgvLista.Name = "dgvLista";
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
            btnZmienStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnZmienStatus.Location = new Point(300, 359);
            btnZmienStatus.Name = "btnZmienStatus";
            btnZmienStatus.Size = new Size(203, 54);
            btnZmienStatus.TabIndex = 3;
            btnZmienStatus.Text = "Zmień status";
            btnZmienStatus.UseVisualStyleBackColor = true;
            btnZmienStatus.Click += btnZmienStatus_Click;
            // 
            // btnClearFiltr
            // 
            btnClearFiltr.Location = new Point(261, 52);
            btnClearFiltr.Name = "btnClearFiltr";
            btnClearFiltr.Size = new Size(89, 23);
            btnClearFiltr.TabIndex = 4;
            btnClearFiltr.Text = "Wyczyść Filtr";
            btnClearFiltr.UseVisualStyleBackColor = true;
            btnClearFiltr.Click += btnClearFiltr_Click;
            // 
            // btnZamknij
            // 
            btnZamknij.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZamknij.Location = new Point(558, 22);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Size = new Size(203, 54);
            btnZamknij.TabIndex = 5;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = true;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // FormListaAwarii
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnZamknij);
            Controls.Add(btnClearFiltr);
            Controls.Add(btnZmienStatus);
            Controls.Add(cmbFiltr);
            Controls.Add(lblFiltruj);
            Controls.Add(dgvLista);
            Name = "FormListaAwarii";
            Text = "FormListaAwarii";
            Load += FormListaAwarii_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLista;
        private Label lblFiltruj;
        private ComboBox cmbFiltr;
        private Button btnZmienStatus;
        private Button btnClearFiltr;
        private Button btnZamknij;
    }
}