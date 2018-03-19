using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // This can be done on the toolbar but this is how you would do it at runtime ...
            firstValueLabel.Font.Name = "arial";
            firstValueLabel.Font.Size = 14;
            secondValueLabel.Font.Name = "arial";
            secondValueLabel.Font.Size = 14;
            resultLabel.Font.Name = "arial";
            resultLabel.Font.Size = 14;
        }
         
        protected void addButton_Click(object sender, EventArgs e)
        {
            int firstValueInt = int.Parse(firstValueTextBox.Text);
            int secondValueInt = int.Parse(secondValueTextBox.Text);
            resultLabel.Text = (firstValueInt + secondValueInt).ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            int firstValueInt = int.Parse(firstValueTextBox.Text);
            int secondValueInt = int.Parse(secondValueTextBox.Text);
            resultLabel.Text = (firstValueInt - secondValueInt).ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int firstValueInt = int.Parse(firstValueTextBox.Text);
            int secondValueInt = int.Parse(secondValueTextBox.Text);

            // Raising an error for overflow when doing multiplication
            long resultMultiplicationLong;
  
            checked
            {
                resultMultiplicationLong = firstValueInt * secondValueInt;
            }

            resultLabel.Text = resultMultiplicationLong.ToString();

        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            // Implicit Upcasting to a double so that precision isn't lost ...
            double firstValueDouble = int.Parse(firstValueTextBox.Text);
            double secondValueDouble = int.Parse(secondValueTextBox.Text);
            double divisionResultDouble = firstValueDouble/secondValueDouble;

            resultLabel.Text = divisionResultDouble.ToString();

        }

    }
}