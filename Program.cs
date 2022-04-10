//10.1
/*Создать класс Figure для работы с геометрическими фигурами. 
В качестве полей класса задаются цвет фигуры,состояние «видимое/невидимое».
Реализовать операции: передвижение геометрической фигуры по горизонтали,
по вертикали, изменение цвета, опрос состояния (видимый/невидимый).
Метод вывода на экран должен выводить состояние всех полей объекта. 

Создать класс Point (точка) как потомок геометрической фигуры. Создать 
класс Circle (окружность) как потомок точки. В класс Circle добавить метод,
который вычисляет площадь окружности. Создать класс Rectangle 
(прямоугольник) как потомок точки, реализовать метод вычисления площади 
прямоугольника.

Точка, окружность, прямоугольник должны поддерживать методы 
передвижения по горизонтали и вертикали, изменения цвета. 
Подумать, какие методы можно объявить в интерфейсе, нужно ли 
объявлять абстрактный класс, какие методы и поля будут в абстрактном классе,
какие методы будут виртуальными, какие перегруженными.
*/

using LabByFigure;
using LabByFigure.GeometricFigure;


var circle = new Circle("Синий", true, 5, new Point(23, 24));
Console.WriteLine(circle);

Console.WriteLine();
var newCircle = circle.WithColor("Голубой");
newCircle = newCircle.Move(new Point(-77, -23));
Console.WriteLine(newCircle);
Console.WriteLine($"Equals ... класс Circle и класс Circle = {circle.Equals(newCircle)}");

Figure figure1 = circle;
Console.WriteLine();
Console.WriteLine(figure1);
Console.WriteLine($"Equals ... класс Figure(от Circle) и Circle = {figure1.Equals(circle)}");
Console.WriteLine($"Equals ... класс Circle и класс Figure(от Circle) = {circle.Equals(figure1)}");

Console.WriteLine();
var rectangle = new Rectangle("Черный", false, 10, 15);
Console.WriteLine(rectangle);
PrintVertexCoordinat(rectangle._Vertices);
Figure figure2 = rectangle;
Console.WriteLine(figure2);
Console.WriteLine(figure2.Equals(rectangle));
Console.WriteLine();

figure2 = figure2.Move(new Point(-3, -33));
Console.WriteLine();
Console.WriteLine($"Equals ... класс Figure (Rectangle[изменены координаты точки] / Rectangle) = {figure2.Equals(rectangle)}");

Console.WriteLine();
Console.WriteLine($"Equals ... класс Figure (Circle / Rectangle) = {figure1.Equals(figure2)}");


void PrintVertexCoordinat(Point[] points)
{
    Console.WriteLine("Печать координат вершин прямоугольника:");
    for (var i = 0; i < 4; i++)
    {
        Console.WriteLine($"[X = {points[i].X}; Y = {points[i].Y}]");
    }
}