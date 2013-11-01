namespace ArduinoDesktopUnit
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
            this.meetGegevensBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mainMotorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HoogteLabel = new System.Windows.Forms.Label();
            this.DraaiLabel = new System.Windows.Forms.Label();
            this.LengteLabel = new System.Windows.Forms.Label();
            this.HandDraaingLabel = new System.Windows.Forms.Label();
            this.OpenDichtLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.meetGegevensBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // meetGegevensBox
            // 
            this.meetGegevensBox.Controls.Add(this.OpenDichtLabel);
            this.meetGegevensBox.Controls.Add(this.HandDraaingLabel);
            this.meetGegevensBox.Controls.Add(this.LengteLabel);
            this.meetGegevensBox.Controls.Add(this.DraaiLabel);
            this.meetGegevensBox.Controls.Add(this.HoogteLabel);
            this.meetGegevensBox.Controls.Add(this.label6);
            this.meetGegevensBox.Controls.Add(this.label5);
            this.meetGegevensBox.Controls.Add(this.label4);
            this.meetGegevensBox.Controls.Add(this.label3);
            this.meetGegevensBox.Controls.Add(this.label2);
            this.meetGegevensBox.Controls.Add(this.label1);
            this.meetGegevensBox.Controls.Add(this.mainMotorLabel);
            this.meetGegevensBox.Location = new System.Drawing.Point(5, 8);
            this.meetGegevensBox.Name = "meetGegevensBox";
            this.meetGegevensBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.meetGegevensBox.Size = new System.Drawing.Size(273, 174);
            this.meetGegevensBox.TabIndex = 0;
            this.meetGegevensBox.TabStop = false;
            this.meetGegevensBox.Text = "Meetgegevens";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(284, 8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(300, 417);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // mainMotorLabel
            // 
            this.mainMotorLabel.AutoSize = true;
            this.mainMotorLabel.Location = new System.Drawing.Point(7, 16);
            this.mainMotorLabel.Name = "mainMotorLabel";
            this.mainMotorLabel.Size = new System.Drawing.Size(44, 13);
            this.mainMotorLabel.TabIndex = 0;
            this.mainMotorLabel.Text = "Motor #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoogte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Draaing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lengte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Draaing Hand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Open/Dicht";
            // 
            // HoogteLabel
            // 
            this.HoogteLabel.AutoSize = true;
            this.HoogteLabel.Location = new System.Drawing.Point(228, 40);
            this.HoogteLabel.Name = "HoogteLabel";
            this.HoogteLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HoogteLabel.Size = new System.Drawing.Size(42, 13);
            this.HoogteLabel.TabIndex = 7;
            this.HoogteLabel.Text = "Hoogte";
            // 
            // DraaiLabel
            // 
            this.DraaiLabel.AutoSize = true;
            this.DraaiLabel.Location = new System.Drawing.Point(235, 66);
            this.DraaiLabel.Name = "DraaiLabel";
            this.DraaiLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DraaiLabel.Size = new System.Drawing.Size(32, 13);
            this.DraaiLabel.TabIndex = 8;
            this.DraaiLabel.Text = "Draai";
            // 
            // LengteLabel
            // 
            this.LengteLabel.AutoSize = true;
            this.LengteLabel.Location = new System.Drawing.Point(227, 94);
            this.LengteLabel.Name = "LengteLabel";
            this.LengteLabel.Size = new System.Drawing.Size(40, 13);
            this.LengteLabel.TabIndex = 9;
            this.LengteLabel.Text = "Lengte";
            // 
            // HandDraaingLabel
            // 
            this.HandDraaingLabel.AutoSize = true;
            this.HandDraaingLabel.Location = new System.Drawing.Point(197, 122);
            this.HandDraaingLabel.Name = "HandDraaingLabel";
            this.HandDraaingLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HandDraaingLabel.Size = new System.Drawing.Size(73, 13);
            this.HandDraaingLabel.TabIndex = 10;
            this.HandDraaingLabel.Text = "Hand Draaing";
            // 
            // OpenDichtLabel
            // 
            this.OpenDichtLabel.AutoSize = true;
            this.OpenDichtLabel.Location = new System.Drawing.Point(208, 151);
            this.OpenDichtLabel.Name = "OpenDichtLabel";
            this.OpenDichtLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpenDichtLabel.Size = new System.Drawing.Size(59, 13);
            this.OpenDichtLabel.TabIndex = 11;
            this.OpenDichtLabel.Text = "Open-dicht";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vooruit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 69);
            this.button2.TabIndex = 3;
            this.button2.Text = "Omhoog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 69);
            this.button3.TabIndex = 4;
            this.button3.Text = "Hand Links";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(5, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 70);
            this.button4.TabIndex = 5;
            this.button4.Text = "Links Draaien";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(97, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 70);
            this.button5.TabIndex = 6;
            this.button5.Text = "Hand Openen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(190, 265);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 70);
            this.button6.TabIndex = 7;
            this.button6.Text = "Rechts Draaien";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(5, 342);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 73);
            this.button7.TabIndex = 8;
            this.button7.Text = "Achteruit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(97, 342);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 73);
            this.button8.TabIndex = 9;
            this.button8.Text = "Omlaag";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(190, 342);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 73);
            this.button9.TabIndex = 10;
            this.button9.Text = "Hand Rechts";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 427);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.meetGegevensBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.meetGegevensBox.ResumeLayout(false);
            this.meetGegevensBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox meetGegevensBox;
        private System.Windows.Forms.Label OpenDichtLabel;
        private System.Windows.Forms.Label HandDraaingLabel;
        private System.Windows.Forms.Label LengteLabel;
        private System.Windows.Forms.Label DraaiLabel;
        private System.Windows.Forms.Label HoogteLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainMotorLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.IO.Ports.SerialPort serialPort1;

    }
}

