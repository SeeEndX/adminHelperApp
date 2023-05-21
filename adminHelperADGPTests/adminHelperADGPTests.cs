using adminHelperADGP;
using Moq;
using System.Drawing;

namespace adminHelperADGPTests
{
    public class adminHelperADGPModuleTests
    {
        [Fact]
        public void rdpOnTest() //модульное
        {
            //Arrange
            string expected = "RDP ON";

            //Act
            ScriptManager sm = new ScriptManager(new Form1());
            string actual = sm.testRDP(1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testFormWithRdpOff() //модульное
        {
            // Arrange
            var form = new Form1();
            var scriptManager = new ScriptManager(form);
            string expected = " оманда не была выполнена";
            Color expected1 = Color.Red;

            // Act
            scriptManager.configureRDP(0);
            string actual = form.lblResult.Text;
            Color actual1 = form.lblResult.ForeColor;
            
            // Assert
            Assert.Equal(actual, expected);
            Assert.Equal(expected1, actual1);
        }
    }

    public class adminHelperADGPFunctionalTests
    {
        private ScriptManager scriptManager;
        private Form1 form;
        private string dhcpScriptOn = @"C:\Scripts\scriptDHCPOn.ps1";
        private string dhcpScriptOff = @"C:\Scripts\scriptDHCPOff.ps1";

        [Fact]
        public void TestConfigureDHCP_Enable()
        {
            // Arrange
            form = new Form1();
            scriptManager = new ScriptManager(form);
            string expected = $"-ExecutionPolicy Bypass -File \"{dhcpScriptOn}\"";

            // Act
            scriptManager.configureDHCP("Enable");

            // Assert
            Assert.Equal(expected, scriptManager.Arguments);
        }

        [Fact]
        public void TestConfigureDHCP_Disable()
        {
            // Arrange
            form = new Form1();
            scriptManager = new ScriptManager(form);
            string expected = $"-ExecutionPolicy Bypass -File \"{dhcpScriptOff}\"";

            // Act
            scriptManager.configureDHCP("Disable");

            // Assert
            Assert.Equal(expected, scriptManager.Arguments);
        }
    }
}