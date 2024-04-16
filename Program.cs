internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Assalomu alaykum! \nKichik dasturimizga xush kelibsiz!\n");
        string input = "";
        int num = 0;
        do
        {
            Console.WriteLine("\n\nKerakli bo'limni tanlang : ");
            Console.WriteLine("1 - Birinchi N ta fibonachi sonlarni topish;\n2 - Kiritilgan sonni tublikka tekshirish;\n3 - Tugatish;");
            input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    Console.Write("N = ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Fibonachi(num);
                    break;

                case "2":
                    Console.Write("N = ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nKiritilgan son tub");
                    if(CheckTub(num)) Console.WriteLine(" emas");
                    break;
            }



        } while (input != "3");
    }
    static void Fibonachi(int cnt)
    {
        Console.WriteLine($"{cnt} ta fibonachi sonlar: ");
        if (cnt == 1) Console.WriteLine(0);
            else
                { 
                    Console.Write("0, 1");
                    int[] nums = new int[cnt];
                    nums[0] = 0;
                    nums[1] = 1;
                    for(int index = 2; index < cnt; index ++)
                        {
                            nums[index] = nums[index - 1] + nums[index - 2];
                            Console.Write($", {nums[index]}");
                        }
                }
        Console.WriteLine();
    }

    static bool CheckTub(int num)
    {
        for (int i = 2; i * i <= num; i ++)
            if (num % i == 0) return true;
        return false;
    }
}