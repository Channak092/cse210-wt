 
public abstract class Shape  
{  
    public abstract void Draw();  
}  
  
public class Circle : Shape  
{  
    public override void Draw()  
    {  
        Console.WriteLine("Drawing a circle.");  
    }  
}  
  
public class Rectangle : Shape  
{  
    public override void Draw()  
    {  
        Console.WriteLine("Drawing a rectangle.");  
    }  
}  
  
public class ShapeProcessor  
{  
    public void ProcessShapes(List shapes)  
    {  
        foreach (Shape shape in shapes)  
        {  
            shape.Draw();  
        }  
    }  
}