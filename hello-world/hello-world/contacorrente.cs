namespace countbank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numero_conta;
        public string nome_agencia;
        public double saldo;

        // Metodo de saque (Boa prática: sempre usar nomeclatura como verbo)
        public bool Sacar(double valor)
        {
            // Condição caso o valor for menor, ele retorna como false
            if (saldo < valor)
            {
                return false;
            }
            // Condição caso o valor for maior, ele retorna como true
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }
    }
}