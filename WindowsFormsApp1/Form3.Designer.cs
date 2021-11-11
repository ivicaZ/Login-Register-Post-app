namespace WindowsFormsApp1
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(291, 158);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(194, 20);
            this.user.TabIndex = 2;
            this.user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(291, 198);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(195, 20);
            this.pass.TabIndex = 3;
            this.pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
    }
}