namespace adminHelperADGP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.lblInfoAD = new System.Windows.Forms.Label();
            this.tbOrg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrgUnits = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.cbRdp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabAD = new System.Windows.Forms.TabPage();
            this.tabNetworking = new System.Windows.Forms.TabPage();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDHCP = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMask = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tabAD.SuspendLayout();
            this.tabNetworking.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(137, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInfoAD
            // 
            this.lblInfoAD.AutoSize = true;
            this.lblInfoAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoAD.Location = new System.Drawing.Point(31, 340);
            this.lblInfoAD.Name = "lblInfoAD";
            this.lblInfoAD.Size = new System.Drawing.Size(0, 25);
            this.lblInfoAD.TabIndex = 1;
            // 
            // tbOrg
            // 
            this.tbOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrg.Location = new System.Drawing.Point(182, 35);
            this.tbOrg.Name = "tbOrg";
            this.tbOrg.Size = new System.Drawing.Size(236, 32);
            this.tbOrg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Организация:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(85, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Город:";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCity.Location = new System.Drawing.Point(182, 99);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(236, 32);
            this.tbCity.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 44);
            this.label5.TabIndex = 9;
            this.label5.Text = "Подразделения:\r\n(через пробел)";
            // 
            // tbOrgUnits
            // 
            this.tbOrgUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrgUnits.Location = new System.Drawing.Point(182, 166);
            this.tbOrgUnits.Name = "tbOrgUnits";
            this.tbOrgUnits.Size = new System.Drawing.Size(236, 32);
            this.tbOrgUnits.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSetup);
            this.tabControl1.Controls.Add(this.tabAD);
            this.tabControl1.Controls.Add(this.tabNetworking);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 425);
            this.tabControl1.TabIndex = 10;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.cbRdp);
            this.tabSetup.Controls.Add(this.label1);
            this.tabSetup.Controls.Add(this.button2);
            this.tabSetup.Location = new System.Drawing.Point(4, 34);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(491, 387);
            this.tabSetup.TabIndex = 1;
            this.tabSetup.Text = "Первоначальная настройка ";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // cbRdp
            // 
            this.cbRdp.AutoSize = true;
            this.cbRdp.Location = new System.Drawing.Point(334, 293);
            this.cbRdp.Name = "cbRdp";
            this.cbRdp.Size = new System.Drawing.Size(123, 29);
            this.cbRdp.TabIndex = 5;
            this.cbRdp.Text = "RDP OFF";
            this.cbRdp.UseVisualStyleBackColor = true;
            this.cbRdp.CheckedChanged += new System.EventHandler(this.cbRdp_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 225);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(34, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Настроить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabAD
            // 
            this.tabAD.Controls.Add(this.label2);
            this.tabAD.Controls.Add(this.lblInfoAD);
            this.tabAD.Controls.Add(this.label5);
            this.tabAD.Controls.Add(this.button1);
            this.tabAD.Controls.Add(this.tbOrg);
            this.tabAD.Controls.Add(this.tbOrgUnits);
            this.tabAD.Controls.Add(this.label4);
            this.tabAD.Controls.Add(this.tbCity);
            this.tabAD.Location = new System.Drawing.Point(4, 34);
            this.tabAD.Name = "tabAD";
            this.tabAD.Padding = new System.Windows.Forms.Padding(3);
            this.tabAD.Size = new System.Drawing.Size(491, 387);
            this.tabAD.TabIndex = 0;
            this.tabAD.Text = "Настройка AD";
            this.tabAD.UseVisualStyleBackColor = true;
            // 
            // tabNetworking
            // 
            this.tabNetworking.Controls.Add(this.tbGateway);
            this.tabNetworking.Controls.Add(this.tbIP);
            this.tabNetworking.Controls.Add(this.label9);
            this.tabNetworking.Controls.Add(this.cbDHCP);
            this.tabNetworking.Controls.Add(this.label8);
            this.tabNetworking.Controls.Add(this.label7);
            this.tabNetworking.Controls.Add(this.tbMask);
            this.tabNetworking.Controls.Add(this.label6);
            this.tabNetworking.Controls.Add(this.button3);
            this.tabNetworking.Controls.Add(this.label3);
            this.tabNetworking.Location = new System.Drawing.Point(4, 34);
            this.tabNetworking.Name = "tabNetworking";
            this.tabNetworking.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetworking.Size = new System.Drawing.Size(491, 387);
            this.tabNetworking.TabIndex = 2;
            this.tabNetworking.Text = "Сетевая настройка";
            this.tabNetworking.UseVisualStyleBackColor = true;
            // 
            // tbGateway
            // 
            this.tbGateway.Location = new System.Drawing.Point(27, 156);
            this.tbGateway.MaxLength = 15;
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Size = new System.Drawing.Size(223, 30);
            this.tbGateway.TabIndex = 11;
            this.tbGateway.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGateway_KeyPress);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(27, 71);
            this.tbIP.MaxLength = 15;
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(223, 30);
            this.tbIP.TabIndex = 10;
            this.tbIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIP_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(389, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Включение и отключение DHCP";
            // 
            // cbDHCP
            // 
            this.cbDHCP.AutoSize = true;
            this.cbDHCP.Location = new System.Drawing.Point(37, 289);
            this.cbDHCP.Name = "cbDHCP";
            this.cbDHCP.Size = new System.Drawing.Size(139, 29);
            this.cbDHCP.TabIndex = 8;
            this.cbDHCP.Text = "DHCP OFF";
            this.cbDHCP.UseVisualStyleBackColor = true;
            this.cbDHCP.CheckedChanged += new System.EventHandler(this.cbDHCP_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(485, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Изменение настроек сетевого адаптера";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Шлюз";
            // 
            // tbMask
            // 
            this.tbMask.Location = new System.Drawing.Point(285, 71);
            this.tbMask.MaxLength = 2;
            this.tbMask.Name = "tbMask";
            this.tbMask.Size = new System.Drawing.Size(174, 30);
            this.tbMask.TabIndex = 4;
            this.tbMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMask_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Маска ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Настроить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP Адрес";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(12, 429);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 486);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AdminHelper";
            this.tabControl1.ResumeLayout(false);
            this.tabSetup.ResumeLayout(false);
            this.tabSetup.PerformLayout();
            this.tabAD.ResumeLayout(false);
            this.tabAD.PerformLayout();
            this.tabNetworking.ResumeLayout(false);
            this.tabNetworking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInfoAD;
        private System.Windows.Forms.TextBox tbOrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOrgUnits;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAD;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.TabPage tabNetworking;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRdp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbDHCP;
        private System.Windows.Forms.TextBox tbMask;
        private System.Windows.Forms.TextBox tbGateway;
        private System.Windows.Forms.TextBox tbIP;
    }
}

