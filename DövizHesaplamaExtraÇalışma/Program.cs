namespace DövizHesaplamaExtraÇalışma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal d = 18.68m;
            decimal e = 19.23m;
            decimal p = 21.81m;

            string paraBirimi;
            decimal kacParamvar = 0.00m;
            Console.WriteLine("Lütfen Türk Lirası cinsinden paranızı giriniz");
            decimal paratl = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("lütfen işlem yapmak istediğiniz para birimini yazınız");
            paraBirimi = Console.ReadLine();



            //if (paraBirimi == "d")
            //{
            //    kacParamvar = paratl / d;
            //}
            //else if (paraBirimi == "e")
            //{
            //    kacParamvar = paratl / e;
            //}
            //else if (paraBirimi == "p")
            //{
            //    kacParamvar = paratl / p;
            //}
            //else
            //{
            //    Console.WriteLine("yanlış birim girdiniz : ");
            //}
            //Console.WriteLine("kaç param var :  " + kacParamvar);


            switch(paraBirimi)
            {
                case "d": kacParamvar = paratl / d;
                    break;
                case "e": kacParamvar = paratl / e;
                    break;
                case "p": kacParamvar = paratl / p;
                    break;
                default: kacParamvar = 0;
                        break;

            }
            Console.WriteLine("Kaç param var: " + kacParamvar);

        }

    }
}