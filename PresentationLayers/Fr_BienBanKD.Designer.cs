namespace PresentationLayers
{
    partial class Fr_BienBanKD
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
            this.crrp_BBKG = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpBBKD_TB1 = new PresentationLayers.rpBBKD_TB();
            this.SuspendLayout();
            // 
            // crrp_BBKG
            // 
            this.crrp_BBKG.ActiveViewIndex = 0;
            this.crrp_BBKG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crrp_BBKG.Cursor = System.Windows.Forms.Cursors.Default;
            this.crrp_BBKG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crrp_BBKG.Location = new System.Drawing.Point(0, 0);
            this.crrp_BBKG.Name = "crrp_BBKG";
            this.crrp_BBKG.ReportSource = this.rpBBKD_TB1;
            this.crrp_BBKG.Size = new System.Drawing.Size(964, 599);
            this.crrp_BBKG.TabIndex = 0;
            // 
            // Fr_BienBanKD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 599);
            this.Controls.Add(this.crrp_BBKG);
            this.Name = "Fr_BienBanKD";
            this.Text = "Fr_BienBanKD";
            this.Load += new System.EventHandler(this.Fr_BienBanKD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crrp_BBKG;
        private rpBBKD_TB rpBBKD_TB1;
    }
}