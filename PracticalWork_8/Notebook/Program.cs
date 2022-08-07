﻿/*
 * Программа спрашивает у пользователя данные о контакте:

ФИО
Улица
Номер дома
Номер квартиры
Мобильный телефон
Домашний телефон


С помощью XElement создайте xml файл, в котором есть введенная информация. 
XML файл должен содержать следующую структуру:

<Person name=”ФИО человека” >
    <Address>
        <Street>Название улицы</Street>
        <HouseNumber>Номер дома</HouseNumber>
        <FlatNumber>Номер квартиры</FlatNumber>
    </Address>
    <Phones>
        <MobilePhone>89999999999999</MobilePhone>
        <FlatPhone>123-45-67<FlatPhone>
    </Phones>
</Person>

*/

namespace Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook.Menu();
        }
    }
}