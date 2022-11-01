#region
//{
//    int[] arr = { 46, 59, 33, 10, 69, 9, 31, 45, 73 };
//    if (arr.Length > 0)
//    {
//        int a = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (a > arr[i])
//            {

//                a = arr[i];    
//            }
//        }
//        Console.WriteLine("En kicik eded {0}", a);

//    }
//}
#endregion

#region 
int[] arr = { 46, 59, -3, 6, 10, 69, 9, 31, 45, 73, 0 };
int counter = 0;
if (arr.Length > 0)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] <= 9 && arr[i] >= 0)
        {
            counter++;
        }

    Console.WriteLine(counter);
}

#endregion