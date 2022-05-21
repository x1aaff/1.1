using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ФИО
             * 
            Улица
            Номер дома
            Номер квартиры
             *
            Мобильный телефон
            Домашний телефон*/

            XElement ePerson = new XElement("Person");
            XElement eAddress = new XElement("Address");
            XElement ePhones = new XElement("Phones");

            Console.Write("ФИО: ");
            XAttribute aPersonName = new XAttribute("name", Console.ReadLine());
            Console.Write("Улица: ");
            XElement aStreet = new XElement("Street", Console.ReadLine());
            Console.Write("Номер дома: ");
            XElement aHouseNumber = new XElement("HouseNumber", Console.ReadLine());
            Console.Write("Номер квартиры: ");
            XElement aFlatNumber = new XElement("FlatNumber", Console.ReadLine());
            Console.Write("Мобильный телефон: ");
            XElement aMobilePhone = new XElement("MobilePhone", Console.ReadLine());
            Console.Write("Домашний телефон: ");
            XElement aFlatPhone = new XElement("FlatPhone", Console.ReadLine());

            eAddress.Add(aStreet, aHouseNumber, aFlatNumber);
            ePhones.Add(aMobilePhone, aFlatPhone);
            ePerson.Add(aPersonName, eAddress, ePhones);

            Console.WriteLine(ePerson);
            ePerson.Save("person.xml");
        }
    }
}
