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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan:
        // 1. Create a new array of doubles whose size is 'length'.
        // 2. Loop through each index of the array, from 0 to length - 1.
        // 3. At each index, store 'number' multiplied by (index + 1). The + 1 is needed
        //    because indexes start at 0, but the first multiple is number * 1.
        // 4. After the loop finishes, return the array.

        var multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan:
        // 1. Create a temporary list the same size as 'data' to hold the rotated order.
        //    (We can't rotate in place directly, or we would overwrite values we still need.)
        // 2. Loop through each index of 'data', from 0 to data.Count - 1.
        // 3. For each item, calculate its new index as (index + amount) % data.Count.
        //    The % makes any index that runs past the end wrap back around to the start.
        // 4. Put the item into the temporary list at that new index.
        // 5. Loop through the temporary list and copy each value back into 'data' at the
        //    same index, so the original list is modified (the function returns nothing).

        var rotated = new List<int>(new int[data.Count]);
        for (var i = 0; i < data.Count; i++)
        {
            var newIndex = (i + amount) % data.Count;
            rotated[newIndex] = data[i];
        }

        for (var i = 0; i < data.Count; i++)
        {
            data[i] = rotated[i];
        }
    }
}
