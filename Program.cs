using System.Text;
using DesafioProjetoHospedagem.Models;
using System.Globalization;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome: "Maria da Silva");
Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome: "José da Silva");
Pessoa p3 = new Pessoa(nome: "Hóspede 3", sobrenome: "Filho da Silva");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("F2", CultureInfo.InvariantCulture)}");

reserva.ListarHospedes();