using ClassTask;

Student S1 = new Student("Elcan", "Shalanov", "P236", 95, true);
Console.WriteLine("Telebenin adi ve soyadi");
Console.WriteLine(S1.Info1(S1.Name, S1.Surname)); 
Console.WriteLine("telebenin butun melumatlari");
S1.Info2();
Console.WriteLine("Telebenin bal artirmaq ucun imtahan vere bilib bilmemesi");
S1.Check(S1.Name, S1.Point);
Console.WriteLine("------------------------------");
Student S2 = new Student("Nihat", "Esedov", "P236", 79, false);
Console.WriteLine("Telebenin adi ve soyadi");
Console.WriteLine(S2.Info1(S2.Name, S2.Surname));
Console.WriteLine("telebenin butun melumatlari");
S2.Info2();
Console.WriteLine("Telebenin bal artirmaq ucun imtahan vere bilib bilmemesi");
S2.Check(S2.Name, S2.Point);