namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string _modelo;
        public string _imei;
        public int _memoria;

        public Smartphone(string numero, string modelo, string IMEI, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = IMEI;
            _memoria = memoria;
        }

        public Smartphone()
        {
            
        }
        public string Numero { get; set; }

        private string Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = value;
            }
        }

        private string IMEI
        {
            get
            {
                return _imei;
            }
            set
            {
                _imei = value;
            }
        }

        private int Memoria
        {
            get
            {
                return _memoria;
            }
            set
            {
                _memoria = value;
            }
        }



        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}