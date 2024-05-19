using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAN_UART_DMA
{

    public partial class Form1 : Form
    {
        double ADC_voltage = 0;
        double Temperature = 28;
        /*double Temperature1 = 28;
        double Temperature2 = 28;
        double Temperature3 = 28;
        double Temperature4 = 28;
        double Temperature_tb = 0;*/

        byte[] du_lieu_gui = new byte[12];
        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        int flag4 = 0;
        int flag5 = 0;
        int flag6 = 0;

        int tong = 0;
        public Form1()
        {
            InitializeComponent();
            string[] Baudrate = { "1200", "2400", "4800", "9600", "115200" };
            cboBaudrate.Items.AddRange(Baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ovalShape1.BackColor = Color.Red;
            ovalShape2.BackColor = Color.Red;
            ovalShape3.BackColor = Color.Red;
            ovalShape4.BackColor = Color.Red;
            ovalShape5.BackColor = Color.Red;
            ovalShape6.BackColor = Color.Red;
            //Khoi tao ket noi Serial
            cboComPort.DataSource = SerialPort.GetPortNames();
            cboBaudrate.Text = "115200";

            //Khởi tạo biểu đồ
            GraphPane myPanne = zedGraphControl1.GraphPane;
            myPanne.Title.Text = "Giá trị nhiệt độ";
            myPanne.YAxis.Title.Text = "Giá trị";
            myPanne.XAxis.Title.Text = "Thời gian";

            RollingPointPairList list = new RollingPointPairList(500000);

            LineItem line = myPanne.AddCurve("nhiệt độ", list, Color.Red, SymbolType.Diamond);

            myPanne.XAxis.Scale.Min = 0;     //giá trị trục X nhỏ nhất
            myPanne.XAxis.Scale.Max = 100;   //giá trị trục X lớn nhất
            myPanne.XAxis.Scale.MinorStep = 1;
            myPanne.XAxis.Scale.MajorStep = 2;

            myPanne.YAxis.Scale.Min = 0;     //giá trị trục X nhỏ nhất
            myPanne.YAxis.Scale.Max = 50;   //giá trị trục X lớn nhất
            myPanne.YAxis.Scale.MinorStep = 1;
            myPanne.YAxis.Scale.MajorStep = 2;

            zedGraphControl1.AxisChange();

        }

        public void draw(double line)
        {
            LineItem duongline = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            if (duongline == null)
            {
                return;
            }
            IPointListEdit list = duongline.Points as IPointListEdit;
            if (list == null)
            {
                return;
            }

            list.Add(tong, line);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            tong += 2;
        }

        private void butConnect_Click(object sender, EventArgs e)
        {

            if (!serCOM.IsOpen)
            {
                butConnect.Text = "Disconnect";
                serCOM.PortName = cboComPort.Text;
                serCOM.BaudRate = Convert.ToInt32(cboBaudrate.Text);
                serCOM.Open();
            }
            else
            {
                butConnect.Text = "Connect";
                serCOM.Close();
            }
        }

        private void butExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serCOM != null && serCOM.IsOpen)
                {
                    char firstByte = (char)serCOM.ReadByte();
                    if (firstByte == '@')
                    {
                        char dex = (char)serCOM.ReadByte();
                        int dataLength = dex - '0' + 1;
                        char[] dataBuffer = new char[dataLength];
                        int bytesRead = 0;
                        DateTime startTime = DateTime.Now;
                        while (bytesRead < dataLength)
                        {
                            if (serCOM.BytesToRead > 0)
                            {
                                char currentByte = (char)serCOM.ReadByte();
                                dataBuffer[bytesRead] = currentByte;
                                bytesRead++;
                            }
                            else
                            {
                                TimeSpan elapsed = DateTime.Now - startTime;
                                if (elapsed.TotalMilliseconds > 500)
                                    Console.WriteLine("Timeout: No data received within 1 second.");
                                break;
                            }

                        }

                        int indx = dataLength - 1;
                        if (bytesRead == dataLength)
                        {
                            char lastByte = dataBuffer[indx];
                            if (lastByte == '#')
                            {
                                char slave_id = dataBuffer[0];

                                //Process data at this line//
                                //SLAVE_1 blink_led 
                                if (slave_id == 65)
                                {
                                    //Nhận dữ liệu sáng đèn trên C#.`   
                                   

                                    string hexNumber = new string(dataBuffer); ; // Số hexa cần chuyển đổi

                                    string newvalue = hexNumber.Substring(3, 4);    // Lấy 7 phần tử từ vị trí 0
                             
                                    int decimalNumber = Convert.ToInt32(hexNumber, 16); // Chuyển hex thành số nguyên

                                   
                                    // Chuyển đổi số nguyên thành biểu diễn nhị phân
                                    string binaryString = Convert.ToString(decimalNumber, 2).PadLeft(7, '0'); // 7 là số lượng bit, có thể thay đổi tùy ý

                                    char[] binaryCharArray = binaryString.ToCharArray(); // Chuyển chuỗi thành mảng ký tự

                            

                                    ovalShape1.BackStyle = (binaryCharArray[1] == 0) ? Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent : Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                                    ovalShape2.BackStyle = (binaryCharArray[2] == 0) ? Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent : Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                                    ovalShape3.BackStyle = (binaryCharArray[3] == 0) ? Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent : Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                                    ovalShape4.BackStyle = (binaryCharArray[4] == 0) ? Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent : Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                                    ovalShape5.BackStyle = (binaryCharArray[5] == 0) ? Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent : Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                                    ovalShape6.BackStyle = (binaryCharArray[6] == 0) ? Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent : Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
                                }


                                //Process data at this line//
                                //SLAVE_2 Read ADC
                                if (slave_id == 66)
                                {

                                    string allData = new string(dataBuffer);


                                    string newvalue = allData.Substring(1, 4);    // Lấy 4 phần tử từ vị trí 1

                                    int decimalValue = Convert.ToInt16(newvalue, 16);   // đổi từ hexa sang decimal
                                    
                                    ADC_voltage = Convert.ToDouble(decimalValue) * 4.5 / 4095;

                                    Temperature = ADC_voltage*10;

                                    
                                    txtADC.Text = Convert.ToString(Math.Round(ADC_voltage, 5));
                                    txtADC.AppendText(" V");

                                  
                                   /*Temperature4 = Temperature3;
                                    Temperature3 = Temperature2;
                                    Temperature2 = Temperature1;
                                    Temperature1 = Temperature;
                                    Temperature_tb = 0.2 * Temperature4 + Temperature3 * 0.3 + Temperature2 * 0.3 + Temperature1* 0.1 +Temperature *0.1 ;*/
                                    txtTEMP.Text = Convert.ToString(Math.Round(Temperature, 3));

                                    txtTEMP.AppendText(" °C");
                                    Invoke(new MethodInvoker(() => draw(Convert.ToDouble(Temperature))));

                                    /*while (true)
                                    {
                                        // Kiểm tra nhiệt độ và gửi tín hiệu qua UART nếu cần
                                        if (Temperature > 30)
                                        {
                                                du_lieu_gui[7] = 1;        
                                                SendSignal(du_lieu_gui);

                                        }
                                    if (Temperature < 27)
                                        {
                                                du_lieu_gui[7] = 0;        
                                                SendSignal(du_lieu_gui);

                                        }

                                        // Chờ một khoảng thời gian trước khi kiểm tra lại nhiệt độ
                                        System.Threading.Thread.Sleep(1000); // Chờ 1 giây
                                    }*/
                                }

                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
       
        


        private void button1_Click(object sender, EventArgs e)
        {
            if(flag1 == 0)
            { 
                du_lieu_gui[1] = 1;
                flag1 = 1;
                ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            }
            else
            {
                du_lieu_gui[1] = 0;
                flag1 = 0;
                ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;

            }
            SendSignal(du_lieu_gui);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag2 == 0)
            {
                du_lieu_gui[2] = 1;
                flag2 = 1;
                ovalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;

            }
            else
            {
                du_lieu_gui[2] = 0;
                flag2 = 0;
                ovalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;

            }
            SendSignal(du_lieu_gui);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag3 == 0)
            {
                du_lieu_gui[3] = 1;
                flag3 = 1;
                ovalShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;

            }
            else
            {
                du_lieu_gui[3] = 0;
                flag3 = 0;
                ovalShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;

            }
            SendSignal(du_lieu_gui);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag4 == 0)
            {
                du_lieu_gui[4] = 1;
                flag4 = 1;
                ovalShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;

            }
            else
            {
                du_lieu_gui[4] = 0;
                flag4 = 0;
                ovalShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;

            }
            SendSignal(du_lieu_gui);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (flag5 == 0)
            {
                du_lieu_gui[5] = 1;
                flag5 = 1;
                ovalShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;

            }
            else
            {
                du_lieu_gui[5] = 0;
                flag5 = 0;
                ovalShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;

            }

            SendSignal(du_lieu_gui);
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag6 == 0)
            {
                du_lieu_gui[6] = 1;
                flag6 = 1;
                ovalShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;

            }
            else
            {
                du_lieu_gui[6] = 0;
                flag6 = 0;
                ovalShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent;

            }
            SendSignal(du_lieu_gui);
        }

        private void SendSignal(byte[] du_lieu_gui)
        {
            if (serCOM.IsOpen)
            {
                // Gửi mảng dữ liệu qua cổng serial
                serCOM.Write(du_lieu_gui, 0, du_lieu_gui.Length);
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

