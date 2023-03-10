namespace netfixupd
{
    partial class netfixupdate
    {
        private System.Windows.Forms.Label updatelabel;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Button finishbutton, cancelbutton;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Label click1;

        #region netfixupd design code

        private void click1_click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
        private void mEnter(object sender, System.EventArgs e)
        {
            (sender as System.Windows.Forms.Label).ForeColor = System.Drawing.Color.Yellow;
        }
        private void mLeave(object sender, System.EventArgs e)
        {
            (sender as System.Windows.Forms.Label).ForeColor = System.Drawing.Color.White;
        }
        private void setImage(System.Drawing.Graphics g)
        {
            g.DrawImage(global::netfixupd.Resource.Netfix, new System.Drawing.Point(this.Width - 110, 40));
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush tbrush = new System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Rectangle(0, 0, this.Width,
                30), System.Drawing.Color.FromArgb(10, 23, 41), System.Drawing.Color.FromArgb(23, 46, 75), System.Drawing.Drawing2D.LinearGradientMode.Vertical);

            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Rectangle(0, 0, this.Width,
                this.Height), System.Drawing.Color.FromArgb(1, 31, 70), System.Drawing.Color.FromArgb(59, 92, 134), System.Drawing.Drawing2D.LinearGradientMode.Vertical);

           

            e.Graphics.FillRectangle(brush, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.FillRectangle(tbrush, new System.Drawing.Rectangle(0, 0, this.Width, 30));
            e.Graphics.DrawString(global::netfixupd.Resource.Bold_Title, new System.Drawing.Font("MS Shell Dlg", 8.0f, System.Drawing.FontStyle.Regular),
               System.Drawing.Brushes.White, new System.Drawing.Point(5, 5));

            e.Graphics.DrawLine(new System.Drawing.Pen(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(1, 31, 70))),
                new System.Drawing.Point(0, 99), new System.Drawing.Point(599, 99));
            e.Graphics.DrawString(global::netfixupd.Resource.Bold_Title, new System.Drawing.Font("MS Shell Dlg", 10.0f, System.Drawing.FontStyle.Bold),
                System.Drawing.Brushes.White, new System.Drawing.Point(15, 50));
            e.Graphics.DrawString(global::netfixupd.Resource.InTitle, new System.Drawing.Font("MS Shell Dlg", 9.0f, System.Drawing.FontStyle.Regular),
              System.Drawing.Brushes.White, new System.Drawing.Point(25, 
                  75));

            setImage(e.Graphics);

            e.Graphics.Dispose();
            base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            this.tooltip = new System.Windows.Forms.ToolTip();

            this.updatelabel = new System.Windows.Forms.Label();
            this.updatelabel.Location = new System.Drawing.Point(50, 165);
            this.updatelabel.Size = new System.Drawing.Size(100, 15);
            this.updatelabel.Text = "Saving Updates";
            this.updatelabel.BackColor = System.Drawing.Color.FromArgb(1, 31, 70);
            this.updatelabel.ForeColor = System.Drawing.Color.White;
            
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.progressbar.Location = new System.Drawing.Point(50, 195);
            this.progressbar.Size = new System.Drawing.Size(499, 18);
            this.progressbar.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progressbar.Step = 10;
            this.progressbar.Value = 50;

            this.finishbutton = new System.Windows.Forms.Button();
            this.finishbutton.Location = new System.Drawing.Point(319, 369);
            this.finishbutton.Size = new System.Drawing.Size(100, 22);
            this.finishbutton.Enabled = true;
            this.finishbutton.Text = "Finish";
            this.finishbutton.UseVisualStyleBackColor = true;
            this.finishbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishbutton.BackColor = System.Drawing.Color.FromArgb(1, 31, 70);
            this.finishbutton.ForeColor = System.Drawing.Color.White;


            this.cancelbutton = new System.Windows.Forms.Button();
            this.cancelbutton.Location = new System.Drawing.Point(429, 369);
            this.cancelbutton.Size = new System.Drawing.Size(100, 22);
            this.cancelbutton.Enabled = true;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbutton.BackColor = System.Drawing.Color.FromArgb(1, 31, 70);
            this.cancelbutton.ForeColor = System.Drawing.Color.White;
  


            this.cancelbutton.Click +=new System.EventHandler(this.cancelbutton_Click);

            this.click1 = new System.Windows.Forms.Label();
            this.click1.Location = new System.Drawing.Point(559, 5);
            this.click1.Size = new System.Drawing.Size(29, 29);
            this.click1.Text = "x";
            this.click1.Font = new System.Drawing.Font("Arial", 10.0f);
            this.click1.BackColor = System.Drawing.Color.Transparent;
            this.click1.ForeColor = System.Drawing.Color.White;
            this.click1.Click += new System.EventHandler(this.click1_click);
            this.click1.MouseEnter += new System.EventHandler(this.mEnter);
            this.click1.MouseLeave += new System.EventHandler(this.mLeave);


            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(599, 466);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Text = "Netfix AntiVirus - Update";
            this.ShowIcon = true;
            this.Icon = new System.Drawing.Icon(System.Drawing.Icon.FromHandle((
                global::netfixupd.Resource.Netfix as System.Drawing.Bitmap).GetHicon()), new System.Drawing.Size(32, 32));
           

            this.tooltip.SetToolTip(this.cancelbutton, this.cancelbutton.Text);
            this.tooltip.SetToolTip(this.finishbutton, this.finishbutton.Text);

            this.Controls.Add(this.updatelabel);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.finishbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.click1);
        }

        #endregion
    }
}
