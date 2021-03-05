/**
 * Modificadores de acceso
 * 
 * public
 * protected
 * private
 * 
 * C# Projects
 * FigurasGeometricas (Ensamblado *.dll *.exe)
 * Namespaces
 * Clases, Interface, estructuras, enumeraciones
 * Clases > Propiedad y Métodos
 */
class Encapsulamiento
{
    static void main(string[] args)
    {
        var rect = new Rectangulo();
        rect.calcularArea(10,20);
        // marcaría error por no tener visibilidad de la propiedad _base
        System.Console.WriteLine($"El valor de la base en rect es: {rect._base}");

        var cuadro = new Cuadrado();
        cuadro.lado = 10;
        cuadro.calcularArea();

        var circulo = new Circulo();
        circulo.radio = 9.65;
        circulo.calcularArea();
    }
}