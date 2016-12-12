namespace ExraSpecifcChar
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
            this.btn_Done = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbox_char = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Done
            // 
            this.btn_Done.Depth = 0;
            this.btn_Done.Location = new System.Drawing.Point(125, 113);
            this.btn_Done.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Primary = true;
            this.btn_Done.Size = new System.Drawing.Size(233, 59);
            this.btn_Done.TabIndex = 0;
            this.btn_Done.Text = "Extra specifc char";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(125, 40);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(256, 20);
            this.txtInput.TabIndex = 1;
            // 
            // lbox_char
            // 
            this.lbox_char.FormattingEnabled = true;
            this.lbox_char.Location = new System.Drawing.Point(125, 199);
            this.lbox_char.Name = "lbox_char";
            this.lbox_char.Size = new System.Drawing.Size(233, 121);
            this.lbox_char.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 341);
            this.Controls.Add(this.lbox_char);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btn_Done);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btn_Done;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lbox_char;
    }
}

