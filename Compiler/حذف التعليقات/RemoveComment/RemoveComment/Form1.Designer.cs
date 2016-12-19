namespace RemoveComment
{
    partial class Form1
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
            this.btnSpilt = new System.Windows.Forms.Button();
            this.btn_NoOfWord = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.rich_output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSpilt
            // 
            this.btnSpilt.Location = new System.Drawing.Point(12, 35);
            this.btnSpilt.Name = "btnSpilt";
            this.btnSpilt.Size = new System.Drawing.Size(75, 23);
            this.btnSpilt.TabIndex = 0;
            this.btnSpilt.Text = "Spilt";
            this.btnSpilt.UseVisualStyleBackColor = true;
            this.btnSpilt.Click += new System.EventHandler(this.btnSpilt_Click);
            // 
            // btn_NoOfWord
            // 
            this.btn_NoOfWord.Location = new System.Drawing.Point(12, 108);
            this.btn_NoOfWord.Name = "btn_NoOfWord";
            this.btn_NoOfWord.Size = new System.Drawing.Size(75, 23);
            this.btn_NoOfWord.TabIndex = 1;
            this.btn_NoOfWord.Text = "No of Word";
            this.btn_NoOfWord.UseVisualStyleBackColor = true;
            this.btn_NoOfWord.Click += new System.EventHandler(this.btn_NoOfWord_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(12, 192);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(134, 43);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(146, 20);
            this.txt_input.TabIndex = 3;
            this.txt_input.Text = "/* int i ; */";
            // 
            // rich_output
            // 
            this.rich_output.Location = new System.Drawing.Point(126, 90);
            this.rich_output.Name = "rich_output";
            this.rich_output.Size = new System.Drawing.Size(146, 102);
            this.rich_output.TabIndex = 4;
            this.rich_output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rich_output);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_NoOfWord);
            this.Controls.Add(this.btnSpilt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpilt;
        private System.Windows.Forms.Button btn_NoOfWord;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.RichTextBox rich_output;
    }
}

