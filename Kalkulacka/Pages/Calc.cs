
    public class Calc
    {

        public double PrvniCislo;
        public double AktualniVysledek = 0;

        public bool JePlatnyOperator(string operace)
        {
            List<string> operators = new List<string> { "+", "-", "*", "/", "^","√", "X" };
            return operators.Contains(operace);
        }

        public void Secti(double druheCislo)
        {
            AktualniVysledek = Math.Round(AktualniVysledek + druheCislo);
        }

        public void Odecti(double druheCislo)
        {
            AktualniVysledek = Math.Round(AktualniVysledek - druheCislo,5);
        }

        public void Nasob(double druheCislo)
        {
            AktualniVysledek = Math.Round(AktualniVysledek * druheCislo,5);
        }

        public void Vydel(double druheCislo)
        {
            AktualniVysledek = Math.Round((AktualniVysledek / druheCislo), 5);
        }

        public void Mocni(double druheCislo)
        {
            AktualniVysledek = Math.Round(Math.Pow(AktualniVysledek,druheCislo),5);
        }

        public void Odmocni()
        {
            AktualniVysledek = Math.Round(Math.Sqrt(AktualniVysledek),5);
        }

        public double VratAktualniVysledek()
        {
            return AktualniVysledek;
        }
    }