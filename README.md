# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de projeto
Para este desafio utilizei os conhecimentos adquiridos na trilha .NET da DIO, durante a realização do *bootcamp* Randstad - Backend com .NET, que estou realizando a fim de consolidar meus conhecimentos na referida linguagem.

## Contexto
Imaginando que fui contratada para construir um sistema de hospedagem que será usado para realizar uma reserva em um hotel. Utilizarei as classes Pessoa, Suíte e Reserva.

O programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor total pago em diárias, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao tentar passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, e o método CalcularValorTotalDiarias deverá retornar o valor total a ser pago pelas diárias (Dias reservados x valor da diária).
3. Caso seja feita uma reserva para a quantidade de dias maior ou igual a 10, deverá ser concedido um desconto de 10% no valor da diária.

![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

## Solução
O código foi disponibilizado pelo expert da DIO de maneira incompleta, então dei continuidade no desenvolvimento, obedecendo as regras descritas acima, e consegui obter um programa funcional.