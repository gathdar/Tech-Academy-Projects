namespace CS_course_page64
{
    // step 1
    class Divide
    {
        public void Half(int num1, out int num2)
        {
            num2 = num1 / 2;

        }

        // step 4 (on closer look, this task specified more than one output parameter)
        public void DivideByThree(int num1, out int result, out string hello)
        {
            result = num1 / 3;
            hello = "Hello";
        }

        // step 5
        public double DivideByThree(double num1)
        {
            double result = num1 / 3;
            return result;
        }
    }
}
