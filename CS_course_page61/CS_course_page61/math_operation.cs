namespace CS_course_page61
{
    class Math_operation
    {
        public static int Operation(int num1, int num2)
        {
            int result = (num1 * num2) + (num1 % 3) - (num2 * num2);
            return result;
        }
    }
}
