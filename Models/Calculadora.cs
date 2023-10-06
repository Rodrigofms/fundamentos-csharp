using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosCs.Models
{
    public class Calculadora
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        }
        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        }
        public void Dividir(int n1, int n2)
        {
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
        }
        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
        }
        public void Potencia(int n1, int n2)
        {
            double potencia = Math.Pow(n1, n2);
            Console.WriteLine($"{n1} ^ {n2} = {potencia}");
        }
        public void RaizQuadrada(double n1)
        {
            double raizquadrada = Math.Sqrt(n1);
            Console.WriteLine($"√{n1} = {raizquadrada}");
        }
        public void Seno(double angulo)
        {
            double radiano = (angulo * Math.PI) / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}= {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = (angulo * Math.PI) / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}= {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = (angulo * Math.PI) / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}= {Math.Round(tangente, 4)}");
        }
    }
}