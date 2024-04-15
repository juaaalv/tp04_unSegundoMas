﻿using System;

namespace tp04_Lopez
{
    internal class Program
    {
        static void Main(string[] args)
        {


            (int horas, int minutos, int segundos)= IngresoHorario("Ingrese la hora actual", "ahora los minutos", "y los segundos");

             (horas, minutos, segundos) = CalcularHora(horas, minutos, segundos);

            MostrarReloj(horas, minutos, segundos);
        }
       
        //MODULOS
        static (int, int, int) IngresoHorario(string mensaje1, string mensaje2, string mensaje3)
        {
            Console.WriteLine(mensaje1);
            int hora = int.Parse(Console.ReadLine());
            Console.WriteLine(mensaje2);
            int minutos = int.Parse(Console.ReadLine());
            Console.WriteLine(mensaje3);
            int segundos = int.Parse(Console.ReadLine());
            return (hora, minutos, segundos);
        }
        static (int, int, int) CalcularHora(int hora, int min, int seg)
        {
            seg++;
            if (seg == 60)
            {
                seg = 0;
                min++;

                if (min == 60)
                {
                    min = 0;
                    hora++;

                    if (hora == 24)
                    {
                        hora = 0;
                    }
                }
            }
            return (hora, min, seg);
        }
        static void MostrarReloj(int hora, int min, int seg)
        {
            Console.WriteLine($"La hora actual es {hora}:{min}:{seg}");
        }
    }
}