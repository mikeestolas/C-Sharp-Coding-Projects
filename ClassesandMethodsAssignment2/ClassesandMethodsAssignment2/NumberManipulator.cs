﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethodsAssignment2
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
           
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
    }
}
