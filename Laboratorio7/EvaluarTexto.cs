using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    public class EvaluarTexto
    {
        static bool Apertura(char simbolo)
        {
            return simbolo == '(' || simbolo == '[' || simbolo == '{';
        }

        static bool Cierre(char simbolo)
        {
            return simbolo == ')' || simbolo == ']' || simbolo == '}';
        }

        static bool Completo(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '[' && cierre == ']') ||
                   (apertura == '{' && cierre == '}');
        }

        public bool Balanceado(string texto)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char simbolo in texto)
            {
                if (Apertura(simbolo))
                {
                    stack.Push(simbolo);
                }
                else if (Cierre(simbolo))
                {
                    if (stack.Count == 0 || !Completo(stack.Pop(), simbolo))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
