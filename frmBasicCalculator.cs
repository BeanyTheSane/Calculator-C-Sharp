using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_C_Sharp
{
    public partial class frmBasic : Form
    {

        double? runningTotal = null;
        string currentSelection = string.Empty;
        double? numberTwo = null;
        char functionSign = ' ';
        bool totalFlag = false;

        public frmBasic()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}0");
                lblDisplay.Text = currentSelection;
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}1");
                lblDisplay.Text = currentSelection;
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}2");
                lblDisplay.Text = currentSelection;
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}3");
                lblDisplay.Text = currentSelection;
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}4");
                lblDisplay.Text = currentSelection;
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}5");
                lblDisplay.Text = currentSelection;
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}6");
                lblDisplay.Text = currentSelection;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}7");
                lblDisplay.Text = currentSelection;
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}8");
                lblDisplay.Text = currentSelection;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}9");
                lblDisplay.Text = currentSelection;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            runningTotal = null;
            currentSelection = string.Empty;
            numberTwo = null;
            lblDisplay.Text = "";
            functionSign = ' ';
            totalFlag = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            while (true)//see first if statement below
            {
                if (currentSelection == string.Empty)//this button does nothing until the user selects a number
                {
                    functionSign = '+';
                    break;//closes the outer loop
                }
                
                numberTwo = double.Parse(currentSelection);//converts user input into a variable double
                currentSelection = string.Empty;//empties the user input variable

                if (runningTotal == null)
                {
                    runningTotal = numberTwo;
                }
                else if (functionSign != ' ')
                {
                    //runningTotal = (runningTotal + numberTwo);//adds the current selection to the total
                    runningTotal = BasicFunction(runningTotal, numberTwo, functionSign);                    
                }

                functionSign = '+';
                lblDisplay.Text = runningTotal.ToString();//displays the current total

                //resets variables
                numberTwo = null;

                //breaks out of loop
                break;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            while (true)//see first if statement below
            {
                if (currentSelection == string.Empty)//this button does nothing until the user selects a number
                {
                    functionSign = '-';
                    break;//closes the outer loop
                }

                numberTwo = double.Parse(currentSelection);//converts user input into a variable double
                currentSelection = string.Empty;//empties the user input variable

                if (runningTotal == null)
                {
                    runningTotal = numberTwo;
                }
                else if (functionSign != ' ')
                {
                    runningTotal = BasicFunction(runningTotal, numberTwo, functionSign);//calls a function to perform the arithmetic
                }

                functionSign = '-';
                lblDisplay.Text = runningTotal.ToString();//displays the current total

                //resets variables
                numberTwo = null;

                //breaks out of loop
                break;
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            while (true)//see first if statement below
            {
                if (currentSelection == string.Empty)//this button does nothing until the user selects a number
                {
                    functionSign = '*';
                    break;//closes the outer loop
                }

                numberTwo = double.Parse(currentSelection);//converts user input into a variable double
                currentSelection = string.Empty;//empties the user input variable

                if (runningTotal == null)
                {
                    runningTotal = numberTwo;
                }
                else if (functionSign != ' ')
                {
                    //runningTotal = (runningTotal + numberTwo);//adds the current selection to the total
                    runningTotal = BasicFunction(runningTotal, numberTwo, functionSign);
                }

                functionSign = '*';
                lblDisplay.Text = runningTotal.ToString();//displays the current total

                //resets variables
                numberTwo = null;

                //breaks out of loop
                break;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            while (true)//see first if statement below
            {
                if (currentSelection == string.Empty)//this button does nothing until the user selects a number
                {
                    functionSign = '/';
                    break;//closes the outer loop
                }

                numberTwo = double.Parse(currentSelection);//converts user input into a variable double
                currentSelection = string.Empty;//empties the user input variable

                if (runningTotal == null)
                {
                    runningTotal = numberTwo;
                }
                else if (functionSign != ' ')
                {
                    //runningTotal = (runningTotal + numberTwo);//adds the current selection to the total
                    runningTotal = BasicFunction(runningTotal, numberTwo, functionSign);
                }

                functionSign = '/';
                lblDisplay.Text = runningTotal.ToString();//displays the current total

                //resets variables
                numberTwo = null;

                //breaks out of loop
                break;
            }
        }
        

        private void btnEquals_Click(object sender, EventArgs e)
        {
            while (true)//see first if statement below
            {
                if (currentSelection == string.Empty || functionSign == ' ')//this button does nothing until the user selects a number
                {
                    break;//closes the outer loop
                }

                numberTwo = double.Parse(currentSelection);//converts user input into a variable double
                
                runningTotal = BasicFunction(runningTotal, numberTwo, functionSign);//calls a function to perform the arithmetic

                currentSelection = runningTotal.ToString();
                totalFlag = true;
                lblDisplay.Text = runningTotal.ToString();//displays the current total

                //resets variables
                numberTwo = null;
                functionSign = ' ';
                //breaks out of loop
                break;
            }
        }

        public double? BasicFunction(double? numOne, double? numTwo, char functionSign)
        {
            double? theAnswer = 0;

            switch (functionSign)
            {
                case '+':
                    theAnswer = numOne + numTwo;
                    break;
                case '-':
                    theAnswer = numOne - numTwo;
                    break;
                case '*':
                    theAnswer = numOne * numTwo;
                    break;
                case '/':
                    theAnswer = numOne / numTwo;
                    break;
                default:
                    break;
            }

            return theAnswer;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            if (currentSelection.Length == 0)
            {
                currentSelection = ($"0.");
                lblDisplay.Text = currentSelection;
            }
            else if (currentSelection.ToLower().Contains('.'))
            {

            }
            else if (currentSelection.Length < 17)
            {
                currentSelection = ($"{currentSelection}.");
                lblDisplay.Text = currentSelection;
            }
        }
    }
}
