// int NumJewelsInStones(string jewels, string stones)
// {
//     int totalJewels = 0;
//     var jewelsHash = jewels.ToHashSet();

//     foreach (var stone in stones)
//     {
//         if (jewelsHash.Contains(stone))
//         {
//             totalJewels++;
//         }
//     }

//     return totalJewels;
// }


// bool ContainsDuplicate(int[] nums)
// {
//     var hashset = new HashSet<int>();

//     foreach (var num in nums)
//     {
//         bool canAdd = hashset.Add(num);

//         if (!canAdd)
//         {
//             return true;
//         }
//     }

//     return false;
// }


// int[] SortedSquares(int[] nums)
// {
//     int left = 0;
//     int right = nums.Length - 1;
//     int[] result = new int[nums.Length];

//     for (int i = nums.Length - 1; i >= 0; i--)
//     {
//         if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
//         {
//             result[i] = nums[left] * nums[left];
//             left++;
//         }
//         else
//         {
//             result[i] = nums[right] * nums[right];
//             right--;
//         }
//     }

//     return result;
// }


// void ReverseString(char[] s)
// {
//     int left = 0;
//     int right = s.Length - 1;

//     while (left < right)
//     {
//         char temp = s[left];
//         s[left] = s[right];
//         s[right] = temp;
//         left++;
//         right--;
//     }
// }

// int CalPoints(string[] operations)
// {
//     Stack<int> stack = new Stack<int>();

//     foreach (var operation in operations)
//     {
//         switch (operation)
//         {
//             case "+":
//                 int temp = stack.Pop() + stack.Peek();
//                 stack.Push(temp - stack.Peek());
//                 stack.Push(temp);
//                 break;

//             case "D":
//                 stack.Push(stack.Peek() * 2);
//                 break;

//             case "C":
//                 stack.Pop();
//                 break;

//             default:
//                 stack.Push(int.Parse(operation));
//                 break;
//         }
//     }

//     return stack.Sum();
// }

// bool IsValid(string s)
// {
//     Stack<char> stack = new Stack<char>();

//     foreach (var c in s)
//     {
//         switch (c)
//         {
//             case '}':
//                 if (stack.Pop() != '{')
//                     return false;
//                 break;

//             case ')':
//                 if (stack.Pop() != '(')
//                     return false;
//                 break;

//             case ']':
//                 if (stack.Pop() != '[')
//                     return false;
//                 break;

//             default:
//                 stack.Push(c);
//                 break;
//         }

//     }

//     return stack.Peek();
// }