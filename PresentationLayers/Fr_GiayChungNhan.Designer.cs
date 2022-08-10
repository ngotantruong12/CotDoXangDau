namespace PresentationLayers
{
    partial class Fr_GiayChungNhan
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
            this.crystalReportGKD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.GiayKG1 = new PresentationLayers.GiayKG();
            this.SuspendLayout();
            // 
            // crystalReportGKD
            // 
            this.crystalReportGKD.ActiveViewIndex = 0;
            this.crystalReportGKD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportGKD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportGKD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportGKD.Location = new System.Drawing.Point(0, 0);
            this.crystalReportGKD.Name = "crystalReportGKD";
            this.crystalReportGKD.ReportSource = this.GiayKG1;
            this.crystalReportGKD.Size = new System.Drawing.Size(826, 366);
            this.crystalReportGKD.TabIndex = 0;
            // 
            // Fr_GiayChungNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 366);
            this.Controls.Add(this.crystalReportGKD);
            this.Name = "Fr_GiayChungNhan";
            this.Text = "Fr_GiayChungNhan";
            this.Load += new System.EventHandler(this.Fr_GiayChungNhan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportGKD;
        private GiayKG GiayKG1;
    }
}