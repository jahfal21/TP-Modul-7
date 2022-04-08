using System;

namespace tpmodul7_1302204034
{
    public class Program
    {
        public static void Main()
        {
            CovidConfig config = new CovidConfig();
            config.ReadJSON();

            Console.WriteLine($"Berapakah suhu badan anda saat ini ? Dalam nilai {config.CONFIG1}");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam ?");
            int input2 = Convert.ToInt32(Console.ReadLine());

            bool kondisi1;
            if (config.CONFIG1 == "celcius")
            {
                kondisi1 = (input1 >= 36.5) && (input1 <= 37.5);
            }
            else
            {
                kondisi1 = (input1 >= 97.7) && (input1 <= 99.5);
            }

            if (kondisi1 && input2 < config.CONFIG2)
            {
                Console.WriteLine(config.CONFIG4);
            }
            else
            {
                Console.WriteLine(config.CONFIG3);
            }

            Console.WriteLine("\nTest ubah config1");
            Console.WriteLine(config.CONFIG1);
            config.UbahSatuan();
            Console.WriteLine(config.CONFIG1);
        }
    }
}
