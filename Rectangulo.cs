class Rectangulo : FiguraGeometrica
{
    // C# agrega de manera implícita el modificador private
    // private: solo es visible y utilizable dentro de la misma clase
    private double _base, _altura, _area;

    public override void calcularArea(double b, double a)
    {
        _base = b;
        _altura = a;
        _area = _base * _altura;
        System.Console.WriteLine($"El área del rectángulo es {_area}");
    }
}