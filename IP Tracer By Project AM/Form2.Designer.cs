
namespace IP_Tracer_By_Project_AM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.imgMap = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMap)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMap
            // 
            this.imgMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMap.Image = ((System.Drawing.Image)(resources.GetObject("imgMap.Image")));
            this.imgMap.Location = new System.Drawing.Point(1, 51);
            this.imgMap.Name = "imgMap";
            this.imgMap.Size = new System.Drawing.Size(1216, 684);
            this.imgMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMap.TabIndex = 18;
            this.imgMap.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "IP Address:";
            // 
            // lblLongitude
            // 
            this.lblLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(977, 22);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(60, 13);
            this.lblLongitude.TabIndex = 24;
            this.lblLongitude.Text = "Longitude: ";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(349, 22);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 23;
            this.lblCity.Text = "City: ";
            // 
            // lblLatitude
            // 
            this.lblLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(728, 22);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(51, 13);
            this.lblLatitude.TabIndex = 22;
            this.lblLatitude.Text = "Latitude: ";
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(505, 22);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(49, 13);
            this.lblCountry.TabIndex = 21;
            this.lblCountry.Text = "Country: ";
            // 
            // txtIP
            // 
            this.txtIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIP.Location = new System.Drawing.Point(90, 19);
            this.txtIP.MaxLength = 15;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(131, 20);
            this.txtIP.TabIndex = 20;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(227, 15);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 26);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Find Me";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 731);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.imgMap);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maps";
            ((System.ComponentModel.ISupportInitialize)(this.imgMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnSubmit;
    }
}