namespace BangVeMini
{
    partial class Form1
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
            pnlCanvas = new Panel();
            lblViTri = new Label();
            lblTrangThai = new Label();
            SuspendLayout();
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = SystemColors.Window;
            pnlCanvas.Location = new Point(35, 36);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(726, 402);
            pnlCanvas.TabIndex = 0;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.ForeColor = Color.IndianRed;
            lblViTri.Location = new Point(35, 9);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(0, 20);
            lblViTri.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Stencil", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.Green;
            lblTrangThai.Location = new Point(641, 8);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(90, 21);
            lblTrangThai.TabIndex = 2;
            lblTrangThai.Text = "Sẵn sàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrangThai);
            Controls.Add(lblViTri);
            Controls.Add(pnlCanvas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCanvas;
        private Label lblViTri;
        private Label lblTrangThai;
    }
}
