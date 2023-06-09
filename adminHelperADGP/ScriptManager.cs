﻿using System;
using System.Diagnostics;
using System.Drawing;

namespace adminHelperADGP
{
    public class ScriptManager
    {
        private Form1 form; // Ссылка на экземпляр формы Form1
        public string Arguments { get; private set; }


        public ScriptManager(Form1 form)
        {
            this.form = form;
        }

        public ScriptManager getSM()
        {
            return this;
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

            form.lblResult.Text = "";
            process.WaitForExit(); //ожидание полного выполнения команд
            result = process.StandardOutput.ReadToEnd();

            //проверка результата выполнения
            if (result.Contains("True"))
            {
                form.lblResult.ForeColor = Color.Green;
                form.lblResult.Text = "Команда выполнена успешно";
            }
            else
            {
                form.lblResult.ForeColor = Color.Red;
                form.lblResult.Text = "Команда не была выполнена";
            }
        }

        //функция работы с DHCP
        public void configureDHCP(string option)
        {
            string scriptFilePath;

            if (option == "Enable")
            {
                scriptFilePath = @"C:\Scripts\scriptDHCPOn.ps1"; //путь до скрипта
            }
            else
            {
                scriptFilePath = @"C:\Scripts\scriptDHCPOff.ps1"; //путь до скрипта
            }

            string arguments = $"-ExecutionPolicy Bypass -File \"{scriptFilePath}\""; //аргументы и команда выполнения скрипта с полными правами
            Arguments = arguments;

            executePowershellScript(arguments);
        }

        //функция работы с RDP
        public void configureRDP(int option)
        {
            string scriptFilePath = @"C:\Scripts\scriptRDP.ps1"; //путь до скрипта
            string arguments = $"-ExecutionPolicy Bypass -File \"{scriptFilePath}\" -OptionNumber {option}"; //аргументы и команда выполнения скрипта с полными правами

            executePowershellScript(arguments);
        }

        //функция настройки сетевого интерфейса
        public void configureNetInterface(string ip, string gateway, string mask)
        {
            string scriptFilePath = @"C:\Scripts\scriptNet.ps1"; //путь до скрипта
            string arguments = $"-ExecutionPolicy Bypass -File \"{scriptFilePath}\" –IP \"{ip}\" -GW \"{gateway}\" -Mask \"{mask}\""; //аргументы и команда выполнения скрипта с полными правами

            executePowershellScript(arguments);
        }

        //функция создания подразделений в AD
        public void createADOrganizationalUnits(string organization, string city, string ous)
        {
            string scriptFilePath = @"C:\Scripts\scriptAD.ps1"; //путь до скрипта
            string arguments = $"-ExecutionPolicy Bypass -File \"{scriptFilePath}\" -Organization \"{organization}\" -City \"{city}\" -OUs \"{ous}\""; //аргументы и команда выполнения скрипта с полными правами

            executePowershellScript(arguments);
        }

        //функция первоначальной настройки машины
        public void performInitialSetup()
        {
            string scriptFilePath = @"C:\Scripts\scriptSetup.ps1"; //путь до скрипта
            string arguments = $"-ExecutionPolicy Bypass -File \"{scriptFilePath}\""; //аргументы и команда выполнения скрипта с полными правами

            executePowershellScript(arguments);
        }

        public string testRDP(int option)
        {
            if (option == 1)
            {
                configureRDP(0);
                form.cbRdp.Text = "RDP ON";
            }
            else
            {
                configureRDP(1);
                form.cbRdp.Text = "RDP OFF";
            }
            return form.cbRdp.Text;
        }
    }
}
