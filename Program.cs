string subject = "Программирование";
Console.WriteLine(subject.Length);
foreach (char letter in subject)
{
    Console.WriteLine(letter);
}


Console.WriteLine();
int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;
foreach (int grade in grades)
{
    Console.WriteLine(grade);
    sum += grade;
}
double average = (double)sum / grades.Length;

Console.WriteLine($"Сумма оценок :{sum}");
Console.WriteLine($"Средний балл:{average}");


Console.WriteLine();
string[] students = { "Аня", "Ярослав", "Вика" };
int count = 0;
foreach (string student in students)
{
    Console.WriteLine(student);
    count++;
}
Console.WriteLine($"Количество учеников {count}");


Console.WriteLine();
int[] points = { 10, 20, 15 };
for (int i = 0; i < points.Length; i++)
{
    points[i] += 5;
}
 foreach (int point in points)
{
    Console.WriteLine(point);
}
