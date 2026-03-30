namespace LoginForm1
{
    partial class frmHome
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
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTC = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnPb = new System.Windows.Forms.Button();
            this.btnSS = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(74, 363);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 57);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hi, JOHN TRISTAN";
            // 
            // btnTC
            // 
            this.btnTC.Image = global::LoginForm1.Properties.Resources._655567778_1476174707633096_8729705329298913769_n;
            this.btnTC.Location = new System.Drawing.Point(576, 198);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(194, 147);
            this.btnTC.TabIndex = 5;
            this.btnTC.Text = "Time Clock";
            this.btnTC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTC.UseVisualStyleBackColor = true;
            this.btnTC.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnU
            // 
            this.btnU.Image = global::LoginForm1.Properties.Resources._656898315_1437198527626720_3412215772783661709_n;
            this.btnU.Location = new System.Drawing.Point(304, 198);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(205, 147);
            this.btnU.TabIndex = 4;
            this.btnU.Text = "Users";
            this.btnU.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnV
            // 
            this.btnV.Image = global::LoginForm1.Properties.Resources._657598090_1237847625081655_2273660966732946430_n;
            this.btnV.Location = new System.Drawing.Point(29, 198);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(213, 147);
            this.btnV.TabIndex = 3;
            this.btnV.Text = "Vendors";
            this.btnV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnPb
            // 
            this.btnPb.Image = global::LoginForm1.Properties.Resources._657153139_1592884642323690_286831136424318174_n;
            this.btnPb.Location = new System.Drawing.Point(576, 41);
            this.btnPb.Name = "btnPb";
            this.btnPb.Size = new System.Drawing.Size(194, 139);
            this.btnPb.TabIndex = 2;
            this.btnPb.Text = "Pricebook";
            this.btnPb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPb.UseVisualStyleBackColor = true;
            this.btnPb.Click += new System.EventHandler(this.btnPb_Click);
            // 
            // btnSS
            // 
            this.btnSS.Image = global::LoginForm1.Properties.Resources._641106826_26612544121712224_8043057788420945592_n;
            this.btnSS.Location = new System.Drawing.Point(304, 40);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(205, 140);
            this.btnSS.TabIndex = 1;
            this.btnSS.Text = "Store Status";
            this.btnSS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnR
            // 
            this.btnR.Image = global::LoginForm1.Properties.Resources._654678603_4404122866486258_1076709274772805719_n;
            this.btnR.Location = new System.Drawing.Point(29, 40);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(213, 140);
            this.btnR.TabIndex = 0;
            this.btnR.Text = "Register";
            this.btnR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnTC);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnPb);
            this.Controls.Add(this.btnSS);
            this.Controls.Add(this.btnR);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnSS;
        private System.Windows.Forms.Button btnPb;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnTC;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}