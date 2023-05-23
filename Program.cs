//Задание 1

//icosaedr figure = new();
//figure.OutArea();
//figure.OutVolume();
//Console.WriteLine();
//icosaedr figure2 = new(2);
//figure2.OutArea();
//figure2.OutVolume();

//Console.WriteLine("\nПодпись о фигуре с наибольшим объемом");
//if (figure.Volume() > figure2.Volume()) figure.OutTitle();
//else if (figure.Volume() == figure2.Volume())
//{
//    Console.WriteLine("Объемы равны.");
//    figure.OutTitle();
//    figure2.OutTitle();
//}
//else figure2.OutTitle();

//if (Math.Abs(figure.Area() - 100) < Math.Abs(figure2.Area() - 100)) Console.WriteLine("Площадь первой фигуры ближе к 100");
//else if (Math.Abs(figure.Area() - 100) > Math.Abs(figure2.Area() - 100)) Console.WriteLine("Площадь второй фигуры ближе к 100");
//else Console.WriteLine("Площади равны");


//Задание 2
int x;
while (true)
{
    Console.WriteLine("Введите количество фигур: ");
    x = Convert.ToInt32(Console.ReadLine());
    if (x > 0) break;
    else Console.WriteLine("Число должно быть положительным");
}
icosaedr[] array = new icosaedr[x];
for (int i = 0; i < x; i++)
{
    Console.WriteLine($"{i + 1} фигура");
    array[i] = new icosaedr();
}

int maxlen = array[0].Title.Length;
for (int i = 1; i < x; i++) 
{ if (array[i].Title.Length > maxlen) maxlen = array[i].Title.Length; }
Console.WriteLine("Данные фигур с самой длинной подписью");
for (int i = 0; i < x; i++) 
{ if (array[i].Title.Length == maxlen) array[i].OutAll(); }

Console.WriteLine("Новая фигура");
icosaedr newfigure = new(2 * array[^1].Edge);
newfigure.OutAll();

double minimalarea = array[0].Area();
int morethan15 = 0;
double summary_vol = 0;
Console.WriteLine("Площади поверхности и обЪемы всех фигур в массиве ");
for (int i = 0; i < x; i++)
{
    Console.WriteLine($"{i + 1} фигура");
    array[i].OutArea();
    array[i].OutVolume();
    if (array[i].Area() < minimalarea) minimalarea = array[i].Area();
    if (array[i].Area() > 15) morethan15++;
    summary_vol += array[i].Volume();
}

Console.WriteLine("Подписи фигур с наименьшей площадью");
for (int i = 0; i < 1; i++)
{
    if (array[i].Area() == minimalarea)
    {
        array[i].Title = "MIN" + array[i].Title;
        array[i].OutTitle();
    }
}

Console.WriteLine($"\nКол-во фигур с площадью больше 15 = {morethan15}");
Console.WriteLine("Сумма всех объемов в массиве = " + summary_vol);

