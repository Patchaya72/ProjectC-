class Program
{
    static void Main(string[] args)
    {
        string[] data = { "[1] Find a positive result by matching numbers in an array.", "[2] Check the similarity of the message.", "[3] Display a range of broadcast date numbers of a TV show.", "[4] Inverted Pyramid.", "[5] Pyramid Numbers.", "[6] Sort in descending order. .", "[7] Display time .", "[8] Calculation function to find the number of banknotes.", "[9] revert.", "[10] Pyramid.", "[11] Sort in ascending order.", "[0] Exit." };
        bool star = true;
        int input = 99;
        while (star)
        {
            Console.Clear();
            Console.WriteLine("\n ProgramTest by Yimpie \n");
            foreach (string func in data)
            {
                Console.WriteLine(func);
            }
            Console.Write("InPutNumber in func: ");
            int.TryParse(Console.ReadLine(), out input);
            if (input == 0)
            {
                Console.WriteLine("Thank  You");
                break;
            }
            else if (input == 1)
            {
                ex1();
            }
            else if (input == 2)
            {
                ex2();
            }
            else if (input == 3)
            {
                ex3();
            }
            else if (input == 4)
            {
                ex4();
            }
            else if (input == 5)
            {
                ex5();
            }
            else if (input == 6)
            {
                ex6();
            }
            else if (input == 7)
            {
                ex7();
            }
            else if (input == 8)
            {
                ex8();
            }
            else if (input == 9)
            {
                ex9();
            }
            else if (input == 10)
            {
                ex10();
            }
            else if (input == 11)
            {
                ex11();
            }
            else
            {
                Console.Write("InPutNumber in func: ");
            }
        }
    }
    static void ex1()
    {
        while (true)
        {


            bool chknull = false;
            int sum;
            Console.Write("Input Number in Array Or Exit: ");
            string? input = Console.ReadLine();
            string ck = input!.ToLower();
            if (ck == "exit")
            {
                break;
            }
            Console.Write("Input Sum: ");
            int.TryParse(Console.ReadLine(), out sum);
            if (input != null)
            {
                string[] stringNumbers = input.Split(',');
                foreach (string str in stringNumbers)
                {
                    if (str.Trim() == "")
                    {
                        chknull = true;
                    }
                }
                List<int> data = new List<int>();
                List<string> result = new List<string>();
                if (!chknull)
                {

                    foreach (string str in stringNumbers)
                    {
                        if (int.TryParse(str.Trim(), out int number))
                        {
                            data.Add(number); // เพิ่มจำนวนเต็มลงใน List
                        }
                    }
                    for (int i = 0; i < data.Count; i++)
                    {
                        for (int j = i + 1; j < data.Count; j++)
                        {
                            if (data[i] + data[j] == sum)
                            {
                                result.Add(data[i] + "," + data[j]);
                                data[i] = '*';
                                data[j] = '*';
                            }
                        }
                    }
                    int s = 1;
                    if (result.Count > 1)
                    {
                        foreach (string re in result)
                        {
                            Console.WriteLine(s + ": " + re);
                            s++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ไม่มีข้อมูล");
                    }
                }
                else
                {
                    Console.WriteLine("รูปแบบผิด!!!");
                }

            }
            else
            {
                Console.WriteLine();
            }

        }

    }
    static void ex2()
    {
        while (true)
        {


            Console.Write("Input Exit Or the Word of s1 : ");
            string? s1 = Console.ReadLine();
            if (s1!.ToLower() == "exit")
            {
                break;
            }
            Console.Write("Input the Word of s2: ");
            string? s2 = Console.ReadLine();
            if (s1 != "" && s2 != "" && s1!.Length == s2!.Length)
            {
                string lowS1 = s1.ToLower();
                string lowS2 = s2.ToLower();
                char[] lowS2Array = lowS2.ToCharArray();
                int correct = 0;
                for (int i = 0; i < lowS1.Length; i++)
                {
                    for (int j = 0; j < lowS2.Length; j++)
                    {
                        if (lowS1[i] == lowS2Array[j])
                        {
                            lowS2Array[j] = '*';
                            correct++;
                            break;
                        }
                    }
                }
                if (correct == lowS1.Length)
                {
                    Console.WriteLine("OutPut: True");
                }
                else
                {
                    Console.WriteLine("OutPut: Flse");
                }
            }
            else
            {
                Console.WriteLine("Flse");
            }
            Console.WriteLine();
        }
    }
    static void ex3()
    {
        while (true)
        {


            Console.Write("Input Exit Or Numbers of TV broadcast dates: ");
            string? input = Console.ReadLine();
            if (input!.ToLower() == "exit")
            {
                break;
            }
            bool chknull = false;
            List<int> data = new List<int>();
            if (input != null)
            {

                string[] stringNumbers = input.Split(',');

                foreach (string str in stringNumbers)
                {
                    if (str.Trim() == "")
                    {
                        chknull = true;
                    }
                }
                if (!chknull)
                {
                    foreach (string str in stringNumbers)
                    {
                        if (int.TryParse(str.Trim(), out int number))
                        {
                            data.Add(number); // เพิ่มจำนวนเต็มลงใน List
                        }
                    }
                    int smallest, temp;
                    for (int i = 0; i <= data.Count - 1; i++)
                    {
                        smallest = i;
                        for (int j = i + 1; j < data.Count; j++)
                        {
                            if (data[j] < data[smallest])
                            {
                                smallest = j;
                            }
                        }
                        temp = data[smallest];
                        data[smallest] = data[i];
                        data[i] = temp;
                    }
                }
                else
                {
                    Console.Write("no");
                }

                int start = data[0];
                int end = data[0];
                Console.Write("OutPut: ");
                for (int i = 1; i < data.Count; i++)
                {
                    if (data[i] == end + 1)
                    {
                        end = data[i];
                    }
                    else
                    {
                        if (start == end)
                        {
                            Console.Write(start);
                        }
                        else
                        {
                            Console.Write(start + "-" + end);
                        }

                        start = data[i];
                        end = data[i];

                        if (i <= data.Count - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                }
                if (start == end)
                {
                    Console.Write(start);
                }
                else
                {
                    Console.Write(start + "-" + end);
                }

                Console.WriteLine();
            }
        }
    }
    static void ex4()
    {
        while (true)
        {


            int rows, star = 0;
            Console.Write("Input Exit Or the number of rows: ");
            string? input = Console.ReadLine();
            if (input!.ToLower() == "exit")
            {
                break;
            }
            rows = int.Parse(input);
            Console.WriteLine();
            for (int i = rows; i >= 1; i--, star = 0)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("  ");
                }
                while (star != 2 * i - 1)
                {
                    Console.Write("* ");
                    star++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
    static void ex5()
    {
        while (true)
        {

            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int rows, star = 0, index = 0;
            Console.Write("Input Exit OR the number of rows 1-4: ");
            string? input = Console.ReadLine();
            if (input!.ToLower() == "exit")
            {
                break;
            }
            rows = int.Parse(input);
            if (rows > 0 && rows < 5)
            {
                for (int i = 1; i <= rows; i++, star = 0)
                {
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    while (star != 1 * i)
                    {
                        Console.Write(data[index] + " ");
                        star++;
                        index++;
                    }
                    Console.WriteLine();
                }
            }

        }
    }
    static void ex6()
    {
        while (true)
        {
            //Selection Sort
            int[] data = new int[10];
            bool chknull = false;
            Console.Write("Input  Exit Or the number of data(ex input: 1, 2, 9, 4, 5, 8, 7, 6, 3, 10 ) 10 char : ");
            string? input = Console.ReadLine();
            if (input!.ToLower() == "exit")
            {
                break;
            }
            if (input != null)
            {
                string[] stringNumbers = input.Split(',');
                foreach (string str in stringNumbers)
                {
                    if (str.Trim() == "")
                    {
                        chknull = true;
                    }
                }
                if (stringNumbers.Length == 10 && !chknull)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        data[i] = int.Parse(stringNumbers[i].Trim()); // Trim() ใช้เพื่อลบช่องว่างที่อาจมีอยู่
                    }
                    int maxlest, temp;
                    for (int i = 0; i <= data.Length - 1; i++)
                    {
                        maxlest = i;
                        for (int j = i + 1; j < data.Length; j++)
                        {
                            if (data[j] > data[maxlest])
                            {
                                maxlest = j;
                            }
                        }
                        temp = data[maxlest];
                        data[maxlest] = data[i];
                        data[i] = temp;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Input is: " + input);
                    Console.Write("Sorted array is: ");
                    foreach (int str in data)
                    {
                        Console.Write(str + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("!!! data มากกว่า10 ตัว หรือ รูปแบบผิด ");
                }
                Console.WriteLine();
            }

        }

    }
    static void ex7()
    {
        while (true)
        {
            int hour = 00, minute = 00, second = 00, time;
            string h = "00", m = "00", s = "00";
            Console.Write("Input Exit OR Number of Second : ");
           string? input = Console.ReadLine();
            if (input!.ToLower() == "exit")
            {
                break;
            }
            second = int.Parse(input);
            hour = second / 3600;
            time = second - 3600 * hour;
            minute = time / 60;
            second = time - 60 * minute;
            h = hour.ToString("D2");
            m = minute.ToString("D2");
            s = second.ToString("D2");
            Console.WriteLine("{0}:{1}:{02}", h, m, s);
            Console.WriteLine();
        }
    }
    static void ex8()
    {
          while (true)
        {
        int total = 1000, b500, b100, b50, b10, b5, b1, price;
        Console.Write("Input Exit or Price to be paid : ");
        string? input = Console.ReadLine();
            if (input!.ToLower() == "exit")
            {
                break;
            }
            price = int.Parse(input);

        if (price >= 0 && price <= 1000)
        {
            total = total - price;
            price = total;
            b500 = price / 500;
            price = price - 500 * b500;
            b100 = price / 100;
            price = price - 100 * b100;
            b50 = price / 50;
            price = price - 50 * b50;
            b10 = price / 10;
            price = price - 10 * b10;
            b5 = price / 5;
            price = price - 5 * b5;
            b1 = price;
            Console.WriteLine("จำนวนเงินที่ต้องทอน: " + total + " บาท");
            Console.WriteLine("500: " + b500 + " ใบ");
            Console.WriteLine("100: " + b100 + " ใบ");
            Console.WriteLine("50:  " + b50 + " ใบ");
            Console.WriteLine("10: " + b10 + " เหรียญ");
            Console.WriteLine("5:  " + b5 + "  เหรียญ");
            Console.WriteLine("1:  " + b1 + "  เหรียญ");
        }
        else
        {
            Console.WriteLine("เงินที่ต้องจ่ายเกิน1000 หรือน้อยกว่า 0  บาท");
        }
        Console.WriteLine();
        }
    }
    static void ex9()
    {
         while (true)
        {
        Console.Write("\nInput Exit Or Word to  Revert : ");
        string? word = Console.ReadLine();
        if (word!.ToLower() == "exit")
            {
                break;
            }
        if (word != null)
        {
            
            Console.Write("Output: ");
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
             Console.WriteLine("\n");
        }
        }
    }
    static void ex10()
    {
        while (true)
        {
        int rows, star = 0;
        Console.Write("Input Exit OR the number of rows : ");
         string? input = Console.ReadLine();
            if (input!.ToLower() == "exit")
            {
                break;
            }
            rows = int.Parse(input);
            Console.WriteLine();
        for (int i = 1; i <= rows; i++, star = 0)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write("  ");
            }
            while (star != 2 * i - 1)
            {
                Console.Write("* ");
                star++;
            }
        }
        Console.WriteLine("\n");
        }
    }
    static void ex11()
    {
        while (true)
        {

        //Selection Sort
        int[] data = new int[10];
        bool chknull = false;
        Console.Write("Input  Exit OR number of data(ex input: 1, 2, 9, 4, 5, 8, 7, 6, 3, 10 ) 10 char : ");
        // string? input = Console.ReadLine();
        string? input = Console.ReadLine();
        if (input!.ToLower() == "exit")
            {
                break;
            }
        if (input != null)
        {
            string[] stringNumbers = input.Split(',');
            foreach (string str in stringNumbers)
            {
                if (str.Trim() == "")
                {
                    chknull = true;
                }
            }
            if (stringNumbers.Length == 10 && !chknull)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = int.Parse(stringNumbers[i].Trim()); // Trim() ใช้เพื่อลบช่องว่างที่อาจมีอยู่
                }
                int smallest, temp;
                for (int i = 0; i <= data.Length - 1; i++)
                {
                    smallest = i;
                    for (int j = i + 1; j < data.Length; j++)
                    {
                        if (data[j] < data[smallest])
                        {
                            smallest = j;
                        }
                    }
                    temp = data[smallest];
                    data[smallest] = data[i];
                    data[i] = temp;
                }
                Console.WriteLine();
                Console.Write("Sorted array is: ");
                foreach (int str in data)
                {
                    Console.Write(str + " ");
                }
                 Console.WriteLine("\n");

            }
            else
            {
                Console.WriteLine("\n!!! data มากกว่า10 ตัว หรือ รูปแบบผิด\n ");
            }

        }


    }
    }
}