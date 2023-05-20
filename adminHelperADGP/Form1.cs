using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;

namespace adminHelperADGP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string organization = tbOrg.Text;
            string city = tbCity.Text;
            string ous = tbOrgUnits.Text;

            //проверка заполненности текстовых полей
            if (!string.IsNullOrEmpty(tbOrg.Text) && !string.IsNullOrEmpty(tbCity.Text) && !string.IsNullOrEmpty(tbOrgUnits.Text))
            {
                CreateADOrganizationalUnits(organization, city, ous);
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Заполните все поля!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitialSetup();
        }

        private void cbRdp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRdp.Checked)
            {
                RDPSettings(0);
                cbRdp.Text = "RDP ON";
            }
            else
            {
                RDPSettings(1);
                cbRdp.Text = "RDP OFF";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ipAddress = tbIP.Text;
            string mask = tbMask.Text;
            string defaultGateway = tbGateway.Text;

            //регулярное выражение для проверки корректности ввода IP
            Regex regIP = new Regex(@"^(?!(?:\d{1,3}\.){3}\d{1,3}\.)\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");

            if (!string.IsNullOrEmpty(tbIP.Text) && !string.IsNullOrEmpty(tbMask.Text) && !string.IsNullOrEmpty(tbGateway.Text))
            {
                if (regIP.IsMatch(ipAddress) && regIP.IsMatch(defaultGateway))
                {
                    NetInterfaceSetup(ipAddress, defaultGateway, mask);
                }
                else
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "Неверно введен IP или шлюз";
                }
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Заполните все поля!";
            }
        }


        private void cbDHCP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDHCP.Checked)
            {
                DHCPSettings("Enable");
                cbDHCP.Text = "DHCP ON";
                tbIP.Enabled = false; // Заблокировать TextBox для IP
                tbMask.Enabled = false; // Заблокировать TextBox для маски подсети
                tbGateway.Enabled = false; // Заблокировать TextBox для шлюза
                button3.Enabled = false; // Заблокировать кнопку
            }
            else
            {
                DHCPSettings("Disable");
                cbDHCP.Text = "DHCP OFF";
                tbIP.Enabled = true; // Разблокировать TextBox для IP
                tbMask.Enabled = true; // Разблокировать TextBox для маски подсети
                tbGateway.Enabled = true; // Разблокировать TextBox для шлюза
                button3.Enabled = true; // Разблокировать кнопку
            }
        }

        //функция работы с DHCP
        private void DHCPSettings(string option)
        {
            string scriptFilePath = "";

            if (option == "Enable")
            {
                scriptFilePath = @"C:\Scripts\scriptDHCPOn.ps1"; //путь до скрипта
            }
            else if (option == "Disable")
            {
                scriptFilePath = @"C:\Scripts\scriptDHCPOff.ps1"; //путь до скрипта
            }

            string arguments = $"-ExecutionPolicy Bypass -File \"{scriptFilePath}\""; //аргументы и команда выполнения скрипта с полными правами

            executePowershellScript(arguments);
        }

        //функция работы с RDP
        private void RDPSettings(int option)
        {
            string scriptFilePath = @"C:\Scripts\scriptRDP.ps1"; //путь до скрипта
            string arguments = $"-ExecutionPolicy Bypass -File \"{scriptFilePath}\" -OptionNumber {option}"; //аргументы и команда выполнения скрипта с полными правами

            executePowershellScript(arguments);
        }              
        
        //функция настройки сетевого интерфейса
        private void NetInterfaceSetup(string ip, string gateway, string mask)
        {
            string scriptFilePath = @"C:\Scripts\scriptNet.ps1"; //путь до скрипта
            string arguments = $"-ExecutionPolicy Bypass -File \"{scriptFilePath}\" –IP \"{ip}\" -GW \"{gateway}\" -Mask \"{mask}\""; //аргументы и команда выполнения скрипта с полными правами

            executePowershellScript(arguments);
        }

        //функция создания подразделений в AD
        private void CreateADOrganizationalUnits(string organization, string city, string ous)
        {
            string scriptFilePath = @"C:\Scripts\scriptAD.ps1"; //путь до скрипта
            string arguments = $"-ExecutionPolicy Bypass -File \"{scriptFilePath}\" -Organization \"{organization}\" -City \"{city}\" -OUs \"{ous}\""; //аргументы и команда выполнения скрипта с полными правами

            executePowershellScript(arguments);
        }

        //функция первоначальной настройки машины
        private void InitialSetup()
        {
            string scriptFilePath = @"C:\Scripts\scriptSetup.ps1"; //путь до скрипта
            string arguments = $"-ExecutionPolicy Bypass -File \"{scriptFilePath}\""; //аргументы и команда выполнения скрипта с полными правами

            executePowershellScript(arguments);
        }
        
        //функция запуска скриптов powershell
        private void executePowershellScript(String arguments)
        {
            string result;
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "powershell", //имя консоли
                Arguments = arguments, //аргументы команды
                UseShellExecute = false, //запускать процесс не из оболочки
                CreateNoWindow = true, //не открывать powershell
                RedirectStandardOutput = true
            });

            lblResult.Text = "";
            process.WaitForExit(); //ожидание полного выполнения команд
            result = process.StandardOutput.ReadToEnd();

            //проверка результата выполнения
            if (result.Contains("True"))
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "Команда выполнена успешно";
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Команда не была выполнена";
            }
        }

        private void tbIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 46 && number != 8) //ввод только цифр, точек, использование backspace
            {
                e.Handled = true;
            }
        }

        private void tbGateway_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 46 && number != 8) //ввод только цифр, точек, использование backspace
            {
                e.Handled = true;
            }
        }

        private void tbMask_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) //ввод только цифр, точек, использование backspace
            {
                e.Handled = true;
            }
        }
    }
}