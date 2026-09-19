namespace BT_Tuan2Buoi2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dtpNgaySinh = new DateTimePicker();
            button1 = new Button();
            radNam = new RadioButton();
            radNu = new RadioButton();
            chkTheThao = new CheckBox();
            chkPhimAnh = new CheckBox();
            chkDuLich = new CheckBox();
            txtHoTen = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 57);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 120);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 57);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Thông tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 128);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "Họ tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 191);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 5;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 133);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 6;
            label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 187);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 7;
            label7.Text = "Sở thích";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(684, 187);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(809, 187);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(558, 187);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(570, 128);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(736, 291);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 12;
            button1.Text = "Xuất thông tin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(216, 189);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 13;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(324, 187);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 14;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // chkTheThao
            // 
            chkTheThao.AutoSize = true;
            chkTheThao.Location = new Point(558, 191);
            chkTheThao.Name = "chkTheThao";
            chkTheThao.Size = new Size(89, 24);
            chkTheThao.TabIndex = 15;
            chkTheThao.Text = "Thể thao";
            chkTheThao.UseVisualStyleBackColor = true;
            // 
            // chkPhimAnh
            // 
            chkPhimAnh.AutoSize = true;
            chkPhimAnh.Location = new Point(684, 191);
            chkPhimAnh.Name = "chkPhimAnh";
            chkPhimAnh.Size = new Size(92, 24);
            chkPhimAnh.TabIndex = 16;
            chkPhimAnh.Text = "Phim ảnh";
            chkPhimAnh.UseVisualStyleBackColor = true;
            // 
            // chkDuLich
            // 
            chkDuLich.AutoSize = true;
            chkDuLich.Location = new Point(814, 191);
            chkDuLich.Name = "chkDuLich";
            chkDuLich.Size = new Size(77, 24);
            chkDuLich.TabIndex = 17;
            chkDuLich.Text = "Du lịch";
            chkDuLich.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(207, 125);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(176, 27);
            txtHoTen.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 525);
            Controls.Add(txtHoTen);
            Controls.Add(chkDuLich);
            Controls.Add(chkPhimAnh);
            Controls.Add(chkTheThao);
            Controls.Add(radNu);
            Controls.Add(radNam);
            Controls.Add(button1);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpNgaySinh;
        private Button button1;
        private RadioButton radNam;
        private RadioButton radNu;
        private CheckBox chkTheThao;
        private CheckBox chkPhimAnh;
        private CheckBox chkDuLich;
        private TextBox txtHoTen;
    }
}
