/*
A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

Write a function:

class Solution { public int solution(int N); }

that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.

For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..2,147,483,647].
*/

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        // representação binária de um inteiro em formato de string;
        string b = Convert.ToString(N, 2);
        
        // remove os zeros excedentes da esquerda e direita da string
        b = b.Trim('0');

        // variáveis para contagem
        int conta0 = 0, gap = 0;

        // loop onde "i" recebe um caractere por vez da string "b"
        foreach (char i in b){
            // se encontrar '0', incremente o contador
            if (i == '0'){
                conta0 ++;
            }
            // se encontrar algo diferente de '0', zerar o contador
            else{
                // se o contador for maior que o gap anterior, gap recebe o contador
                if (conta0 > gap){
                    gap = conta0;
                }
                conta0 = 0;
            }
        }
        return gap;
    }
}
