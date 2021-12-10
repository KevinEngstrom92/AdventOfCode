using System;
using System.Collections;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleInput = @"[({(<(())[]>[[{[]{<()<>>
[(()[<>])]({[<{<<[]>>(
{([(<{}[<>[]}>{[]{[(<()>
(((({<>}<{<{<>}{[]{[]{}
[[<[([]))<([[{}[[()]]]
[{[{({}]{}}([{[{{{}}([]
{<[[]]>}<{[{[{[]{()[[[]
[<(<(<(<{}))><([]([]()
<{([([[(<>()){}]>(<<{{
<{([{{}}[<[[[<>{}]]]>[]]";

            var splittedInput = puzzleInput.Split("\r\n");

            Stack characterOpen = new Stack();
            int lineNum = 1;
            int sum = 0;
            foreach (var line in splittedInput)
            {
                Balance(line.Trim());
                lineNum++;
            }

            void Balance(string line)
            {
                characterOpen.Clear();
                var index = 0;
                
                while (index < line.Length || characterOpen.Count > 0)
                {
                    if (index == line.Length)
                    {
                        characterOpen.Clear();
                        continue;
                    }
                    var sym = line[index];

                    if (sym == '(' || sym == '[' || sym == '{' || sym == '<')
                    {
                        characterOpen.Push(sym);
                    }
                    else if (sym == ')' || sym == ']' || sym == '}' || sym == '>')
                    {
                        var expected = characterOpen.Pop();
                        var ch = GetOpposit((char)sym);
                        if ((char)ch == (char)32)
                            continue;
                        if ((char)expected != (char)ch)
                        {
                            sum += SwitchValue((char)sym);
                            var shouldBe = GetFinal((char)expected);
                            Console.WriteLine("Expected " + shouldBe + " instead got " + (char)sym);
                        }
                    }
                    index++;
                }


                Console.WriteLine("\nSum :\t" + sum);
            }

            int SwitchValue(char ch)
            {

                switch (ch)
                {
                    case ')':
                        return 3;
                        break;
                    case ']':
                        return 57;
                        break;
                    case '}':
                        return 1197;
                        break;
                    case '>':
                        return 25137;
                        break;
                    default:
                        return 0;
                        break;

                }
            }
        }

        private static object GetOpposit(char expected)
        {
            switch (expected)
            {
                case ')':
                    return '(';
                    break;
                case ']':
                    return '[';
                    break;
                case '}':
                    return '{';
                    break;
                case '>':
                    return '<';
                    break;
                default:
                    return ' ';
                    break;

            }
        }

        private static object GetFinal(char expected)
        {
            switch (expected)
            {
                case '(':
                    return ')';
                    break;
                case '[':
                    return ']';
                    break;
                case '{':
                    return '}';
                    break;
                case '<':
                    return '>';
                    break;
                default:
                    return ' ';
                    break;

            }
        }

    }
}
