
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
            double VysledekMocneni = 1;
            for (int i = 0; i < druheCislo; i++)
            {
                VysledekMocneni = VysledekMocneni * AktualniVysledek;
            }
            AktualniVysledek = VysledekMocneni;
        }

        public double VratAktualniVysledek()
        {
            return AktualniVysledek;
        }
    }