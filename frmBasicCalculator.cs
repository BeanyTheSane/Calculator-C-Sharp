//Program Name:        Simple Calculator
//
//Description:         This is a simple calculator app that will perform basic arithmetic, one operation at a time
//
//Date  Beginning:     07/14/2019
//
//Date Edited:         07/15/2019
//
//Date Complete:       07/15/2019
//
//Programmer:          Adam Knitter
//
//Notes:                **it needs to alert the user when there are too many digits in a total to display
//

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

        //initialize some variables
        double? runningTotal = null;//holds the current total being tallied
        string currentSelection = string.Empty;//holds the current number being entered
        double? numberTwo = null;//used in calculations
        char functionSign = ' ';//stores the selected function sign
        bool totalFlag = false;

        public frmBasic()
        {
            InitializeComponent();
        }

        //each number performs the same action for its digit
        private void btnZero_Click(object sender, EventArgs e)
        {
            //checks if there is a total in the display
            if (totalFlag == true)
            {
                //clears a variable for a new number
                currentSelection = string.Empty;
                totalFlag = false;
            }
            //checks if the new digit will fit in the display
            if (currentSelection.Length < 17)
            {
                //adds the selection to the variable
                currentSelection = ($"{currentSelection}0");
                //displays the updated variable to the user
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

        //this button allows the user to clear the memory and start fresh
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
                    //calls a method that will perform the desired function
                    runningTotal = BasicFunction(runningTotal, numberTwo, functionSign);                    
                }

                functionSign = '+';//sets this function as selected
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

        //this method will perform the calculations as needed
        public double? BasicFunction(double? numOne, double? numTwo, char functionSign)
        {
            //initialize the working variable
            double? theAnswer = 0;

            //this switch is designed to check which sign has been selected by the user then perform its calculation
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

        //this button will add decimals to the mix
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //checks if there is a total and clears it
            if (totalFlag == true)
            {
                currentSelection = string.Empty;
                totalFlag = false;
            }
            //checks if there is a number yet and adds a 0 in front
            if (currentSelection.Length == 0)
            {
                currentSelection = ($"0.");
                lblDisplay.Text = currentSelection;
            }
            //does nothing if decimal already present
            else if (currentSelection.ToLower().Contains('.'))
            {

            }
            //add decimal to current number if it will fit
            else if (currentSelection.Length < 16)
            {
                currentSelection = ($"{currentSelection}.");
                lblDisplay.Text = currentSelection;
            }
        }
    }
}
