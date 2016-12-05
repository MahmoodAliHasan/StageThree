namespace extraFloatFromString
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.floatLBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtInput.Location = new System.Drawing.Point(27, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(285, 24);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "1 2.k k.2 2k22.2 33.44k 33.324";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(54, 80);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(243, 43);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get Float Number";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // floatLBox
            // 
            this.floatLBox.FormattingEnabled = true;
            this.floatLBox.Location = new System.Drawing.Point(12, 142);
            this.floatLBox.Name = "floatLBox";
            this.floatLBox.Size = new System.Drawing.Size(309, 147);
            this.floatLBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 291);
            this.Controls.Add(this.floatLBox);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ListBox floatLBox;
    }
}

