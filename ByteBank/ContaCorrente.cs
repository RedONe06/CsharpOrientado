using bytebank.Titular;
namespace bytebank
{
    public class ContaCorrente
    {

        //para adicionar uma propriedade = prop + tab + tab
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        private double saldo;
        public Cliente Cliente { get; set; }

        public bool sacar(double valor)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public bool depositar(double valor)
        {
            if (valor >= 0)
            {
                saldo += valor;
                return true;
            } else
            {
                Console.WriteLine("Valor inválido para depósito.");
                return false;
            }
        }

        public bool transferir(double valor, ContaCorrente destino)
        {
            bool saque = sacar(valor);
            if (saque)
            {
                destino.saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string informacoesDaConta()
        {
            string info = $"Titular da conta: {this.cliente.nome}" +
                $"\nConta: {this.conta}" +
                $"\nNumero da Agência: {this.numeroAgencia}" +
                $"\nNome da agência: {this.nomeAgencia}" +
                $"\nSaldo: {this.saldo}";
            return info;
        }

        //tratar como uma classe com propriedades
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }
    }
}