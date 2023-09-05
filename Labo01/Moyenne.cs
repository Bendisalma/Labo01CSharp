namespace Labo01;
using System;
public class Moyenne 
{
    public  double CalculerMoyenne(List<double> liste)
    {
        double somme = 0;
        foreach (var item in liste)
        {
            somme += item;
        }
        return somme / liste.Count;

 
    }

}
