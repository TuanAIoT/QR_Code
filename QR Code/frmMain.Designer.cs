namespace QR_Code
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barlblDeviceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.barDeviceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtNgayPhatHanh = new System.Windows.Forms.TextBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtNgaysinh = new System.Windows.Forms.TextBox();
            this.txtSoCanCuoc = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSoCCCD = new System.Windows.Forms.Label();
            this.tmrRead = new System.Windows.Forms.Timer(this.components);
            this.portCom = new System.IO.Ports.SerialPort(this.components);
            this.tmrStatus = new System.Windows.Forms.Timer(this.components);
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgayPhatHanh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 16);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTest);
            this.panel1.Controls.Add(this.btnScan);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAuto);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 100);
            this.panel1.TabIndex = 38;
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(559, 3);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(132, 59);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(262, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manual";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(89, 3);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(132, 59);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barlblDeviceStatus,
            this.barDeviceStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 65);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 35);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barlblDeviceStatus
            // 
            this.barlblDeviceStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barlblDeviceStatus.Name = "barlblDeviceStatus";
            this.barlblDeviceStatus.Size = new System.Drawing.Size(132, 28);
            this.barlblDeviceStatus.Text = "Device Status:";
            // 
            // barDeviceStatus
            // 
            this.barDeviceStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDeviceStatus.ForeColor = System.Drawing.Color.Red;
            this.barDeviceStatus.Name = "barDeviceStatus";
            this.barDeviceStatus.Size = new System.Drawing.Size(210, 28);
            this.barDeviceStatus.Text = "Device Disconnected";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(909, 100);
            this.txtLog.TabIndex = 37;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(629, 146);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(187, 30);
            this.txtGioiTinh.TabIndex = 53;
            // 
            // txtNgayPhatHanh
            // 
            this.txtNgayPhatHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayPhatHanh.Location = new System.Drawing.Point(629, 94);
            this.txtNgayPhatHanh.Name = "txtNgayPhatHanh";
            this.txtNgayPhatHanh.Size = new System.Drawing.Size(187, 30);
            this.txtNgayPhatHanh.TabIndex = 52;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCMND.Location = new System.Drawing.Point(630, 42);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(187, 30);
            this.txtSoCMND.TabIndex = 51;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoVaTen.Location = new System.Drawing.Point(207, 148);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(187, 30);
            this.txtHoVaTen.TabIndex = 49;
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaysinh.Location = new System.Drawing.Point(207, 96);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(187, 30);
            this.txtNgaysinh.TabIndex = 48;
            // 
            // txtSoCanCuoc
            // 
            this.txtSoCanCuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCanCuoc.Location = new System.Drawing.Point(207, 44);
            this.txtSoCanCuoc.Name = "txtSoCanCuoc";
            this.txtSoCanCuoc.Size = new System.Drawing.Size(187, 30);
            this.txtSoCanCuoc.TabIndex = 47;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(84, 151);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(111, 25);
            this.lblHoTen.TabIndex = 42;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(80, 99);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(115, 25);
            this.lblNgaySinh.TabIndex = 41;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblSoCCCD
            // 
            this.lblSoCCCD.AutoSize = true;
            this.lblSoCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCCCD.Location = new System.Drawing.Point(56, 47);
            this.lblSoCCCD.Name = "lblSoCCCD";
            this.lblSoCCCD.Size = new System.Drawing.Size(139, 25);
            this.lblSoCCCD.TabIndex = 40;
            this.lblSoCCCD.Text = "Số căn cước:";
            // 
            // tmrRead
            // 
            this.tmrRead.Tick += new System.EventHandler(this.tmrRead_Tick);
            // 
            // tmrStatus
            // 
            this.tmrStatus.Tick += new System.EventHandler(this.tmrStatus_Tick);
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueQuan.Location = new System.Drawing.Point(81, 203);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(114, 25);
            this.lblQueQuan.TabIndex = 43;
            this.lblQueQuan.Text = "Quê quán:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(207, 199);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(609, 30);
            this.txtQueQuan.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Giới tính:";
            // 
            // lblNgayPhatHanh
            // 
            this.lblNgayPhatHanh.AutoSize = true;
            this.lblNgayPhatHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayPhatHanh.Location = new System.Drawing.Point(436, 99);
            this.lblNgayPhatHanh.Name = "lblNgayPhatHanh";
            this.lblNgayPhatHanh.Size = new System.Drawing.Size(171, 25);
            this.lblNgayPhatHanh.TabIndex = 58;
            this.lblNgayPhatHanh.Text = "Ngày phát hành:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "Số CMND:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtLog);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(909, 100);
            this.panel4.TabIndex = 61;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblSoCCCD);
            this.panel5.Controls.Add(this.txtQueQuan);
            this.panel5.Controls.Add(this.lblNgaySinh);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblHoTen);
            this.panel5.Controls.Add(this.txtHoVaTen);
            this.panel5.Controls.Add(this.txtGioiTinh);
            this.panel5.Controls.Add(this.txtSoCMND);
            this.panel5.Controls.Add(this.lblQueQuan);
            this.panel5.Controls.Add(this.txtNgaysinh);
            this.panel5.Controls.Add(this.txtNgayPhatHanh);
            this.panel5.Controls.Add(this.lblNgayPhatHanh);
            this.panel5.Controls.Add(this.txtSoCanCuoc);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(909, 269);
            this.panel5.TabIndex = 62;
            // 
            // txtTest
            // 
            this.txtTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest.Location = new System.Drawing.Point(710, 19);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(187, 30);
            this.txtTest.TabIndex = 60;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 485);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "AIoT JSC QR Code";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barlblDeviceStatus;
        private System.Windows.Forms.ToolStripStatusLabel barDeviceStatus;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtNgayPhatHanh;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtNgaysinh;
        private System.Windows.Forms.TextBox txtSoCanCuoc;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSoCCCD;
        private System.Windows.Forms.Timer tmrRead;
        private System.IO.Ports.SerialPort portCom;
        private System.Windows.Forms.Timer tmrStatus;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgayPhatHanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTest;
    }
}

