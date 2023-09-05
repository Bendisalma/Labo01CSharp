namespace Labo01.tests;

[TestClass]
public class CalculerMoyenneTest
{
    [TestMethod]
    public void CalculerMoyenne()
    {
        Moyenne moyenneCalculator = new Labo01.Moyenne();
        List<double> liste = new List<double> { 10.5, 5.5, 30.5, 13.5 };
        double resultat = moyenneCalculator.CalculerMoyenne(liste);
        Assert.AreEqual(15.0, resultat, 0.0001); // Précision de 0.0001
    }
}