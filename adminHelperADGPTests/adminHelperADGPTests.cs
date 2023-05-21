using adminHelperADGP;
using Moq;
using System.Drawing;

namespace adminHelperADGPTests
{
    public class adminHelperADGPTests : IDisposable
    {
        public void Dispose()
        {
            //close test
        }

        [Fact]
        public void rdpOnTest()
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
        public void testFormWithRdpOff()
        {
            // Arrange
            var form = new Form1();
            var scriptManager = new ScriptManager(form);
            string expected = "Команда не была выполнена";
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
}