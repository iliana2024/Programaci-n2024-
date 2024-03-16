public class superficieFrontal
{
    private double alto;
    private double largo;

    // Constructor
    public superficieFrontal(double alto, double largo)
    {
        this.alto = alto;
        this.largo = largo;
    }

    // Método para calcular la superficie frontal
    public double calcularSuperficieFrontal()
    {
        return alto * largo;
    }

    // Getter para el miembro variable SuperficieFrontal
    public double getSuperficieFrontal()
    {
        return calcularSuperficieFrontal();
    }

    // Getters para alto y largo (opcional)
    public double getAlto()
    {
        return alto;
    }

    public double getLargo()
    {
        return largo;
    }
}