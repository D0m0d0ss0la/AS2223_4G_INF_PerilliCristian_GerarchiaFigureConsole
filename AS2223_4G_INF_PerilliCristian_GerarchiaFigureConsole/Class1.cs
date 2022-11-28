
namespace AS2223_4G_INF_PerilliCristian_GerarchiaFigureConsole
{
    internal class figure
    {
        static protected string nome;
        static protected double area;
        static protected double perimetro;

        public void Figura(string nomeFigura)
        {
            nome = nomeFigura;
        }

        public double Area()
        {
            return area;
        }
        public double Perimetro()
        {
            return perimetro;
        }

    }

    class quadrato : figure
    {
        int lato;
        public void Quadrato(int lato)
        {
            if (nome == "quadrato")
            {
                this.lato = lato;
                Area(); Perimetro();
            }
        }

        public void Area()
        {
            area = lato * lato;
        }

        public void Perimetro()
        {
            perimetro = lato * 4;
        }
    }

    class rettangolo : figure
    {
        int bbase;
        int altezza;
        public void Rettangolo(int bbase, int altezza)
        {
            if (nome == "rettangolo")
            {
                this.bbase = bbase;
                this.altezza = altezza;
                Area(); Perimetro();
            }
        }

        public void Area()
        {
            area = bbase * altezza;
        }

        public void Perimetro()
        {
            perimetro = (bbase * 2) + (altezza * 2);
        }
    }

    class cerchio : figure
    {
        int raggio;
        public void Cerchio(int raggio)
        {
            if (nome == "cerchio")
            {
                this.raggio = raggio;
                Area(); Perimetro();
            }
        }
        public void Area()
        {
            area = raggio * raggio * 3.14;
        }

        public void Perimetro()
        {
            perimetro = raggio * 2 * 3.14;
        }
    }
}
