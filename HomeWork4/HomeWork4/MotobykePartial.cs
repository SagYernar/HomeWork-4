using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public partial class Motobyke
    {
        static Motobyke()
        {
            category = "A1";
            koles = "2";
        }
        public Motobyke() { }

        public Motobyke(string company, string model, double price, int year, bool isNew)
        {
            this.company = company;
            this.model = model;
            this.price = price;
            this.year = year;
            this.isNew = isNew;
        }

        public void SetCompany(string company)
        {
            this.company = company;
        }
        public string GetCompany()
        {
            return company;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }
        public string GetModel()
        {
            return model;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }
        public double GetPrice()
        {
            return price;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }
        public int GetYear()
        {
            return year;
        }

        public void SetIsNew(bool isNew)
        {
            this.isNew = isNew;
        }
        public bool GetIsNew()
        {
            return isNew;
        }

        public void Show()
        {
            Console.WriteLine("Марка - {0}", company);
            Console.WriteLine("Модель - {0}", model);
            Console.WriteLine("Стоимость - {0}", price);
            Console.WriteLine("Год выпуска - {0}", year);
            if(isNew == true)
            {
                Console.WriteLine("Статус - новая");
            }
            else
            {
                Console.WriteLine("Статус - б/у");
            }
            Console.WriteLine("Необходимая категория - {0}", category);
            Console.WriteLine("Количество колес - {0}", koles);
        }

        public void Init()
        {
            Console.WriteLine("Введите компанию");
            company = Console.ReadLine();

            Console.WriteLine("Введите модель");
            model = Console.ReadLine();

            Console.WriteLine("Введите стоимость");
            string strPrice = Console.ReadLine();
           
            if (Double.TryParse(strPrice, out price))
            {
                price = Double.Parse(strPrice);
            }

            Console.WriteLine("Введите год выпуска");
            string strYear = Console.ReadLine();
            
            if (Int32.TryParse(strYear, out year))
            {
                year = Int32.Parse(strYear);
            }

            Console.WriteLine("Если машина новая введите 1");
            string strIsNew = Console.ReadLine();
            if (strIsNew == "1") { isNew = true; }
            else { isNew = false; }
        }

        public void ChangePrice(ref double price)
        {
            Console.WriteLine("Введите новую стоимость");
            string strNewPrice = Console.ReadLine();

            if (Double.TryParse(strNewPrice, out price))
            {
                price = Double.Parse(strNewPrice);
            }
        }

    }
}
