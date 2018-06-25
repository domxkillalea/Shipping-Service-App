using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcel_Project
{
    public partial class Form1 : Form
    {

       private Parcel parcel;

        public Form1()
        {
            InitializeComponent();
        }
        private void lblOutput_Click(object sender, EventArgs e)
        {
            //Do nothing if the user clicks the output box
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int tempSize;
            string tempText;
            bool overWeight;
            int weight;
            int height;
            int length;
            int breadth;

            //Initilise the AppController Class reference
            parcel = new Parcel();


            //error check to make sure inputs are numeric
            if (checkInputs() == true)
            {
                //if they are standard, set references to the Parcel object's properties
                parcel.assignValues();
                weight = parcel.weight;
                height = parcel.height;
                length = parcel.length;
                breadth = parcel.breadth;

                //assign the boolean values to the local weight variable
                overWeight = parcel.weightCheck(parcel.weight);

                //check the weight to determine if oversized
                if (overWeight == false) {

                    //report back to the output label if the package is too heavy
                    lblOutput.Text = "The package you are trying to send is too heavy for this service!";

                }

                else {
                   //run the calculation if the package is the correct weight
                   
                        
                        // Talk to the controlling functions
                        tempSize = parcel.getType(parcel.height, length, breadth);

                    //assign the string based on the inputs
                    tempText = parcel.checkType(tempSize);


                    //Output to the label
                    lblOutput.Text = tempText;
                    
                }
            }
            else
            {
                lblOutput.Text = "Please check that all fields are entered correctly!";
            }
        }


       bool checkInputs()
        {
            //check if the user has input numbers
            bool inTF = false;

            //create an array full of the input numbers
            string[] inArray = new string[4];
            inArray[0] = txtWidth.Text;
            inArray[1] = txtBreadth.Text;
            inArray[2] = txtHeight.Text;
            inArray[3] = txtWeight.Text;

            for (int i = 0; i < 4; i++)
            {
                inTF = parcel.intCheck(inArray[i], i);
                if(inTF == false)
                {
                    break;
                }
            }


            return inTF;
            
        }

       
        
        }



    
}
