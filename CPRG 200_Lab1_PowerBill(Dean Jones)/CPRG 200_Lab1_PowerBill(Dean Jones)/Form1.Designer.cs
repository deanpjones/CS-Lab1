namespace CPRG_200_Lab1_PowerBill_Dean_Jones_
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.txtPowerUsage = new System.Windows.Forms.TextBox();
            this.lblKw1 = new System.Windows.Forms.Label();
            this.txtDisplayCharge = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsage1 = new System.Windows.Forms.Label();
            this.lblUsage2 = new System.Windows.Forms.Label();
            this.lblKw2 = new System.Windows.Forms.Label();
            this.txtPowerUsage2 = new System.Windows.Forms.TextBox();
            this.btnCalculateUsage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picDisplayImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radIndustrial);
            this.groupBox1.Controls.Add(this.radCommercial);
            this.groupBox1.Controls.Add(this.radResidential);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Type";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(17, 86);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(87, 20);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(17, 60);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(100, 20);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Checked = true;
            this.radResidential.Location = new System.Drawing.Point(17, 34);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(96, 20);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // txtPowerUsage
            // 
            this.txtPowerUsage.Location = new System.Drawing.Point(420, 141);
            this.txtPowerUsage.Name = "txtPowerUsage";
            this.txtPowerUsage.Size = new System.Drawing.Size(110, 27);
            this.txtPowerUsage.TabIndex = 0;
            this.txtPowerUsage.Tag = "Power Usage";
            // 
            // lblKw1
            // 
            this.lblKw1.AutoSize = true;
            this.lblKw1.Location = new System.Drawing.Point(536, 150);
            this.lblKw1.Name = "lblKw1";
            this.lblKw1.Size = new System.Drawing.Size(44, 18);
            this.lblKw1.TabIndex = 7;
            this.lblKw1.Text = "kWh";
            // 
            // txtDisplayCharge
            // 
            this.txtDisplayCharge.Enabled = false;
            this.txtDisplayCharge.Location = new System.Drawing.Point(420, 263);
            this.txtDisplayCharge.Name = "txtDisplayCharge";
            this.txtDisplayCharge.Size = new System.Drawing.Size(110, 27);
            this.txtDisplayCharge.TabIndex = 5;
            this.txtDisplayCharge.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(420, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(262, 333);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(28, 23);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(264, 25);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Charge Owing:";
            // 
            // lblUsage1
            // 
            this.lblUsage1.AutoSize = true;
            this.lblUsage1.Location = new System.Drawing.Point(22, 35);
            this.lblUsage1.Name = "lblUsage1";
            this.lblUsage1.Size = new System.Drawing.Size(121, 18);
            this.lblUsage1.TabIndex = 2;
            this.lblUsage1.Text = "Power Usage:";
            // 
            // lblUsage2
            // 
            this.lblUsage2.AutoSize = true;
            this.lblUsage2.Location = new System.Drawing.Point(22, 66);
            this.lblUsage2.Name = "lblUsage2";
            this.lblUsage2.Size = new System.Drawing.Size(121, 18);
            this.lblUsage2.TabIndex = 3;
            this.lblUsage2.Text = "Power Usage:";
            // 
            // lblKw2
            // 
            this.lblKw2.AutoSize = true;
            this.lblKw2.Location = new System.Drawing.Point(353, 66);
            this.lblKw2.Name = "lblKw2";
            this.lblKw2.Size = new System.Drawing.Size(44, 18);
            this.lblKw2.TabIndex = 5;
            this.lblKw2.Text = "kWh";
            // 
            // txtPowerUsage2
            // 
            this.txtPowerUsage2.Location = new System.Drawing.Point(237, 57);
            this.txtPowerUsage2.Name = "txtPowerUsage2";
            this.txtPowerUsage2.Size = new System.Drawing.Size(110, 27);
            this.txtPowerUsage2.TabIndex = 1;
            this.txtPowerUsage2.Tag = "Power Usage";
            // 
            // btnCalculateUsage
            // 
            this.btnCalculateUsage.Location = new System.Drawing.Point(237, 102);
            this.btnCalculateUsage.Name = "btnCalculateUsage";
            this.btnCalculateUsage.Size = new System.Drawing.Size(110, 40);
            this.btnCalculateUsage.TabIndex = 2;
            this.btnCalculateUsage.Text = "&Calculate";
            this.btnCalculateUsage.UseVisualStyleBackColor = true;
            this.btnCalculateUsage.Click += new System.EventHandler(this.btnCalculateUsage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalculateUsage);
            this.groupBox2.Controls.Add(this.txtPowerUsage2);
            this.groupBox2.Controls.Add(this.lblKw2);
            this.groupBox2.Controls.Add(this.lblUsage2);
            this.groupBox2.Controls.Add(this.lblUsage1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(183, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate Power Bill";
            // 
            // picDisplayImage
            // 
            this.picDisplayImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDisplayImage.Location = new System.Drawing.Point(420, 12);
            this.picDisplayImage.Name = "picDisplayImage";
            this.picDisplayImage.Size = new System.Drawing.Size(198, 97);
            this.picDisplayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplayImage.TabIndex = 8;
            this.picDisplayImage.TabStop = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculateUsage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(680, 394);
            this.Controls.Add(this.picDisplayImage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDisplayCharge);
            this.Controls.Add(this.txtPowerUsage);
            this.Controls.Add(this.lblKw1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Bill Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.TextBox txtPowerUsage;
        private System.Windows.Forms.Label lblKw1;
        private System.Windows.Forms.TextBox txtDisplayCharge;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsage1;
        private System.Windows.Forms.Label lblUsage2;
        private System.Windows.Forms.Label lblKw2;
        private System.Windows.Forms.TextBox txtPowerUsage2;
        private System.Windows.Forms.Button btnCalculateUsage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picDisplayImage;
    }
}

