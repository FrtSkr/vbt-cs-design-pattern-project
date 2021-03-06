using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VbtStaj2022DesignPattern
{
    public class Interpret
    {
        public interface Expression
        {
            bool Interpret(string content);
        }
        public class CheckExpression : Expression
        {
            private string _word;
            public CheckExpression(string word)
            {
                _word = word;
            }
            public bool Interpret(string content)
            {
                return content.ToLower().Contains(_word.ToLower());
            }
        }
        public class OrExpression : Expression
        {
            private Expression _exp1;
            private Expression _exp2;
            public OrExpression(Expression exp1, Expression exp2)
            {
                _exp1 = exp1;
                _exp2 = exp2;
            }
            public bool Interpret(string content)
            {
                return (_exp1.Interpret(content) || _exp2.Interpret(content));
            }
        }
        public class AndExpression : Expression
        {
            private Expression _exp1;
            private Expression _exp2;
            public AndExpression(Expression exp1, Expression exp2)
            {
                _exp1 = exp1;
                _exp2 = exp2;
            }

            public bool Interpret(string content)
            {
                return (_exp1.Interpret(content) && _exp2.Interpret(content));
            }
        }

        public class And3Expression : Expression
        {
            private Expression _exp1;
            private Expression _exp2;
            private Expression _exp3;
            public And3Expression(Expression exp1, Expression exp2, Expression exp3)
            {
                _exp1 = exp1;
                _exp2 = exp2;
                _exp3 = exp3;
            }

            public bool Interpret(string content)
            {
                return (_exp1.Interpret(content) && _exp2.Interpret(content) && _exp3.Interpret(content));
            }
        }

        public class InterpretPattern
        {
            public static Expression getMaleExpression()
            {
                Expression futbol = new CheckExpression("futbol");
                Expression araba = new CheckExpression("araba");
                return new OrExpression(futbol, araba);
            }
            public static List<Expression> getFemaleExpression()
            {
                Expression anne = new CheckExpression("anne");
                Expression bebe = new CheckExpression("bebe");
                Expression s??rt = new CheckExpression("s??rt");
                Expression araba = new CheckExpression("araba");
                Expression ??iz = new CheckExpression("??iz");
                Expression g??zellik = new CheckExpression("g??zellik");
                Expression makyaj = new CheckExpression("makyaj");

                List<Expression> list = new();
                list.Add(new OrExpression(anne, bebe));
                list.Add(new AndExpression(s??rt, araba));
                list.Add(new AndExpression(??iz, araba));
                list.Add(new OrExpression(g??zellik, makyaj));
                list.Add(new And3Expression(g??zellik, makyaj, ??iz));

                return list;
            }
        }
    }
}
