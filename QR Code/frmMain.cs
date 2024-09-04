using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;
using System.Reflection.Emit;

namespace QR_Code
{
    public partial class frmMain : Form
    {

        string targetVid = "VID_05F9";
        string targetPid = "PID_4204";
        bool deviceStatus = false;
        public frmMain()
        {
            InitializeComponent();
            // Lấy thông tin về các cổng COM
            //Console.WriteLine("COM Ports Information:\n");

            // Câu truy vấn WMI để lấy thông tin cổng COM
            //string query = @"SELECT * FROM Win32_SerialPort";
            //ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            //ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"Select * From Win32_SerialPort");

            //// Thực hiện truy vấn và hiển thị thông tin
            //foreach (ManagementObject port in searcher.Get())
            //{
            //    string deviceId = port["DeviceID"]?.ToString() ?? "N/A";
            //    string description = port["Description"]?.ToString() ?? "N/A";

            //    Console.WriteLine($"DeviceID: {deviceId}");
            //    Console.WriteLine($"Description: {description}\n");
            //}

            //Console.ReadLine();

            //using (var findDevice = new ManagementObjectSearcher(@"Select * From Win32_PnPEntity Where Caption like '%(COM%'"))
            //{
            //    string[] portNames = SerialPort.GetPortNames();
            //    //var ports = searcher.Get().Cas
            //    collection = findDevice.Get();
            //}
            //foreach (var device in collection)
            //{
            //    Console.WriteLine(a.ToString());
            //    Console.WriteLine(device.GetPropertyValue("DeviceID").ToString());
            //    Console.WriteLine(device.GetPropertyValue("Description").ToString());
            //    Console.WriteLine("\n\r");
            //}
        }
        int a = 0;
        private void btnScan_Click(object sender, EventArgs e)
        {
            //ManagementObjectCollection collection;
            //using (var findDevice = new ManagementObjectSearcher(@"Select * From Win32_PnPEntity Where Caption like '%(COM%'"))
            //{
            //    string[] portNames = SerialPort.GetPortNames();
            //    //var ports = searcher.Get().Cas
            //    collection = findDevice.Get();
            //}    
            //foreach (var device in collection)
            //{
            //    txtLog.AppendText(a.ToString());
            //    a++;
            //    txtLog.AppendText(device.GetPropertyValue("DeviceID").ToString());
            //    txtLog.AppendText(device.GetPropertyValue("Description").ToString());
            //    txtLog.AppendText("\n\r");
            //    txtLog.AppendText("\n\r");
            //    txtLog.AppendText("\n\r");
            //    txtLog.AppendText("\n\r");
            //    Console.WriteLine(a.ToString());
            //    Console.WriteLine(device.GetPropertyValue("DeviceID").ToString());
            //    Console.WriteLine(device.GetPropertyValue("Description").ToString());
            //    Console.WriteLine("\n\r");
            //}
            try
            {
                portCom.WriteLine("X");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi gửi lệnh tới thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmrRead_Tick(object sender, EventArgs e)
        {
            try
            {
                string data = null;
                if (portCom.IsOpen)
                {

                    if (portCom.BytesToRead > 0)
                    {
                        data = portCom.ReadExisting();
                        if (data.Substring(0, 2) == "ID")
                        {
                            decodeDataMRZ(data);
                        }
                        else if (data.Substring(0, 1) == "$")
                        {
                        }
                        else
                        {
                            decodeDataQR(data);
                        }
                        txtLog.Text = data;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrRead.Enabled = true;
            tmrStatus.Enabled = true;
        }
        private void decodeDataMRZ(string data)
        {
            try
            {
                string[] mrzLines = data.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                string mrzLine1 = mrzLines[0];
                string mrzLine2 = mrzLines[1];
                string mrzLine3 = mrzLines[2];

                // Extracting information from MRZ Line 1
                string documentType = mrzLine1.Substring(0, 2);
                string issuingCountry = mrzLine1.Substring(2, 3);
                //string numberCMND = mrzLine1.Substring(5, 9).Trim('<');
                string numberCMND = "";
                string numberCCCD = mrzLine1.Substring(15, 12).Trim('<');

                // Extracting information from MRZ Line 2
                string dateOfBirth = mrzLine2.Substring(0, 6);
                string gender = mrzLine2.Substring(7, 1);
                string expiryDate = mrzLine2.Substring(8, 6);
                string nationality = mrzLine2.Substring(14, 3);

                // Extracting name from MRZ Line 3
                string[] nameParts = mrzLine3.Split(new[] { "<<" }, StringSplitOptions.None);
                string lastName = nameParts[0].Replace('<', ' ').Trim();
                string firstName = nameParts[1].Replace('<', ' ').Trim();

                // Convert date format
                string formattedDOB = FormatDate(dateOfBirth, false);
                string formattedExpiryDate = FormatDate(expiryDate, true);

                //show display
                if (issuingCountry == "VNM") issuingCountry = "Việt Nam";
                txtQueQuan.Text = issuingCountry;
                lblQueQuan.Text = "Quốc tịch:";
                txtSoCanCuoc.Text = numberCCCD;
                txtSoCMND.Text = numberCMND;
                txtNgaysinh.Text = formattedDOB;
                txtGioiTinh.Text = (gender == "F" ? "Nữ" : "Nam");
                txtNgayPhatHanh.Text = formattedExpiryDate;
                lblNgayPhatHanh.Text = "Ngày hết hạn:";
                lblNgayPhatHanh.Location = new Point(309, 64);
                txtHoVaTen.Text = lastName + " " + firstName;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static string FormatDate(string date, bool year)
        {
            try
            {
                if (DateTime.TryParseExact(date, "yyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                {
                    // Kiểm tra và điều chỉnh năm nếu là ngày hết hạn
                    if (year && parsedDate.Year < 2000)
                    {
                        parsedDate = parsedDate.AddYears(100); // Thêm 100 năm nếu năm thuộc thế kỷ 1900
                    }
                    return parsedDate.ToString("dd/MM/yyyy");
                }
                return "Invalid date";
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Invalid date";
            }
        }

        private void decodeDataQR(string data)
        {
            try
            {
                // Phân tách dữ liệu dựa trên dấu |
                string[] fields = data.Split('|');

                // Gán các trường thông tin vào biến tương ứng
                string numberCCCD = fields[0];       // Số CCCD
                string numberCMND = fields[1];       // Số CMND
                string fullName = fields[2];             // Họ và tên
                string dateOfBirth = fields[3];          // Ngày sinh
                dateOfBirth = DateTime.ParseExact(dateOfBirth, "ddMMyyyy", null)
                    .ToString("dd/MM/yyyy");
                string gender = fields[4];               // Giới tính
                string address = fields[5];              // Địa chỉ
                string issueDate = fields[6].Replace('r', ' ').Trim(); // Ngày cấp
                issueDate = DateTime.ParseExact(issueDate, "ddMMyyyy", null)
                    .ToString("dd/MM/yyyy");

                //show display
                lblQueQuan.Text = "Quê quán:";
                txtQueQuan.Text = address;
                txtSoCanCuoc.Text = numberCCCD;
                txtSoCMND.Text = numberCMND;
                txtNgaysinh.Text = dateOfBirth;
                txtGioiTinh.Text = gender;
                txtNgayPhatHanh.Text = issueDate;
                lblNgayPhatHanh.Text = "Ngày phát hành:";
                //lblNgayPhatHanh.AutoSize = false;
                lblNgayPhatHanh.Location = new Point(291, 64);
                txtHoVaTen.Text = fullName;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tmrStatus_Tick(object sender, EventArgs e)
        {

            try
            {
                if (!deviceStatus)
                {
                    btnScan.Enabled = false;
                    btnAuto.Enabled = false;
                    btnManual.Enabled = false;

                    await Task.Run(() =>
                    {
                        try
                        {
                            // Câu truy vấn WMI để lấy thông tin cổng COM
                            string query = @"SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%(COM%'";
                            using (var searcher = new ManagementObjectSearcher(query))
                            {
                                foreach (ManagementObject device in searcher.Get())
                                {
                                    string deviceId = device["DeviceID"]?.ToString();
                                    string caption = device["Caption"]?.ToString();

                                    // Kiểm tra nếu thiết bị chứa VID và PID mục tiêu
                                    if (deviceId != null && deviceId.Contains(targetVid) && deviceId.Contains(targetPid))
                                    {
                                        this.Invoke((MethodInvoker)delegate
                                        {
                                            Console.WriteLine("Found Device: " + caption);
                                            Console.WriteLine("DeviceID: " + deviceId);

                                            // Lấy tên cổng COM
                                            string portName = ExtractComPort(caption);
                                            if (!string.IsNullOrEmpty(portName))
                                            {
                                                // Kết nối với cổng COM
                                                if(portCom.IsOpen) portCom.Close();
                                                portCom.BaudRate = 9600;
                                                portCom.PortName = portName;
                                                portCom.Encoding = Encoding.UTF8;
                                                try
                                                {
                                                    portCom.Open();
                                                }
                                                catch (Exception)
                                                {
                                                }
                                                barDeviceStatus.Text = "Device Connected";
                                                barDeviceStatus.ForeColor = Color.LimeGreen;
                                                deviceStatus = true;
                                            }
                                        });
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    });
                }
                else
                {
                    btnScan.Enabled = true;
                    btnAuto.Enabled = true;
                    btnManual.Enabled = true;
                    if (portCom.IsOpen)
                    {
                        bool temp = false;
                        string[] ports = SerialPort.GetPortNames();

                        //Console.WriteLine(ports.Length.ToString());
                        if (ports.Length > 0)
                        {
                            foreach (string port in ports)
                            {
                               if(port == portCom.PortName) temp = true;
                            }
                            if (!temp) deviceStatus = false;
                            barDeviceStatus.Text = "Device Connected";
                            barDeviceStatus.ForeColor = Color.LimeGreen;
                        }
                        else portCom.Close();
                    }
                    else
                    {
                        barDeviceStatus.Text = "Device Disconnected";
                        barDeviceStatus.ForeColor = Color.Red;
                        deviceStatus = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Hàm để tách tên cổng COM từ mô tả thiết bị
        private static string ExtractComPort(string caption)
        {
            int startIndex = caption.LastIndexOf("(COM");
            if (startIndex != -1)
            {
                int endIndex = caption.IndexOf(")", startIndex);
                if (endIndex != -1)
                {
                    return caption.Substring(startIndex + 1, endIndex - startIndex - 1);
                }
            }
            return null;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            try
            {
                string autoCommand = "24532C43534E524D30352C41732C7230310D0A";

                // Chuyển đổi chuỗi hex thành mảng byte
                byte[] bytesToSend = Enumerable.Range(0, autoCommand.Length / 2)
                                               .Select(x => Convert.ToByte(autoCommand.Substring(x * 2, 2), 16))
                                               .ToArray();

                // Giả sử bạn đã mở cổng serial port (portCom) trước đó
                if (portCom.IsOpen)
                {
                    Console.WriteLine("$S,CSNRM05,As,r01");
                    portCom.Write(bytesToSend, 0, bytesToSend.Length);
                }
                else
                {
                    Console.WriteLine("Port is not open.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            try
            {
                string manualCommand = "24532C43534E524D30302C41732C7230310D0A";

                // Chuyển đổi chuỗi hex thành mảng byte
                byte[] bytesToSend = Enumerable.Range(0, manualCommand.Length / 2)
                                               .Select(x => Convert.ToByte(manualCommand.Substring(x * 2, 2), 16))
                                               .ToArray();

                // Giả sử bạn đã mở cổng serial port (portCom) trước đó
                if (portCom.IsOpen)
                {
                    Console.WriteLine("$S,CSNRM00,As,r01");
                    portCom.Write(bytesToSend, 0, bytesToSend.Length);
                }
                else
                {
                    Console.WriteLine("Port is not open.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
