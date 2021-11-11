namespace WindowsFormsApp1
{
    partial class Form2
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
        private void InitializeComponent( )
        {
            this.postText = new System.Windows.Forms.TextBox();
            this.post = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postText
            // 
            this.postText.Location = new System.Drawing.Point(12, 444);
            this.postText.Multiline = true;
            this.postText.Name = "postText";
            this.postText.Size = new System.Drawing.Size(572, 66);
            this.postText.TabIndex = 0;
            this.postText.TextChanged += new System.EventHandler(this.postText_TextChanged);
            // 
            // post
            // 
            this.post.Location = new System.Drawing.Point(590, 444);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(175, 66);
            this.post.TabIndex = 1;
            this.post.Text = "post";
            this.post.UseVisualStyleBackColor = true;
            this.post.Click += new System.EventHandler(this.post_Click);
            // 
            // Form2
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(774, 520);
            this.Controls.Add(this.post);
            this.Controls.Add(this.postText);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox postText;
        private System.Windows.Forms.Button post;
    }
}