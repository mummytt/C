namespace Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbgiatri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập n";
            // 
            // tbSon
            // 
            this.tbSon.Location = new System.Drawing.Point(216, 20);
            this.tbSon.Name = "tbSon";
            this.tbSon.Size = new System.Drawing.Size(208, 20);
            this.tbSon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Các số nguyên tố nhỏ hơn n";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(216, 69);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(208, 20);
            this.tbResult.TabIndex = 3;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(268, 117);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbgiatri
            // 
            this.lbgiatri.AutoSize = true;
            this.lbgiatri.Location = new System.Drawing.Point(466, 23);
            this.lbgiatri.Name = "lbgiatri";
            this.lbgiatri.Size = new System.Drawing.Size(35, 13);
            this.lbgiatri.TabIndex = 5;
            this.lbgiatri.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 175);
            this.Controls.Add(this.lbgiatri);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSon);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbgiatri;
    }
}

