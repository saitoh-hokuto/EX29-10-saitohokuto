using System;

public class solids
{
    static void Main()
    {
        float value1 = 0, value2 = 0,value3 = 0;
        Console.WriteLine("直方体");
        value1 = Inputfloat("横幅を入力してください");
        value2 = Inputfloat("高さを入力してください");
        value3 = Inputfloat("奥行を入力してください");
        Console.WriteLine("表面積は" + Cuboid.GetSurface(value1,value2,value3)+"\n体積は" + Cuboid.GetVolume(value1, value2, value3));

        Console.WriteLine("\n円柱");
        value1 = Inputfloat("底面の半径を入力してください");
        value2 = Inputfloat("高さを入力してください");
        Console.WriteLine("表面積は" + Cylinder.GetSurface(value1,value2)+ "\n体積は" + Cylinder.GetVolume(value1, value2));

        Console.WriteLine("\n球");
        value1 = Inputfloat("球の半径を入力");
        Console.WriteLine("表面積は" + Sphere.GetSurface(value1)+ "\n体積は" + Sphere.GetVolume(value1));

        Console.WriteLine("\n三角柱");
        value1 = Inputfloat("底面の三角形の底辺を入力してください");
        value2 = Inputfloat("底面の三角形の高さを入力してください");
        value3 = Inputfloat("三角柱の高さを入力してください");
        Console.WriteLine("表面積は" + Triangular_prism.GetSurface(value1,value2,value3)+ "\n体積は" + Triangular_prism.GetVolume(value1,value2,value3));
    }

    static float Inputfloat(string outputstring)
    {
        float input;
        while (true)
        {
            Console.WriteLine(outputstring);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }
    }
}
static class Cuboid
{
    public static float GetSurface(float Width, float Height, float Depth)
    {
        return (Width * Depth + Width * Height + Height * Depth) * 2.0f;
    }
    public static float GetVolume(float width, float height, float depth)
    {
        return width * depth * height;
    }
}
static class Cylinder
{    
    public static float GetSurface(float Radius, float Height)
    {
        return (Radius * Radius * MathF.PI) * 2.0f + (Radius * 2 * MathF.PI * Height);
    }
    public static float GetVolume(float Radius, float Height)
    {
        return Radius * Radius * MathF.PI * Height;
    }
}
static class Sphere
{
    public static float GetSurface(float S_Radius)
    {
        return 4.0f * MathF.PI * S_Radius * S_Radius;
    }
    public static float GetVolume(float S_Radius)
    {
        return (4.0f / 3.0f * MathF.PI * S_Radius * S_Radius * S_Radius);
    }
}
static class Triangular_prism
{
    public static double GetSurface(float Triangular_Base, float Triangular_Height, float Height)
    {
        return Triangular_Base * Triangular_Height + (Triangular_Base + Triangular_Height + Math.Sqrt(Triangular_Height * Triangular_Height + Triangular_Base * Triangular_Base)) * Height;
    }
    public static float GetVolume(float Triangular_Base, float Triangular_Height, float Height)
    {
        return (Triangular_Base * Triangular_Height / 2.0f) * Height;
    }
}