namespace Election_Database_App
{
    partial class FrmVote
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
            this.TxtDistrictName = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnVote = new System.Windows.Forms.Button();
            this.BtnGraphics = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "District Name:";
            // 
            // TxtDistrictName
            // 
            this.TxtDistrictName.Location = new System.Drawing.Point(146, 59);
            this.TxtDistrictName.Name = "TxtDistrictName";
            this.TxtDistrictName.Size = new System.Drawing.Size(318, 29);
            this.TxtDistrictName.TabIndex = 1;
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(146, 116);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(318, 29);
            this.TxtA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Party A:";
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(146, 177);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(318, 29);
            this.TxtB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Party B:";
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(146, 241);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(318, 29);
            this.TxtC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Party C:";
            // 
            // TxtD
            // 
            this.TxtD.Location = new System.Drawing.Point(146, 309);
            this.TxtD.Name = "TxtD";
            this.TxtD.Size = new System.Drawing.Size(318, 29);
            this.TxtD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Party D:";
            // 
            // TxtE
            // 
            this.TxtE.Location = new System.Drawing.Point(146, 379);
            this.TxtE.Name = "TxtE";
            this.TxtE.Size = new System.Drawing.Size(318, 29);
            this.TxtE.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Party E:";
            // 
            // BtnVote
            // 
            this.BtnVote.Location = new System.Drawing.Point(146, 446);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(318, 33);
            this.BtnVote.TabIndex = 12;
            this.BtnVote.Text = "Vote";
            this.BtnVote.UseVisualStyleBackColor = true;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // BtnGraphics
            // 
            this.BtnGraphics.Location = new System.Drawing.Point(146, 502);
            this.BtnGraphics.Name = "BtnGraphics";
            this.BtnGraphics.Size = new System.Drawing.Size(157, 33);
            this.BtnGraphics.TabIndex = 14;
            this.BtnGraphics.Text = "Graphics";
            this.BtnGraphics.UseVisualStyleBackColor = true;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(309, 502);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(155, 33);
            this.BtnLogout.TabIndex = 15;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.UseVisualStyleBackColor = true;
            // 
            // FrmVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(712, 584);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnGraphics);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.TxtE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDistrictName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVote";
            this.Text = "DBGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDistrictName;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnVote;
        private System.Windows.Forms.Button BtnGraphics;
        private System.Windows.Forms.Button BtnLogout;
    }
}

