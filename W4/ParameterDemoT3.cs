public class ParameterDemo
{
    // increases number using ref
    public void Increase(ref int number)
    {
        number += 10;
    }

    // assigns fullname using out
    public void GetFullName(out string fullname)
    {
        fullname = "Saphal Koirala";
    }

    // sum of multiple values
    public int SumAll(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }
}
