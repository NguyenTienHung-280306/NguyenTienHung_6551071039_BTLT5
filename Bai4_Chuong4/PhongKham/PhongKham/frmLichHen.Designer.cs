namespace PhongKham
{
    partial class frmLichHen
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
            dateTimePicker1 = new DateTimePicker();
            txtTenBN = new TextBox();
            button1 = new Button();
            listBoxLichHen = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(168, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // txtTenBN
            // 
            txtTenBN.Location = new Point(247, 194);
            txtTenBN.Name = "txtTenBN";
            txtTenBN.Size = new Size(125, 27);
            txtTenBN.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(168, 271);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Đặt lịch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxLichHen
            // 
            listBoxLichHen.FormattingEnabled = true;
            listBoxLichHen.Location = new Point(477, 108);
            listBoxLichHen.Name = "listBoxLichHen";
            listBoxLichHen.Size = new Size(248, 204);
            listBoxLichHen.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(325, 30);
            label1.Name = "label1";
            label1.Size = new Size(175, 43);
            label1.TabIndex = 4;
            label1.Text = "Lịch hẹn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 197);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Họ tên:";
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxLichHen);
            Controls.Add(button1);
            Controls.Add(txtTenBN);
            Controls.Add(dateTimePicker1);
            Name = "frmLichHen";
            Text = "frmLichHen";
            Load += frmLichHen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox txtTenBN;
        private Button button1;
        private ListBox listBoxLichHen;
        private Label label1;
        private Label label2;
    }
}