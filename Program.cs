﻿//Задача 10: Напишите программу, которая принимает вход на трехзначное число и на вывод второй цифры этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int  number  =  ReadInt ( " Введите трехзначное число: " );
целая  сумма  =  число . ТоСтрока (). длина ;

если ( сумма  <  3  ||  сумма  >  3 )
{
    Консоль . WriteLine ( " Вы ввели не трехзначное число " );
}
еще
{
    Консоль . WriteLine ( InCenter ( число ));
}



// ФУНКЦИИ-------------------------------------------------------------- -------------------------------------------------- -----

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователя.
int  ReadInt ( строковое  сообщение )
{
    Консоль . Пишите ( сообщение );
    вернуть  Преобразовать . ToInt32 ( Консоль.ReadLine ( )) ;
}

// Функция расчета статистики стоящей в середине трехзначногно числа.
интервал  InCenter ( интервал  a )
{
    
    int  результат  = (( а  /  10 ) %  10 );
    вернуть  результат ;
}

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что других цифр нет.
645 -> 5
// 78 -> других цифр нет
// 32679 -> 6
*/

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(число, количество));


// ФУНКЦИИ-------------------------------------------------------------- -------------------------------------------------- -----

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователя.
int ReadInt(строковое сообщение)
{
    Console.Write(сообщение);
    вернуть Convert.ToInt32(Console.ReadLine());
}

// Функция принимает назначенное пользователем количество символов и выводит третью цифру числа. Если 3 данных нет, сообщает и выводит 0.
int MakeArray (int a, int b)
{
результат = 0;
    если (б < 3)
    {
        Console.Write("Третей цифр нет, держи: ");
    }
    еще
    {
        интервал с = 1;
        для (int i = b; i > 3; i--)
        {
            с = с * 10;
        }

        результат = (а/с) % 10;
    }
вернуть результат;
}

# Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
# Пример:
# - 6 -> да
# - 7 -> да
# - 1 -> нет

number = int(input("Введите число дня недели от 1 до 7: "))

if number < 1 or number > 7:
    print('Вы ввели неверное число! До встречи ;)')
elif number > 5:
    print('Да, этот день выходной!')
else:
    print('Увы, но это рабочий день!')