using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;

namespace adminHelperADGP
{
    public partial class Form1 : Form
    {
        private ScriptManager scriptManager;
        public Form1()
        {
            InitializeComponent();
            scriptManager = new ScriptManager(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string organization = tbOrg.Text;
            string city = tbCity.Text;
            string ous = tbOrgUnits.Text;

            //проверка заполненности текстовых полей
            if (!string.IsNullOrEmpty(tbOrg.Text) && !string.IsNullOrEmpty(tbCity.Text) && !string.IsNullOrEmpty(tbOrgUnits.Text))
            {
                scriptManager.createADOrganizationalUnits(organization, city, ous);
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Заполните все поля!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scriptManager.performInitialSetup();
        }

        private void cbRdp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRdp.Checked)
            {
                scriptManager.configureRDP(0);
                cbRdp.Text = "RDP ON";
            }
            else
            {
                scriptManager.configureRDP(1);
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
                    scriptManager.configureNetInterface(ipAddress, defaultGateway, mask);
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
                scriptManager.configureDHCP("Enable");
                cbDHCP.Text = "DHCP ON";
                tbIP.Enabled = false; // Заблокировать TextBox для IP
                tbMask.Enabled = false; // Заблокировать TextBox для маски подсети
                tbGateway.Enabled = false; // Заблокировать TextBox для шлюза
                button3.Enabled = false; // Заблокировать кнопку
            }
            else
            {
                scriptManager.configureDHCP("Disable");
                cbDHCP.Text = "DHCP OFF";
                tbIP.Enabled = true; // Разблокировать TextBox для IP
                tbMask.Enabled = true; // Разблокировать TextBox для маски подсети
                tbGateway.Enabled = true; // Разблокировать TextBox для шлюза
                button3.Enabled = true; // Разблокировать кнопку
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

        /*public string testRDP(int option)
        {
            string result;
            if (option == 1)
            {
                cbRdp.Checked = true;
                scriptManager.configureRDP(0);
                cbRdp.Text = "RDP ON";
            }
            else
            {
                cbRdp.Checked = false;
                scriptManager.configureRDP(1);
                cbRdp.Text = "RDP OFF";
            }

            result = cbRdp.Text;
            return result;
        }*/
    }
}