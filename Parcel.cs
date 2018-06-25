using System;


    public class Parcel
    {
    public int weight;
    public int length;
    public int breadth;
    public int height;

    //Array to temporarily store the object's properties before assigning
    int[] propertyArray = new int[4];


    public bool intCheck(string c, int i)
    {
        int y;
        try
        {
            //check whether the value in the textbox is numeric
            Int32.Parse(c);
        }
        catch (Exception x)
        {
            //if not numeric, log in console and return false
            Console.WriteLine("{0}Can only enter numbers!", x);
            return false;
        }

        //call the assign function to set as this object's properties
        y = Int32.Parse(c);
        storeValues(y, i);

        //extra check to ensure the size is greater than 0
        if (Int32.Parse(c) <= 0)
        {
            return false;
        }
        else { 
        return true;
    }
    }
        public bool weightCheck(int w)
        {
            //checks if the package is too heavy
            if (w > 25)
            {
                Console.WriteLine("Package exceeds the weight limit!");
                return false;
            }
            else
            {
                return true;
            }

        }
        public int heightCheck(int dimension)
        {
            //checks the height of the package
            if (dimension <= 150)
            {
                return 1;
            }
            else if (dimension <= 200)
            {
                return 2;
            }
            else if (dimension <= 250)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        public int lengthCheck(int dimension)
        {
            //checks the length of the package
            if (dimension <= 200)
            {
                return 1;
            }
            else if (dimension <= 300)
            {
                return 2;
            }
            else if (dimension <= 400)
            {
                return 3;
            }
            else
            {
                return 4;
            }

        }
        public int breadthCheck(int dimension)
        {
            //checks the depth of the package
            if (dimension <= 300)
            {
                return 1;
            }
            else if (dimension <= 400)
            {
                return 2;
            }
            else if (dimension <= 600)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        //working functions
        private void storeValues(int i, int r)
    {
        //stores each integer as they are checked
        propertyArray[r] = i;

    }
    public void assignValues()
    {
        //assigns the properties of the object
        length = propertyArray[0];
        breadth = propertyArray[1];
        height = propertyArray[2];
        weight = propertyArray[3];
    }
        public int getType(int h, int l, int d)
        {
            //use functions to get category based on largest side
            int hMax = heightCheck(h);
            int lMax = lengthCheck(l);
            int dMax = breadthCheck(d);

            //sort into single category by largest size

            return getSize(hMax, lMax, dMax);

        }
        public int getSize(int dh, int dw, int dd)
        {

            int size;
            /*
 * If they are integers, categorise them and assign a value
 * 1 = small
 * 2 = medium
 * 3 = large
 * 4 = too big
 */

            size = dh;

            //Get the biggest size category
            if (dw > size)
            {
                size = dw;
            }
            if (dd > size)
            {
                size = dd;
            }
            return size;
        }
        public string checkType(int i)
        {
            if (i == 1)
            {
                return "Small: $5.00";
            }
            else if (i == 2)
            {
                return "Medium: $7.50";
            }
            else if (i == 3)
            {
                return "Large: $8.50";
            }
            else
            {
                return "The package is too large for this service!";
            }
        }
    }

