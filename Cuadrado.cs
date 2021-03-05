class Cuadrado: FiguraGeometrica
{
    // protected: tiene visibilidad dentro del namespace (cualquier clase
    // en la misma carpeta)
    protected int lado;
    private int area;

    public void calcularArea()
    {
        area = lado * lado;
        System.Console.WriteLine($"El área del cuadrado es: {area}");
    }
}