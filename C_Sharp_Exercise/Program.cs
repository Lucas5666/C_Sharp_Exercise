namespace C_Sharp_Exercise;
class Program
{
    static void Main(string[] args)
    {
        int[] data = new int[] { 23, 45, 45, 67, 3, 55, 32 };
        //InsertSort(data);
        //SelectSort(data);
        //BubbleSort(data);
        QuickSort(data,0,data.Length - 1);

        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();

        static void InsertSort(int[] data)
        {
            //插入排序
            //从第一个索引也就是第二个开始，与前面的一个比较，小于前面的话前面的索引加一，
            //直到找到小于当前的值时插入 当找到第一个也比它小时 插入到第一个位置

            for (int i = 1; i < data.Length; i++)
            {
                int iVaule = data[i];
                bool isInsert = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (data[j] > iVaule)
                    {
                        data[j + 1] = data[j];
                    }
                    else
                    {
                        data[j + 1] = iVaule;
                        isInsert = true;
                        break;
                    }
                }
                if (isInsert == false)
                    data[0] = iVaule;
            }

        }

        //选择排序
        //从第一个索引开始 寻找剩下的里面比当前索引小的最小值 如果找到就交换
        //然后开始下一个 直到最后一个索引
        static void SelectSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = arr[i] , minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minIndex = j;
                    }
                }
                if(minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        //冒泡排序
        //每次都可以在剩下的中找到一个最大的数排在已经找到的最大的数前面 。arr.Length - 1次后就排好序了
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        //快速排序
        //将left索引的值设为比饺值 从right索引开始往前找一个小于left索引的值 将其换到left位置
        //从left索引开始往后找一个大于比饺值的值 将其换到right位置
        //将比饺值 left的值 放到i的位置
        //这样 i位置前面 都是小于i位置对应的值的 i位置后面都是大于i位置对应的值的
        //以i为分界线 将左边 和右边 再进行同样的操作
        static void QuickSort(int[] arr,int left,int right)
        {
            int x = arr[left];
            int i = left;
            int j = right;

            if(left < right)
            {
                while (i < j)
                {
                    if (arr[j] < x)
                    {
                        arr[i] = arr[j];
                        break;
                    }
                    else
                        j--;
                }

                while (i < j)
                {
                    if (arr[i] > x)
                    {
                        arr[j] = arr[i];
                        break;
                    }
                    else
                        i++;
                }

                arr[i] = x;
                QuickSort(arr, left, i - 1);
                QuickSort(arr, i + 1, right);

            }
        }

    }
}

