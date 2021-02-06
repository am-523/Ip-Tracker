
namespace IP_Tracer_By_Project_AM
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
            this.btnFetchCurrentIPLocation = new System.Windows.Forms.Button();
            this.txtIPLocationResult = new System.Windows.Forms.TextBox();
            this.btnFetchLocationDetails = new System.Windows.Forms.Button();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFetchCurrentIPLocation
            // 
            this.btnFetchCurrentIPLocation.Location = new System.Drawing.Point(1075, 723);
            this.btnFetchCurrentIPLocation.Name = "btnFetchCurrentIPLocation";
            this.btnFetchCurrentIPLocation.Size = new System.Drawing.Size(100, 23);
            this.btnFetchCurrentIPLocation.TabIndex = 9;
            this.btnFetchCurrentIPLocation.Text = "Fetch Current IP";
            this.btnFetchCurrentIPLocation.UseVisualStyleBackColor = true;
            // 
            // txtIPLocationResult
            // 
            this.txtIPLocationResult.Location = new System.Drawing.Point(29, 166);
            this.txtIPLocationResult.Multiline = true;
            this.txtIPLocationResult.Name = "txtIPLocationResult";
            this.txtIPLocationResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIPLocationResult.Size = new System.Drawing.Size(344, 419);
            this.txtIPLocationResult.TabIndex = 8;
            // 
            // btnFetchLocationDetails
            // 
            this.btnFetchLocationDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(187)))), ((int)(((byte)(220)))));
            this.btnFetchLocationDetails.FlatAppearance.BorderSize = 0;
            this.btnFetchLocationDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchLocationDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchLocationDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFetchLocationDetails.Location = new System.Drawing.Point(193, 123);
            this.btnFetchLocationDetails.Name = "btnFetchLocationDetails";
            this.btnFetchLocationDetails.Size = new System.Drawing.Size(87, 31);
            this.btnFetchLocationDetails.TabIndex = 7;
            this.btnFetchLocationDetails.Text = "Track";
            this.btnFetchLocationDetails.UseVisualStyleBackColor = false;
            this.btnFetchLocationDetails.Click += new System.EventHandler(this.btnFetchLocationDetails_Click);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(29, 129);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(153, 20);
            this.txtIPAddress.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(187)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 77);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "IP TRACKER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(327, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Project AM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(187)))), ((int)(((byte)(220)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(286, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Maps";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(407, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIPLocationResult);
            this.Controls.Add(this.btnFetchLocationDetails);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFetchCurrentIPLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP - Tracker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFetchCurrentIPLocation;
        private System.Windows.Forms.TextBox txtIPLocationResult;
        private System.Windows.Forms.Button btnFetchLocationDetails;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

