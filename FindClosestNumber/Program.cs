int FindClosestNumber(int[] nums)
{
    if (nums.Length == 1)
    {
        return nums.First();
    }

    int closest = int.MaxValue;
    foreach (int num in nums)
    {
        if (Math.Abs(num) <= Math.Abs(closest))
        {
            if (Math.Abs(num) == Math.Abs(closest))
                closest = num > closest ? num : closest;
            else closest = num;
        }
    }

    return closest;
}

int[] test = [-4, -2, 1, 4, 8];

Console.WriteLine(FindClosestNumber(test));