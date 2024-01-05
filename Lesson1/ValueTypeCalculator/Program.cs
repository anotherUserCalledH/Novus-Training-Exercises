namespace ValueTypeCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int largestSize = 0;
            string largestDataType = null;

            if(sizeof(int) > largestSize)
            {
                largestSize = sizeof(int);
                largestDataType = "int";
            }
            if(sizeof(long) > largestSize)
            {
                largestSize = sizeof(long);
                largestDataType = "long";
            }
            if(sizeof(float) > largestSize)
            {
                largestSize = sizeof(float);
                largestDataType = "float";
            }
            if(sizeof(double) > largestSize)
            {
                largestSize = sizeof(double);
                largestDataType = "double";
            }
            if (sizeof(decimal) > largestSize)
            {
                largestSize = sizeof(decimal);
                largestDataType = "decimal";
            }
            if (sizeof(bool) > largestSize)
            {  
                largestSize = sizeof(bool);
                largestDataType = "bool";
            }
            if(sizeof(char) > largestSize)
            { 
                largestSize = sizeof(char);
                largestDataType = "char";
            }
            if(sizeof(byte) > largestSize)
            { 
                largestSize = sizeof(byte);
                largestDataType = "byte";
            }

            Console.WriteLine($"The largest data type is: {largestDataType}");
        }
    }
}
