namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
                Console.WriteLine("Hóspedes cadastrados com sucesso.");
            }
            else
            {
                throw new Exception($"A suíte selecionada não comporta essa quantidade de hóspedes. Capacidade máxima: {Suite.Capacidade}");              
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
            Console.WriteLine("Suíte cadastrada com sucesso.");
        }

        public int ObterQuantidadeHospedes()
        {            
            return Hospedes.Count();
        }

        public decimal CalcularValorTotalDiarias()
        {            
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor * 0.9M;
            }

            return valor;
        }
    }
}