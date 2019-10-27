namespace Supervisorio_v2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btConectar = new System.Windows.Forms.Button();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxAltitude = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxErro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(235, 38);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(101, 33);
            this.btConectar.TabIndex = 1;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.BtConectar_Click);
            // 
            // timerCOM
            // 
            this.timerCOM.Enabled = true;
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.TimerCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ParityReplace = ((byte)(0));
            this.serialPort1.ReceivedBytesThreshold = 10;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(12, 113);
            this.textBoxLatitude.Multiline = true;
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLatitude.Size = new System.Drawing.Size(157, 235);
            this.textBoxLatitude.TabIndex = 2;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(212, 113);
            this.textBoxLongitude.Multiline = true;
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLongitude.Size = new System.Drawing.Size(158, 235);
            this.textBoxLongitude.TabIndex = 3;
            // 
            // textBoxAltitude
            // 
            this.textBoxAltitude.Location = new System.Drawing.Point(401, 113);
            this.textBoxAltitude.Multiline = true;
            this.textBoxAltitude.Name = "textBoxAltitude";
            this.textBoxAltitude.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAltitude.Size = new System.Drawing.Size(161, 235);
            this.textBoxAltitude.TabIndex = 4;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(605, 113);
            this.textBoxAltura.Multiline = true;
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAltura.Size = new System.Drawing.Size(161, 235);
            this.textBoxAltura.TabIndex = 5;
            // 
            // textBoxErro
            // 
            this.textBoxErro.Location = new System.Drawing.Point(295, 360);
            this.textBoxErro.Multiline = true;
            this.textBoxErro.Name = "textBoxErro";
            this.textBoxErro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxErro.Size = new System.Drawing.Size(161, 47);
            this.textBoxErro.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Altitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Altura";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(555, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxErro);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxAltitude);
            this.Controls.Add(this.textBoxLongitude);
            this.Controls.Add(this.textBoxLatitude);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Supervisório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.TextBox textBoxAltitude;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxErro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

