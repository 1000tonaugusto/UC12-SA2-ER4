using er4.Interfaces;

namespace er4.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        // Atributos
        public string ?cpf {get; set;}

        public string ?dataNascumento {get; set;}

        // Metodos
        public string validarDataNascimento(string dataNascimento)
        {
            DateTime dataConvertida;
            if (DateTime.TryParse(dataNascimento, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;


                // Soma a data de nascimento 6574 dias (corresponte a 18 anos)
                if (dataAtual >= dataConvertida.AddDays(6574))
                {
                    //Console.Write("De maior");
                    return "De Maior";
                } else {
                    //Console.Write("De menor");
                    return "De Menor";
                }

            } else {
                return "Data Invalida!";
            }

        }
        

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}