namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRow = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRow.Location = new System.Drawing.Point(47, 43);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(62, 31);
            this.lblRow.TabIndex = 0;
            this.lblRow.Text = "列數";
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(53, 103);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "靠左";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnMid
            // 
            this.btnMid.Location = new System.Drawing.Point(156, 103);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(75, 23);
            this.btnMid.TabIndex = 1;
            this.btnMid.Text = "等腰";
            this.btnMid.UseVisualStyleBackColor = true;
            this.btnMid.Click += new System.EventHandler(this.btnMid_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(259, 103);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "靠右";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(115, 52);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(183, 22);
            this.txtBox1.TabIndex = 2;
            // 
            // txtStar
            // 
            this.txtStar.Location = new System.Drawing.Point(106, 157);
            this.txtStar.Multiline = true;
            this.txtStar.Name = "txtStar";
            this.txtStar.ReadOnly = true;
            this.txtStar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStar.Size = new System.Drawing.Size(183, 108);
            this.txtStar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 349);
            this.Controls.Add(this.txtStar);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnMid);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.lblRow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtStar;
    }
}

