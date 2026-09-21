namespace PhongKham
{
    partial class frmParent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            nghiệpVụToolStripMenuItem = new ToolStripMenuItem();
            thôngTinBệnhNhânToolStripMenuItem = new ToolStripMenuItem();
            đặtLịchHẹnToolStripMenuItem = new ToolStripMenuItem();
            cửaSổToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nghiệpVụToolStripMenuItem, cửaSổToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = cửaSổToolStripMenuItem1;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinBệnhNhânToolStripMenuItem, đặtLịchHẹnToolStripMenuItem });
            nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            nghiệpVụToolStripMenuItem.Size = new Size(91, 24);
            nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // thôngTinBệnhNhânToolStripMenuItem
            // 
            thôngTinBệnhNhânToolStripMenuItem.Name = "thôngTinBệnhNhânToolStripMenuItem";
            thôngTinBệnhNhânToolStripMenuItem.Size = new Size(228, 26);
            thôngTinBệnhNhânToolStripMenuItem.Text = "Thông tin bệnh nhân";
            thôngTinBệnhNhânToolStripMenuItem.Click += thôngTinBệnhNhânToolStripMenuItem_Click;
            // 
            // đặtLịchHẹnToolStripMenuItem
            // 
            đặtLịchHẹnToolStripMenuItem.Name = "đặtLịchHẹnToolStripMenuItem";
            đặtLịchHẹnToolStripMenuItem.Size = new Size(228, 26);
            đặtLịchHẹnToolStripMenuItem.Text = "Lịch hẹn";
            đặtLịchHẹnToolStripMenuItem.Click += cửaSổToolStripMenuItem_Click;
            // 
            // cửaSổToolStripMenuItem1
            // 
            cửaSổToolStripMenuItem1.Name = "cửaSổToolStripMenuItem1";
            cửaSổToolStripMenuItem1.Size = new Size(68, 24);
            cửaSổToolStripMenuItem1.Text = "Cửa sổ";
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmParent";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem thôngTinBệnhNhânToolStripMenuItem;
        private ToolStripMenuItem đặtLịchHẹnToolStripMenuItem;
        private ToolStripMenuItem cửaSổToolStripMenuItem1;
    }
}
