bool result1=int.TryParse(Console.ReadLine(), out int number1);
bool result2=int.TryParse(Console.ReadLine(), out int number2);
int distance1= Math.Abs(number1 - 17);
int distance2= Math.Abs(number2 - 17);
if (result1 && result2)
{
    if(distance1 > distance2)
    {
        Console.WriteLine("17 ye daha yaxin olan eded {0}-dur.Cunki 17 ile {1} arasindaki mesafe {2}-dir,ancaq {3} ile arasindaki mesafe {4}-dir ", number2, number1, distance1, number2, distance2);
    }
    else if(distance1 < distance2)
    {
        Console.WriteLine("17 ye daha yaxin olan eded {0}-dir.Cunki 17 ile {1} arasindaki mesafe {2}-dir,ancaq {3} ile arasindaki  mesafe {4}-dir " , number1,number1,distance1,number2,distance2);
    }
    else
    {
        Console.WriteLine("17 ile beraber mesafedediler.Mesafe:{0}-dir.",distance1);
    }
}
else
{
    Console.WriteLine("daxil etdiyiniz ededler duzgun qeyd olunmuyub.Zehmet olmasa yeniden nezer yetirin");
}