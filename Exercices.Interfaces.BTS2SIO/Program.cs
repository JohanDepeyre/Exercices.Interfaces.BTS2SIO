// See https://aka.ms/new-console-template for more information
using Exercices.Interfaces.BTS2SIO;

Console.WriteLine("Hello, World!");
Cochon cochon = new Cochon("NifNif");
Cochon cochon2 = new Cochon("NafNaf");
Loup loup = new Loup("Grand Mechant Loup");

List<IAnimal> animals= new List<IAnimal>();
animals.Add(cochon);
animals.Add(cochon2);
animals.Add(loup);



foreach (IAnimal animal in animals)
{
    animal.Manger();
}