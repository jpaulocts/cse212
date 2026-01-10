public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start

        // 1# Creating an array to store multiples
        double[] multiples = new double[length];

        //2# Iterating through length

        for (int i = 0; i < length; i++)
        {
            //3# adding multiples to the array
            multiples[i] = number * (i + 1);
        }

        //4# returning the array
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        //1# We create two lists : one for last part and another to the first part
        List<int> last = new List<int>(amount);
        List<int> first = new List<int>(data.Count - amount);

        //2# We slice the list based on given amount
        last = data.GetRange(data.Count - amount, amount);
        first = data.GetRange(0, data.Count - amount);
        //3# We erase the original list
        data.Clear();
        //4# We add the list rotated
        data.AddRange(last);
        data.AddRange(first);
    }
}
