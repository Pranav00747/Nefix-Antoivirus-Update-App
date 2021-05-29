namespace netfixupd
{
    partial class netfixupdate
    {
        private System.Windows.Forms.Label updatelabel;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Button finishbutton, cancelbutton;
        private System.Windows.Forms.ToolTip tooltip;

        #region netfixupd design code

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White),
                new System.Drawing.Rectangle(0, 0, 599, 80));
            e.Graphics.DrawLine(new System.Drawing.Pen(new System.Drawing.SolidBrush(System.Drawing.SystemColors.ActiveBorder)),
                new System.Drawing.Point(0, 79), new System.Drawing.Point(599, 79));
            e.Graphics.DrawString(global::netfixupd.Resource.Bold_Title, new System.Drawing.Font("MS Shell Dlg", 10.0f, System.Drawing.FontStyle.Bold),
                System.Drawing.Brushes.Black, new System.Drawing.Point(15, 10));
            e.Graphics.DrawString(global::netfixupd.Resource.InTitle, new System.Drawing.Font("MS Shell Dlg", 9.0f, System.Drawing.FontStyle.Regular),
              System.Drawing.Brushes.Black, new System.Drawing.Point(25, 
                  45));

            e.Graphics.DrawImage(global::netfixupd.Resource.netfix, new System.Drawing.Rectangle(529, 15, 48, 48));

            e.Graphics.Dispose();
            base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            this.tooltip = new System.Windows.Forms.ToolTip();

            this.updatelabel = new System.Windows.Forms.Label();
            this.updatelabel.Location = new System.Drawing.Point(50, 145);
            this.updatelabel.Size = new System.Drawing.Size(100, 15);
            this.updatelabel.Text = "Saving Updates";

            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.progressbar.Location = new System.Drawing.Point(50, 175);
            this.progressbar.Size = new System.Drawing.Size(499, 18);
            this.progressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressbar.Step = 10;
            this.progressbar.PerformStep();

            this.finishbutton = new System.Windows.Forms.Button();
            this.finishbutton.Location = new System.Drawing.Point(319, 349);
            this.finishbutton.Size = new System.Drawing.Size(100, 22);
            this.finishbutton.Enabled = false;
            this.finishbutton.Text = "Finish";
            this.finishbutton.UseVisualStyleBackColor = true;
            this.finishbutton.Cursor = System.Windows.Forms.Cursors.Hand; 

            this.cancelbutton = new System.Windows.Forms.Button();
            this.cancelbutton.Location = new System.Drawing.Point(429, 349);
            this.cancelbutton.Size = new System.Drawing.Size(100, 22);
            this.cancelbutton.Enabled = true;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbutton.Click +=new System.EventHandler(this.cancelbutton_Click);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(599, 426);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Text = "Netfix AntiVirus - Update";
            this.ShowIcon = true;
            this.Icon = new System.Drawing.Icon(System.Drawing.Icon.FromHandle((
                global::netfixupd.Resource.netfix as System.Drawing.Bitmap).GetHicon()), new System.Drawing.Size(32, 32));

            this.tooltip.SetToolTip(this.cancelbutton, this.cancelbutton.Text);
            this.tooltip.SetToolTip(this.finishbutton, this.finishbutton.Text);

            this.Controls.Add(this.updatelabel);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.finishbutton);
            this.Controls.Add(this.cancelbutton);
        }

        #endregion
    }
}
