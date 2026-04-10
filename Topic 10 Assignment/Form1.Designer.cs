namespace Topic_10_Assignment
{
    partial class FormAssignment10
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
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnRAM = new System.Windows.Forms.Button();
            this.btnSSD = new System.Windows.Forms.Button();
            this.btnPowerS = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.imgComputerComponants = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerComponants)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCPU
            // 
            this.btnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCPU.Location = new System.Drawing.Point(44, 47);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(199, 74);
            this.btnCPU.TabIndex = 1;
            this.btnCPU.Text = "CPU";
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnRAM
            // 
            this.btnRAM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRAM.Location = new System.Drawing.Point(44, 188);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Size = new System.Drawing.Size(199, 74);
            this.btnRAM.TabIndex = 2;
            this.btnRAM.Text = "RAM";
            this.btnRAM.UseVisualStyleBackColor = true;
            this.btnRAM.Click += new System.EventHandler(this.btnRAM_Click);
            // 
            // btnSSD
            // 
            this.btnSSD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSSD.Location = new System.Drawing.Point(44, 335);
            this.btnSSD.Name = "btnSSD";
            this.btnSSD.Size = new System.Drawing.Size(199, 74);
            this.btnSSD.TabIndex = 3;
            this.btnSSD.Text = "SSD";
            this.btnSSD.UseVisualStyleBackColor = true;
            this.btnSSD.Click += new System.EventHandler(this.btnSSD_Click);
            // 
            // btnPowerS
            // 
            this.btnPowerS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPowerS.Location = new System.Drawing.Point(44, 479);
            this.btnPowerS.Name = "btnPowerS";
            this.btnPowerS.Size = new System.Drawing.Size(199, 111);
            this.btnPowerS.TabIndex = 4;
            this.btnPowerS.Text = "Power Supply";
            this.btnPowerS.UseVisualStyleBackColor = true;
            this.btnPowerS.Click += new System.EventHandler(this.btnPowerS_Click);
            // 
            // btnInput
            // 
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInput.Location = new System.Drawing.Point(44, 661);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(199, 117);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Input Peripheral";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOutput.Location = new System.Drawing.Point(44, 827);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(199, 115);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "Output Peripheral";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(569, 661);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(298, 50);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Nothing Selected";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(404, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(628, 50);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Please select something to learn more";
            // 
            // imgComputerComponants
            // 
            this.imgComputerComponants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgComputerComponants.Image = global::Topic_10_Assignment.Properties.Resources.CPU;
            this.imgComputerComponants.Location = new System.Drawing.Point(453, 89);
            this.imgComputerComponants.Name = "imgComputerComponants";
            this.imgComputerComponants.Size = new System.Drawing.Size(528, 526);
            this.imgComputerComponants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgComputerComponants.TabIndex = 0;
            this.imgComputerComponants.TabStop = false;
            this.imgComputerComponants.Visible = false;
            // 
            // FormAssignment10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1284, 1005);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnPowerS);
            this.Controls.Add(this.btnSSD);
            this.Controls.Add(this.btnRAM);
            this.Controls.Add(this.btnCPU);
            this.Controls.Add(this.imgComputerComponants);
            this.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.Name = "FormAssignment10";
            this.Text = "Adding Resources";
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerComponants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgComputerComponants;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnRAM;
        private System.Windows.Forms.Button btnSSD;
        private System.Windows.Forms.Button btnPowerS;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblInfo;
    }
}

