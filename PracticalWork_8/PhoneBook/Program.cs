﻿/*
 * Что нужно сделать
 * 
Пользователю итеративно предлагается вводить в программу номера телефонов и ФИО их владельцев. 
В процессе ввода информация размещается в Dictionary,
где ключом является номер телефона, а значением — ФИО владельца.
Таким образом, у одного владельца может быть несколько номеров телефонов. 
Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки. 
Далее программа предлагает найти владельца по введенному номеру телефона. 
Пользователь вводит номер телефона и ему выдаётся ФИО владельца. 
Если владельца по такому номеру телефона не зарегистрировано, 
программа выводит на экран соответствующее сообщение.
 */

using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // основное меню
            PhoneBook.Menu();
        }
    }
}