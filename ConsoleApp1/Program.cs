// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

int coin1 = 1;
int coin2 = coin1*5;
int coin3 = coin1*10;

string amount = Console.ReadLine();
int amountNum = Convert.ToInt32(amount);
int amountThree = amountNum / coin3 ;

int amountTwo = amountNum % coin3 / coin2;
int amountOne = amountNum % coin3 % coin2 / coin1;
Console.Write($"it takes {amountThree} tens \n" +
    $"{amountTwo} fives \n" +
    $"{amountOne} ones"
    );
