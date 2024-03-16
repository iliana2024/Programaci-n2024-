
 class SuperficieFrontal 
{
    private double alto;
    private double largo;

    public SuperficieFrontal(double alto, double largo)
    {
        this.alto = alto;
        this.largo = largo;
    }

    public double calcularSuperficieFrontal()
    {
        return alto * largo;
    }

   
    public double getSuperficieFrontal()
    {
        return calcularSuperficieFrontal();
    }

 
    public double getAlto()
    {
        return alto;
    }

    public double getLargo()
    {
        return largo;
    }
}
