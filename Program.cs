using er4.Classes;

PessoaJuridica novaPJ = new PessoaJuridica();
PessoaJuridica metodoPJ = new PessoaJuridica();
Endereco novoEndPJ = new Endereco();

novaPJ.nome = "Fulano de tal";
novaPJ.cnpj = "00.000.000/0001-00";
novaPJ.razaoSocial = "Fulano de tal S/A";
novaPJ.rendimento = 100000.0f;

novoEndPJ.logradouro  = "Rua 11 de Junho";
novoEndPJ.numero = 785;
novoEndPJ.complemento = "Prox a Ambev";
novoEndPJ.endComercial = true;

novaPJ.endereco = novoEndPJ;

Console.WriteLine($"Razao Social: {novaPJ.razaoSocial}");
Console.WriteLine($"Nome Fantasia: {novaPJ.nome}");
Console.WriteLine($"CNPJ: {novaPJ.cnpj}");

// Valida CPNJ - Fiz uma forma alternativa para o teste de CPNJ
Console.WriteLine($"CNPJ Valido: {metodoPJ.ValidarCnpj2(novaPJ.cnpj)}");

Console.WriteLine($"Rendimento: {novaPJ.rendimento}");

Console.WriteLine($"Endereco: {novaPJ.endereco.logradouro}, {novaPJ.endereco.numero}, {novaPJ.endereco.complemento}");
Console.WriteLine($"Endereco comercial: {novaPJ.endereco.endComercial}");





