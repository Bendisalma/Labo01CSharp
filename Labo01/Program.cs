namespace Labo01;

using System;


public class Program 
{
    public static double CalculerMoyenne(List<double> liste)
    {
        double somme = 0;
        foreach (var item in liste)
        {
            somme += item;
        }
        return somme / liste.Count;

 
    }
    public static void Main(string[] args)
    {
        List<double> liste = new List<double> { 10.5, 5.5, 30.5, 13.5 };
    }
 }
