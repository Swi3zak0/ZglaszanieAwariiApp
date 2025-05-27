namespace ZglaszanieAwariiApp.Forms
{
    partial class MainForm
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
            btnZglosAwarie = new Button();
            btnListaAwarii = new Button();
            btnSprawdzStatus = new Button();
            SuspendLayout();
            // 
            // btnZglosAwarie
            // 
            btnZglosAwarie.Location = new Point(620, 77);
            btnZglosAwarie.Name = "btnZglosAwarie";
            btnZglosAwarie.Size = new Size(131, 23);
            btnZglosAwarie.TabIndex = 0;
            btnZglosAwarie.Text = "Zgłoś awarię";
            btnZglosAwarie.UseVisualStyleBackColor = true;
            btnZglosAwarie.Click += btnZglosAwarie_Click;
            // 
            // btnListaAwarii
            // 
            btnListaAwarii.Location = new Point(620, 178);
            btnListaAwarii.Name = "btnListaAwarii";
            btnListaAwarii.Size = new Size(131, 23);
            btnListaAwarii.TabIndex = 1;
            btnListaAwarii.Text = "Wszystkie Awarie";
            btnListaAwarii.UseVisualStyleBackColor = true;
            btnListaAwarii.Click += btnListaAwarii_Click;
            // 
            // btnSprawdzStatus
            // 
            btnSprawdzStatus.Location = new Point(620, 282);
            btnSprawdzStatus.Name = "btnSprawdzStatus";
            btnSprawdzStatus.Size = new Size(131, 23);
            btnSprawdzStatus.TabIndex = 2;
            btnSprawdzStatus.Text = "Sprawdź Status";
            btnSprawdzStatus.UseVisualStyleBackColor = true;
            btnSprawdzStatus.Click += btnSprawdzStatus_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSprawdzStatus);
            Controls.Add(btnListaAwarii);
            Controls.Add(btnZglosAwarie);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnZglosAwarie;
        private Button btnListaAwarii;
        private Button btnSprawdzStatus;
    }
}