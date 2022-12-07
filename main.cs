using System;
/*Construa um algoritmo que leia as informações de: horas trabalhadas (HT), valor da hora trabalhada (VH). Calcule e apresente o salário líquido do empregado, baseado nas tabelas abaixo. 
OBS: Salário Líquido = Salário Bruto – INSS – Imposto de Renda 
Salário Bruto = Horas trabalhadas * Valor da hora trabalhada 
INSS = 11% do salário líquido(BRUTO) 
Imposto de Renda  após descontar o INSS usar esse valor e ler a alíquota do imposto de renda e parcela a deduzir na tabela abaixo 
 */
class Program {
  public static void Main (string[] args) {
    string op;
    Double HT, VH, SL, SB, INSS, SI, IR, AL, VD;
    do{
    Console.Write ("Digite as horas trabalhadas: "); 
    HT =double.Parse(Console.ReadLine()); 
  Console.Write ("Digite o valor da hora trabalhada: "); 
    VH =double.Parse(Console.ReadLine()); 
    SB=HT*VH;
    INSS=((11*SB)/100);
    SI=SB-INSS;

    if (SI<900)
      {
        AL=0;
        VD=0;
        IR=AL*SI-VD;
        SL=SI-IR;
        Console.WriteLine("O salário líquido é de: R${0:F0}",SL);
      }
    else
    if (SI>=900 && SI<=1800)
      {
        AL=(15*SB)/100;
        VD=135;
        IR=(AL*SI)-VD;
        SL=SI-IR;
        Console.WriteLine("O salário líquido é de: R${0:F0}",SL);
      }
  
    if (SI>1800)
      {
        AL=(27.5*SB)/100;
        VD=260;
        IR=(AL*SI)-VD;
        SL=SI-IR;
        Console.WriteLine("O salário líquido é de: R${0:F0}",SL);
      }
     Console.WriteLine("Calcular novo salário?");
    Console.WriteLine("Digite: S ou N");
    op = Console.ReadLine().ToUpper(); 
     switch(op)
      {
        case "N":
        Console.WriteLine("Fim!");
         break;
        case "S":
         break;
      }
  }while(op=="S");
                       
  }
}