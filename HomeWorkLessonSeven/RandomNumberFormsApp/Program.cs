﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberFormsApp
{
    //Галиев Камиль
    //Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
    //а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное 
    //число введенного.
    //a) Для ввода данных от человека используется элемент TextBox;
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
