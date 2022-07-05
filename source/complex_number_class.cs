///  Mech 540-A  :  Complex_number_class with feature any size and feature element wise
///
///  Name        :  Ajay Nalla
///  Student ID  :  49640014
///  Source file :  complex_number_class.cs
///  Purpose     :  To create a complex number class. 
///                 Contains complex_number_class namespace.
///  Description :  Contains classes 
///                 1)complex_number: this contains methods for complex number creation,
///                   Methods for overloading operators +,*,- and string overriding for addition,
///                   multiplication,substraction,devision and printng of complex number; 
///                 2)complex_matrix: This contains methods for creating complex matrix, 
///                   operator overloading * for complex number matrix multiplication,method for 
///                   element-wise multiplication, operator overloading of /,method for printing output.
///

/// ************************* USINGS *************************
using System;
namespace complex_number_class
{
    /// ************************* CLASSES *************************
    /// Class       : complex_number
    /// Description : Contains methods for operator overloading and string overriding.
    class complex_number
    {
        ///******************************* GLOBAL VARIABLES *********************************/
        /// Variables are accesible with in the class.
        double real;
        double imaginary;
        /// ************************* METHOD *************************
        /// Method    : complex_number
        /// Arguments : Real value of a complex number(double), imaginary value of a complex number(double)
        /// Returns   : Nothing
        /// This is a constructor method, it creates a complex number type object.
        public complex_number(double real, double imaginary)
        {
            //The real and imaginary values of complex number are read and stored
            this.real = real;
            this.imaginary = imaginary;
        }
        //Property to get the real value of complex number
        public double real_value
        {
            get { return real; }
        }
        //Property to set the real value of complex number
        public double realvalue_set
        {
            get { return real; }
            set { real = value; }
        }
        //Property to get the imaginary value of complex number
        public double imaginary_value
        {
            get { return imaginary; }
        }
        //Property to set the imaginary value of complex number
        public double imgvalue_set
        {
            get { return imaginary; }
            set { imaginary = value; }
        }
        /// ************************* METHOD *************************
        /// Method    : ~complex_number
        /// Arguments : None
        /// Returns   : Nothing
        /// This is a destructor method, it destroys a complex number type object.
        ~complex_number()
        {
            bool isDebug = false;
            System.Diagnostics.Debug.Assert(isDebug = true);
            if (isDebug = true)
            {
                Console.WriteLine(" we are in debug mode" +
                    "\n Destructor class is called and Class object is destroyed");
            }
        }
        /// ************************* METHOD *************************
        /// Method    : * Operator overloading
        /// Arguments : Two complex number types.
        /// Returns   : A complex number which is product of the input complex number types.
        public static complex_number operator *(complex_number first_complex_number,
                                                complex_number second_complex_number)
        {
            return new complex_number(((first_complex_number.real * second_complex_number.real) -
                            (first_complex_number.imaginary * second_complex_number.imaginary)),
                                 ((first_complex_number.real * second_complex_number.imaginary) +
                                (first_complex_number.imaginary * second_complex_number.real)));
        }
        /// ************************* METHOD *************************
        /// Method    : / Operator overloading
        /// Arguments : Two complex number types.
        /// Returns   : A complex number which is devision of the input complex number types.
        public static complex_number operator /(complex_number f_c_n,complex_number s_c_n)
        {
            double den = (s_c_n.real * s_c_n.real) + (s_c_n.imaginary * s_c_n.imaginary);
            double num1 = (f_c_n.real * s_c_n.real) + (f_c_n.imaginary * s_c_n.imaginary);
            double num2 = (s_c_n.real * f_c_n.imaginary) - (f_c_n.real * s_c_n.imaginary);
           return new complex_number((num1/den),(num2/den));
        }
        /// ************************* METHOD *************************
        /// Method    : + Operator overloading
        /// Arguments : Two complex number types.
        /// Returns   : A complex number which is sum of the input complex number types.
        public static complex_number operator +(complex_number first_complex_number,
                                                complex_number second_complex_number)
        {
            return new complex_number(first_complex_number.real + second_complex_number.real,
                             first_complex_number.imaginary + second_complex_number.imaginary);
        }
        /// ************************* METHOD *************************
        /// Method    : - Operator overloading
        /// Arguments : Two complex number types.
        /// Returns   : A complex number which is difference of the input complex number types.
        public static complex_number operator -(complex_number first_complex_number,
                                                complex_number second_complex_number)
        {
            return new complex_number(first_complex_number.real - second_complex_number.real,
                             first_complex_number.imaginary - second_complex_number.imaginary);
        }
        //Readonly property named absolute_value; Returns the absolute value of the complex number.
        public double absolute_value()
        {
            double value = System.Math.Sqrt((real_value * real_value) + (imaginary_value * imaginary_value));
            return value;
        }
        //Readonly property named phase; Returns the phase of the complex number in radians.
        public double phase()
        {
            double value = System.Math.Atan2(imaginary_value, real_value);
            return value;
        }
        /// ************************* METHOD *************************
        /// Method    : String override
        /// Arguments : None
        /// Returns   : A string in the format of a complex number.
        public override string ToString()
        {
            if ((real >= 0 && imaginary == 0) || (real <= 0 && imaginary == 0))
            {
                return String.Format("{0}", real);
            }
            else if ((real == 0 && imaginary > 0) || (real == 0 && imaginary < 0))
            {
                return String.Format("{0}i", imaginary);
            }
            else if (real != 0 && imaginary < 0)
            {
                return String.Format("{0}{1}i", real, imaginary);
            }
            else
            {
                return String.Format("{0}+{1}i", real, imaginary);
            }
        }
    }
    /// ************************* CLASSES *************************
    /// Class       : complex_matrix
    /// Description : Contains methods for *operator overloading.
    class complex_matrix
    {
        int row_of_matrix, column_of_matrix;
        complex_number[,] matrix;
        /// ************************* METHOD *************************
        /// Method    : complex_matrix
        /// Arguments : Row size of complex matrix(int), column size of complex matrix(int)
        /// Returns   : Nothing
        /// This is a constructor method, it creates a complex matrix type object.
        public complex_matrix(int _row_of_matrix, int _column_of_matrix)
        {
            matrix = new complex_number[_row_of_matrix, _column_of_matrix];
            row_of_matrix = _row_of_matrix;
            column_of_matrix = _column_of_matrix;
        }
        public complex_number this[int matrix_row, int matrix_column]
        {
            set { matrix[matrix_row, matrix_column] = value; }
            get { return matrix[matrix_row, matrix_column]; }
        }
        /// ************************* METHOD *************************
        /// Method    : * Operator overloading
        /// Arguments : Two complex matrix types.
        /// Returns   : A new complex matrix which is product of two input complex matrices.
        public static complex_matrix operator *(complex_matrix first_complex_matrix,
                                                complex_matrix second_complex_matrix)
        {
            complex_matrix prod_of_complex_matrices =
                new complex_matrix(first_complex_matrix.row_of_matrix,
                                second_complex_matrix.column_of_matrix);
            //Condition to check the dimensions of matrix for matrix multiplication.
            if (first_complex_matrix.column_of_matrix == second_complex_matrix.row_of_matrix)
            {
                for (int i = 0; i < first_complex_matrix.row_of_matrix; ++i)
                    for (int j = 0; j < second_complex_matrix.column_of_matrix; ++j)
                    {
                        prod_of_complex_matrices[i, j] = new complex_number(0, 0);
                        for (int k = 0; k < first_complex_matrix.column_of_matrix; k++)
                        {
                            prod_of_complex_matrices[i, j] = prod_of_complex_matrices[i, j]
                            + first_complex_matrix.matrix[i, k] * second_complex_matrix.matrix[k, j];
                        }
                    }
                return (prod_of_complex_matrices);
            }
            else
            {
                Console.WriteLine("The matrices cannot be multiplied as they dont " +
                    "meet the dimension requirement");
                return new complex_matrix(0, 0);
            }
        }
        /// ************************* METHOD *************************
        /// Method    : vector_ele_mul
        /// Arguments : Two complex matrix types.
        /// Returns   : A new complex matrix which is vector product of two input complex matrices.
        public static complex_matrix vector_ele_mul(complex_matrix first_complex_matrix,
                                                    complex_matrix second_complex_matrix)
        {
            complex_matrix vector_ele_prod =
                new complex_matrix(first_complex_matrix.row_of_matrix,
                                second_complex_matrix.column_of_matrix);
            if (first_complex_matrix.row_of_matrix == second_complex_matrix.row_of_matrix
                && first_complex_matrix.column_of_matrix == second_complex_matrix.column_of_matrix)
            {
                for (int i = 0; i < first_complex_matrix.row_of_matrix; i++)
                {
                    for (int j = 0; j < second_complex_matrix.column_of_matrix; j++)
                    {
                        vector_ele_prod[i, j] = first_complex_matrix[i, j] * second_complex_matrix[i, j];
                    }
                }
                return (vector_ele_prod);
            }
            else
            {
                Console.WriteLine("Vector multiplication is not possible as the dimensions are not equal");
                return new complex_matrix(0, 0);
            }
        }
        /// ************************* METHOD *************************
        /// Method    : + operator overloading
        /// Arguments : Two complex matrix types.
        /// Returns   : A new complex matrix which is sum of two input complex matrices.
        public static complex_matrix operator +(complex_matrix first_complex_matrix,
                                                    complex_matrix second_complex_matrix)
        {
            complex_matrix sum_com_mat =
                new complex_matrix(first_complex_matrix.row_of_matrix,
                                second_complex_matrix.column_of_matrix);
            if (first_complex_matrix.row_of_matrix == second_complex_matrix.row_of_matrix
                && first_complex_matrix.column_of_matrix == second_complex_matrix.column_of_matrix)
            {
                for (int i = 0; i < first_complex_matrix.row_of_matrix; i++)
                {
                    for (int j = 0; j < second_complex_matrix.column_of_matrix; j++)
                    {
                        sum_com_mat[i, j] = first_complex_matrix[i, j] + second_complex_matrix[i, j];
                    }
                }
                return (sum_com_mat);
            }
            else
            {
                Console.WriteLine("complex matrix addition is not possible as the dimensions are not equal");
                return new complex_matrix(0, 0);
            }
        }
        /// ************************* METHOD *************************
        /// Method    : / operator overloading
        /// Arguments : Two complex matrix types.
        /// Returns   : A new complex matrix which is element wise division of two input complex matrices.
        public static complex_matrix operator /(complex_matrix first_matrix,complex_matrix second_matrix)
        {
            complex_matrix div_ele_wise =
                new complex_matrix(first_matrix.row_of_matrix,second_matrix.column_of_matrix);
            if (first_matrix.row_of_matrix == second_matrix.row_of_matrix
                && first_matrix.column_of_matrix == second_matrix.column_of_matrix)
            {
                for (int i = 0; i < first_matrix.row_of_matrix; i++)
                {
                    for (int j = 0; j < second_matrix.column_of_matrix; j++)
                    {
                        div_ele_wise[i, j] = first_matrix[i, j] / second_matrix[i, j];
                    }
                }
                return (div_ele_wise);
            }
            else
            {
                Console.WriteLine("Elementwise devision is not possible as the dimensions are not equal");
                return new complex_matrix(0, 0);
            }
        }
        /// ************************* METHOD *************************
        /// Method    : printing
        /// Arguments : One complex_matrix
        /// Returns   : A new complex matrix which is result of mathematical operation b/w two complex matrices.
        public void printing(complex_matrix pri)
        {
            int row = pri.row_of_matrix;
            int col = pri.column_of_matrix;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("  " + pri[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
    class solution
    {
        public static void Main()
        {
          
        }
    }
}


