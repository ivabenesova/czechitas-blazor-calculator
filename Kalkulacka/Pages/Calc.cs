
    public class Calc
    {

        public double PrvniCislo;
        public double AktualniVysledek = 0;

        public bool JePlatnyOperator(string operace)
        {
            List<string> operators = new List<string> { "+", "-", "*", "/", "^", "X" };
            return operators.Contains(operace);
        }

        public void Secti(double druheCislo)
        {
            AktualniVysledek = AktualniVysledek + druheCislo;
        }

        public void Odecti(double druheCislo)
        {
            AktualniVysledek = AktualniVysledek - druheCislo;
        }

        public void Nasob(double druheCislo)
        {
            AktualniVysledek = AktualniVysledek * druheCislo;
        }

        public void Vydel(double druheCislo)
        {
            AktualniVysledek = Math.Round((AktualniVysledek / druheCislo), 2);
        }

        public void Mocni(double druheCislo)
        {
            AktualniVysledek = Math.Pow(AktualniVysledek,druheCislo);
        }

        public double VratAktualniVysledek()
        {
            return AktualniVysledek;
        }
    }