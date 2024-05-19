namespace CAN_UART_DMA
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.butConnect = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.txtADC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTEMP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape6 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape5 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.cboBaudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboComPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 132);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Location = new System.Drawing.Point(120, 71);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(121, 32);
            this.cboBaudrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate: ";
            // 
            // cboComPort
            // 
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(120, 26);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(121, 32);
            this.cboComPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM: ";
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butExit.Location = new System.Drawing.Point(199, 28);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(131, 42);
            this.butExit.TabIndex = 31;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click_1);
            // 
            // butConnect
            // 
            this.butConnect.BackColor = System.Drawing.Color.PaleGreen;
            this.butConnect.Location = new System.Drawing.Point(40, 28);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(130, 42);
            this.butConnect.TabIndex = 30;
            this.butConnect.Text = "Connect";
            this.butConnect.UseVisualStyleBackColor = false;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // txtADC
            // 
            this.txtADC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtADC.Font = new System.Drawing.Font("Roboto Condensed", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADC.Location = new System.Drawing.Point(144, 43);
            this.txtADC.Name = "txtADC";
            this.txtADC.Size = new System.Drawing.Size(140, 34);
            this.txtADC.TabIndex = 35;
            this.txtADC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 42);
            this.label3.TabIndex = 36;
            this.label3.Text = "CAN_UART_DMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Voltage ADC:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTEMP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtADC);
            this.groupBox2.Font = new System.Drawing.Font("Roboto Condensed", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 140);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "READ_ADC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Temperature:";
            // 
            // txtTEMP
            // 
            this.txtTEMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTEMP.Location = new System.Drawing.Point(144, 85);
            this.txtTEMP.Name = "txtTEMP";
            this.txtTEMP.Size = new System.Drawing.Size(140, 34);
            this.txtTEMP.TabIndex = 38;
            this.txtTEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.shapeContainer1);
            this.groupBox3.Font = new System.Drawing.Font("Roboto Condensed", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1039, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 403);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BLINK_LED";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(28, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 39);
            this.button6.TabIndex = 6;
            this.button6.Text = "LED 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "LED 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "LED 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "LED 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "LED 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "LED 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 30);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape6,
            this.ovalShape5,
            this.ovalShape4,
            this.ovalShape3,
            this.ovalShape2,
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(292, 370);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape6
            // 
            this.ovalShape6.Location = new System.Drawing.Point(180, 260);
            this.ovalShape6.Name = "ovalShape6";
            this.ovalShape6.Size = new System.Drawing.Size(30, 30);
            // 
            // ovalShape5
            // 
            this.ovalShape5.Location = new System.Drawing.Point(180, 210);
            this.ovalShape5.Name = "ovalShape5";
            this.ovalShape5.Size = new System.Drawing.Size(30, 30);
            // 
            // ovalShape4
            // 
            this.ovalShape4.Location = new System.Drawing.Point(180, 160);
            this.ovalShape4.Name = "ovalShape4";
            this.ovalShape4.Size = new System.Drawing.Size(30, 30);
            // 
            // ovalShape3
            // 
            this.ovalShape3.Location = new System.Drawing.Point(180, 110);
            this.ovalShape3.Name = "ovalShape3";
            this.ovalShape3.Size = new System.Drawing.Size(30, 30);
            // 
            // ovalShape2
            // 
            this.ovalShape2.Location = new System.Drawing.Point(180, 60);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.Size = new System.Drawing.Size(30, 30);
            // 
            // ovalShape1
            // 
            this.ovalShape1.Location = new System.Drawing.Point(180, 15);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(30, 30);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(337, 92);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(695, 403);
            this.zedGraphControl1.TabIndex = 40;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 592);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butConnect;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.TextBox txtADC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape6;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape5;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTEMP;
    }
}

