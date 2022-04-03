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
var newCircle = circle.WithColor("Голубой");
newCircle = newCircle.MoveHorizontally(-77);
newCircle = newCircle.MoveVertically(-23);
Console.WriteLine(newCircle);

var rectangle = new Rectangle("Черный", true, 10, 15);
Console.WriteLine(rectangle);
rectangle.PrintVertexCoordinat();
Figure figure = rectangle;
Console.WriteLine(figure);
Console.WriteLine(figure.Equals(rectangle));
