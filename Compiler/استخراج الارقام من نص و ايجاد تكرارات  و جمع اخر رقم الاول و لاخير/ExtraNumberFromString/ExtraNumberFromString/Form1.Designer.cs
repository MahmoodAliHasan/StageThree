namespace ExtraNumberFromString
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richTxt_input = new System.Windows.Forms.RichTextBox();
            this.btnGetNumber = new MaterialSkin.Controls.MaterialRaisedButton();
            this.GDV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSumof = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GDV)).BeginInit();
            this.SuspendLayout();
            // 
            // richTxt_input
            // 
            this.richTxt_input.Font = new System.Drawing.Font("Roboto", 15.25F);
            this.richTxt_input.Location = new System.Drawing.Point(12, 119);
            this.richTxt_input.Name = "richTxt_input";
            this.richTxt_input.Size = new System.Drawing.Size(717, 80);
            this.richTxt_input.TabIndex = 0;
            this.richTxt_input.Text = "hello  3 3 55 87 5 55 87 87";
            // 
            // btnGetNumber
            // 
            this.btnGetNumber.Depth = 0;
            this.btnGetNumber.Location = new System.Drawing.Point(196, 214);
            this.btnGetNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGetNumber.Name = "btnGetNumber";
            this.btnGetNumber.Primary = true;
            this.btnGetNumber.Size = new System.Drawing.Size(337, 74);
            this.btnGetNumber.TabIndex = 2;
            this.btnGetNumber.Text = "Get Number";
            this.btnGetNumber.UseVisualStyleBackColor = true;
            this.btnGetNumber.Click += new System.EventHandler(this.btnGetNumber_Click);
            // 
            // GDV
            // 
            this.GDV.AllowUserToAddRows = false;
            this.GDV.AllowUserToDeleteRows = false;
            this.GDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GDV.BackgroundColor = System.Drawing.Color.White;
            this.GDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GDV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GDV.ColumnHeadersHeight = 30;
            this.GDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.GDV.EnableHeadersVisualStyles = false;
            this.GDV.Location = new System.Drawing.Point(148, 335);
            this.GDV.Name = "GDV";
            this.GDV.ReadOnly = true;
            this.GDV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GDV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GDV.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 15.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.GDV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GDV.Size = new System.Drawing.Size(450, 150);
            this.GDV.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Count";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type some things";
            // 
            // lblSumof
            // 
            this.lblSumof.BackColor = System.Drawing.Color.Transparent;
            this.lblSumof.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumof.Location = new System.Drawing.Point(12, 301);
            this.lblSumof.Name = "lblSumof";
            this.lblSumof.Size = new System.Drawing.Size(717, 24);
            this.lblSumof.TabIndex = 6;
            this.lblSumof.Text = "Sum of :";
            this.lblSumof.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 497);
            this.Controls.Add(this.lblSumof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GDV);
            this.Controls.Add(this.btnGetNumber);
            this.Controls.Add(this.richTxt_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxt_input;
        private MaterialSkin.Controls.MaterialRaisedButton btnGetNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView GDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSumof;
    }
}

