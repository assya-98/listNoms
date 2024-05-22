namespace listNom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtPrenom = new TextBox();
            lblPrenom = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(248, 221);
            button1.Name = "button1";
            button1.Size = new Size(198, 106);
            button1.TabIndex = 0;
            button1.Text = "Dire bonjour";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnsalut_Click;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(240, 153);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(233, 23);
            txtPrenom.TabIndex = 1;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(242, 128);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(120, 15);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Entrez votre prénom :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 438);
            Controls.Add(lblPrenom);
            Controls.Add(txtPrenom);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Click += btnsalut_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtPrenom;
        private Label lblPrenom;
    }
}
