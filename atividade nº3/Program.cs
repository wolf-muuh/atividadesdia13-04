// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

Console.WriteLine($"Digite o nome do produto");
string prod = Console.ReadLine();

Console.WriteLine($"Digite a quantidade do produto:");
int qntProd = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o preço do produto: ");
float precoProd = float.Parse(Console.ReadLine());

if (qntProd > 0 && qntProd <=5){
    Console.WriteLine(@$"
    Produto adquirido: {prod}
    Quantidade adquirida: {qntProd}
    Valor unitário: {precoProd}
    Desconto de 2%
    Valor total pago: {qntProd*precoProd - precoProd*2/100} 
    ");
    
}
else if (qntProd > 5 && qntProd <=10){
    Console.WriteLine(@$"
    Produto adquirido: {prod}
    Quantidade adquirida: {qntProd}
    Valor unitário: {precoProd}
    Desconto de 3%
    Valor total pago: {qntProd*precoProd - precoProd*3/100} 
    ");
    
}
else{
    Console.WriteLine(@$"
    Produto adquirido: {prod}
    Quantidade adquirida: {qntProd}
    Valor unitário: {precoProd}
    Desconto de 5%
    Valor total pago: {qntProd*precoProd - precoProd*5/100} 
    ");
    
}



