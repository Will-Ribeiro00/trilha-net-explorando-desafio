using System.Text;
using Projeto_Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = [];

Pessoa p1 = new(nome: "Leonardo", sobrenome: "Buta");
Pessoa p2 = new(nome: "William", sobrenome: "Ribeiro");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new(tipoSuite: "Premium", capacidade: 3, valorDiario: 30);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
