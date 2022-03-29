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

var point = new Point("Синий", GeometricState.Visible, 23, 24);
Console.WriteLine(point);
var newPoint = point.EditColor("Красный");
Console.WriteLine(newPoint);
newPoint = newPoint.MovinHorizontally(-54);
newPoint = newPoint.MovinVertically(78);
Console.WriteLine(newPoint);

var circle = new Circle("Синий", GeometricState.Visible, 5, 23, 24);
Console.WriteLine(circle);
var newCircle = circle.EditColor("Голубой");
newCircle = newCircle.MovinHorizontally(-77);
newCircle = newCircle.MovinVertically(-23);
Console.WriteLine(newCircle);
