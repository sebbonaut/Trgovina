using Trgovina;

Artikl A = new("Med cvjetni 450g");
Console.WriteLine(A.Kolicina); //10
//A.Kolicina += 20;
A.Kupi(2);
Console.WriteLine(A.Kolicina); //8
Artikl B = new("Kruh")
{
    TipProizvoda = Kategorija.Pecivo
};
//B.TipProizvoda = Kategorija.Pecivo;
Console.WriteLine(B.TipProizvoda == Kategorija.Pecivo); //True
Console.WriteLine(B.TipProizvoda); //Pecivo
Console.WriteLine((byte)B.TipProizvoda); //2
