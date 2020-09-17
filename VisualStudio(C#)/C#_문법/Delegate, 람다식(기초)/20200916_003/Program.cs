using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    static int ArraySortPrice(Product T1, Product T2)
    {
        return T1.Price.CompareTo(T2.Price);
    }

    static int ArraySortPrice2(Product T1, Product T2)
    {
        return T1.Price.CompareTo(T2.Price);
    }

    static int ArraySortName(Product T1, Product T2)
    {
        return T1.Name.CompareTo(T2.Name);
    }

    static int ArraySortName2(Product T1, Product T2)
    {
        return T1.Name.CompareTo(T2.Name) * -1; // * -1 == 리버스
    }


    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product() { Name = "감자  ", Price = 500 },
            new Product() { Name = "사과  ", Price = 700 },
            new Product() { Name = "고구마", Price = 400 },
            new Product() { Name = "배추  ", Price = 600 },
            new Product() { Name = "상추  ", Price = 300 }
        };

        //products.Sort(ArraySortPrice); //정렬
        //products.Reverse();            //리버스
        //products.Sort(ArraySortName);  //이름으로 정렬


        // 무명 델리게이터
        // delegate (<매개변수>, <매개변수>){ /*코드*/ return /*반환*/;}
        //products.Sort(delegate(Product T1, Product T2) {return T1.Price.CompareTo(T2.Price);});

        // 람다 (Λ) : 델리게이터를 쉽게 이용할 수 있게 한것
        // 람다식은 주로 고차 함수에 인자(argument)로 전달되거나 고차 함수가 돌려주는 결과값으로 쓰임
        products.Sort((T1, T2) =>
        {
            return T1.Price.CompareTo(T2.Price);
        });

        foreach (Product item in products)
        {
            Console.WriteLine(item.Name + " :  " + item.Price);
        }
    }
}