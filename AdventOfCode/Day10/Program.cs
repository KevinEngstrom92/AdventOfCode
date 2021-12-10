﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleInput = @"{{[<(<<<([{(({<>()}<[]()>)<({}{})(()<>)>){[([]()]{[]()}][<()()>{()[]}]}}[[(<[][]><{}{}>)]<[{{}()}
{<{<{[[[{[{<([[]()](()<>))>([<[]()>])}<{[[<>[]]<{}()>](<{}()>([]()))}<[{[][]}[<><>]][<()()>]>>
<<{[[<([<(<<([(){}])>(<<[]{}>(<>{})>({[]<>}{{}<>}))>)>]{[<[({<<>()>[()())}{([]())[<>[]]})([<(){}>]<<[][]>{{
{[[[<({{{[{{({<>[]}[()()])[<<>[]>(()<>)]}<{{()()}[()()]}({{}()})>}[{[(<>{}){<><>]]<(()()){{}}>}<{{<>()}[[]
[<{[{[<[{[[({(()<>)}<{[]{}}<()>])<([[]<>][[]<>])(<<>()>{(){}})>]{{(<()[]>[<>{}]){([]{})}}[{{{}{}}(<>{}
[<<<{<<[((({{[{}[]]}}[[<()[]>(<>[])]{({}{})(()[])}]){<{{()()}{{}[]}}<{[]()}>>{<[(){}]><<{}{}><
{[({[[[{<({[((<>[])([]{})){{{}<>}{(){}}}][<[{}{}]<{}()>><{{}()}<<><>]>]})>([[<[<<><>>{{}()}]<[{}
{(<(<{{(<[(((([]{})<{}[]>))(([[]()]{()<>})(({}{}){<>[]})))]{[([{<>{}}{()<>}]<[{}()]<<><>>>
{<[[[(<[{(<({[{}()]{(){}}}{{()<>}(()[])})({[{}()]{[]}})>)({{[{()()}[[][]])((<><>)<<><>>)}{
{<{(<[(<{([<[<[][]>[()[]]]<{<>()}([]())>>]([{<<>{}><{}{}>}[[[]{}]<[]{}>]]{({()[]}){({}())((){})}})){([
<[(((<{{<[[{<(<><>)<<><>>>{{[]<>}<()>}}<(<[]()>{()<>}]{([]<>)[[]{}]}>]](<{{({}<>)[[]()]}[([])]}<[<{
({[[(<{[({<{<[{}()]([]{})>(({}{})(()<>))}<(<{}[]>({}()))[({}<>)]>>}[[([[(){}]([]<>)][(<><>)({}{}}])<{[{}()]}[
[{{[(({[{{({(<()[]>{[]<>})}{[({}())]{<()[]>[{}{}]}})<(([()<>]{()()}){([]{})<[]>}){<<()<>>[<><>]>{<<>{}
{{<{[(<(({<{{<(){}>(()<>)}}[<<{}()>{{}{}}>([<>()]{<><>}]]>}(({{<{}()>([]())}{({}())}})<<{{
{{<<<[{{<[(({[<>{}][[]()]})({[<>()]<<>[]>}(<{}{}>([]<>))))[[((()())[{}{}])[<[]()>[()<>]]]{[({}{})
(({[({{<([<[{{(){}}<{}[]>}]([({}<>){<>[]}]{({}{})(()())})><{<[{}{}]{[][]}>{[{}{}]{[][]}}}{<[()]<{}{}>>
[{[({<({<<({((<>()))})<{<[[]<>](<><>)>}[{<<>[]>{<>()}}([{}{}]{{}[]})]>>>})>})<[[<[{{(<({<><>}{<><>})<<(){}>>>
{(<<{(<{<[[{<<()[]>{()<>}>}{(<<>()>({}()))}]]>([<[<<{}>[<>{}]>({[]<>}(()[]))]<{{<>()}<{}{}>}
{{(<([[<[({<{{{}{}}(<><>)}<({}<>)<{}[]>>>}[[({()<>}{{}[]}){<{}[]>{{}[]}}]<[{{}()}([]())][({}{})[{
(<(<<{<[{{((<{{}()}[()]>({{}()}[[][]]))({{()[]}[<>{}]}{<()[]><()<>>}))[{[{[]()}[{}()]]([{}<>])}{<<()[
[{(<<{[([[({<[{}{}){<>{}}><[()<>]([]{})>}{<[()[]][<><>]>[{[]<>}[<>{}]]})]]{<<[<({}[])>(<<>{}>[[][]])]><([{{}{
[{([([[<{[[[<{<>[]}{()()}>((()<>))][{[{}()][[]{}]}]][{{(()<>)([][])}{({}{})(<>())}}(([{}{}]){<
<[{{({[[(([{[[{}[]]<<>()>][({}{})]}]<[<([]<>)><{()()}[()[]]>]<{(<>())<(){}>}<[{}<>][{}<>]>>>))<(((<{<
{<{{[{[{<<<{{([][])[<>]}<{{}<>}(<>())>}[<[()<>](<>[])>[[[][]]{()<>}]]>>>}<[[[{[({}())((){})]{(()()
{<{[(<{(<((({<<><>><<><>>})[[{()()}[()()]](<{}()>((){}))]))[{<[({}{})[{}[]]]([[]()])>((({}<>)[[]
[{{(<[[[{{[((<[]()>[[]<>>)[<()[]>])]({<[[]{}][{}{}]>{[[]]{<>{}}}}(<{[]{}}<<>{}>><([]<>){[]{}}>))}{[<{{[]()
{<<<(({{{{(<{{{}[]}}><[{(){}}<[]()>><<()()>({}())>>)<(({<>{}}([][]))<<()[]><{}()>>){[{<><>}[[][]]
{<[({({<<[{{{{[]{}}(()[])}<{(){}}>}<(([][]){[]{}})>}]{[{{<<><>>[[]<>]}}<[([]<>)<{}()>]{{{}{}}
{({<<[(([{(<((()[]))<[{}]>>[<({}[])[{}<>]>[{()()}<[]()>]])<((<(){}>(<>[]))<<<>><{}()>>)[<({}{}){
<<[<(((<{{{<<{<>{}}<{}()>][([]())[{}()]]>[[{()<>}<{}[]>]<(()()){<>{}}>]}}<{([{<>()}<<><>>]{{()()}}
[(<<<[(([{[<(<()()>)[{<><>}{(){}}]>{{([]())[<>{}]}{{<>[]>[{}()]}}]}]))]>[[[{<((<(<()<>>){{<>[]}<[]
[{(<[((({{([(([]{})<{}()>)<[[]{}]{{}()}>]<{{<>[]}{[]()}}({<>()}[{}{}])>)[{{<[][]><<>[]>}[<{}{}>]}<<[[][]][(
([<(<<[(({[[<<[]{}]>{[()[]](()<>)}][({{}[]}{{}{}}){{{}<>}}]]<{({<>}(()[]))[<()[]>{[]{}}]}[{<
<<[<{{(([([<[[[]{}]<[]<>>][[<><>]{()()}]>]((({{}{}}(<>{})){([][])[{}()]})))<<([(<>)<[]{}>][{{}()}
(<{<([<[{[([(<[]{}>{{}})(([][]){[]{}})]<<({})[()()]>(({}[])[{}<>])>)(<[{{}{}}{{}[]}](<[]{}>[()[]])><<{{}()}
[{({{(({[{[<<[[]()]<<><>>>({()()})><[{<>()}{()<>}]<<()()><{}<>>>>]{(({<>{}}([][]})({{}[]}<<>()>))<<(<
{(<(<{{(((<({((){})[()[]]}{<{}()>{{}()}})[(<{}[]>[{}{}])([()[]]<<>()>)]>{[<[[]<>]<[]>><{{}<>}
{[[<{(<<<[{(((<>[])<{}<>>)<{[]{}}{<>{}}>)}[[{[{}{}][{}<>]}[(<>[])({}())]](<[{}{}]{()<>}>)]]([(((<>{})({}
{(<(({[([([((({}[])[()]))]([((<>())[[][]])])){{({([]())([][])}(<()()>{()[]}))}}]<{<(([{}[]](<>{}))[<[]
({<[[<<(<[(<[((){})]{[(){}][(){}]}><(({}())[<>()>){{()()}}>)(<[<()[]>(<>{})](<[]{}><(){}>)>[({[]
[<<[{{[<[<[[{[(){}]{<>[]}}[(<><>){{}{}}]]{<((){})(()[])>[[[]{}]{{}}]}]{(<{<><>}<{}<>>>)([(()[]){(){}}][
(<<<((<[<[[[[{{}()}{[]<>}]<{(){}}[[]<>}>][<[[]{}]{{}<>}>{<<><>>([]{})}]]]{{{<{<><>}[{}()]>}
{{<<{[{[<[{(({{}()})(((){})[<>{}]))[[<[]{}>[[]]]{[[]{}]{{}{}}}]})>[{([{(<>[])[<>]}]<<[[]{}][<><>]>{{{}()}({
[{{{(<{{[<{((<<>{}>[(){}])[(<>[])<[]<>>]][(({}<>)<[][]>)({[][]}{<>{}})]}({{[<>[]]([]<>)}}{(
<[([{[<<<[([(<(){}>{<>[]}){[{}[]]{[]{}}}]{({<><>})[[<>{}][[]{}]]}){<[<<>[]>[<><>]]({[]{}}{<>[]})>[
[(<(<[({<[{{({()<>})<[()<>}<(){}>>}(({[]<>}(()<>))([()()]{<>}))}<{{([]<>)<<>>}[[{}<>]<[]()>]}<<([
[[[<([[[[<<<((()<>)<[]<>>)(<{}()>[<>()]))>{((({}()))(<<>()>)){{{<><>}}<<{}<>>>}}><{{({[][]}<{}{}>)[(<><>
<<[({(<<<[{([(<>{})[{}[]]](({}[])))[<(<>[])><<()[]>[{}{}]>]}{([<[][]>{()()}][<[][]><[]<>>])}]>>>)}[{((<<([{((
{(({[{{<[(<<<<<>()><{}{}>><<{}<>>[{}<>]>>((<()<>>)(<[]{}>[[]{}]))>((((<>())[[][]]){{()()}([][])}){<[<
({{{[(({<[[<[([][])(()[])](<{}<>>{{}()))><<(<>[])<{}()>>(<(){}>[<>()])>]]([<(<{}{}><[]()>)[[<>[]](()[])
(<<[{[(({[({{{()()}(()<>)}<<<>()><<>[]>>})<{([<><>]<[]()>){<{}()>{(){}}}}>>}[{(<{[{}<>][<>{}]}([()()]({}()
({<<<<([{(([(<<>>{[]<>})][<<[]()>({}{})>])({(<{}[]>){([]<>)([]{})}}<[{[]{}}{<>{}}]>)){<{<[[]<>]([]<>)>
([{[[<((((<[[{<><>}(<>())]<(()<>){[][]}>]<[([])[<><>]](<{}{}}([]()))>>){{{[{<>{}}([]<>)]{[(){}
[{([[(({<[[{{(()[])(<>{})}<[()<>]{{}[]}>}{[<<>>[[]<>]]<[[]<>][<>()]>}]]{{[{<[]{}>((){})}<<<><>>{{}()}>]
(<({(<<({([<[{(){}}[[]()]]>[[[[]{}](<>())]]]{{({(){}}(<>{}))[[<>()]<<>{}>]}({[<>()]}{{[]<>}{[][]}})}]}){({{<[
{([(((<{<[<{<((){})[<><>]>({[]()}<<>{}>)}}((<(<>())>{<{}()>{{}[]}}))]<{(({[]<>}<[]()>))<{{()}[()[]]
([[((([<[[{<[(()())][(<>[])]>[[[[]<>]{(){}}][[(){}]{<>[]}]]}({[<{}<>>(()())]<({}<>){[]<>}>}[(<{
{([<{{{[{<[<<[<>()][<>[]]><<(){}>>>]<<({{}[]})<(()[])>>[<<[]<>>[()[]]><([][])[<>[]]>]>><[[[(<><>
<<{[<[{[[{{<[(<><>)[<>()]](<<>[]>{<>()})>{<{<>[])(<><>)><([]<>){<>()}>}}({([{}{}](<>()))<{(){}}([]
({<([({{{<{(({[]()}{<>[]})<{{}<>}[<><>]>)(<[[]]<()()>>]}>}}}){[{{<{<[[()[]]<()<>>]{{{}[]}{[]<>}}>}[{{{
([{[[{<([<([({{}<>}<()[]>)<{<><>]{{}{}}>])[[{[<>[]]{{}<>}}({{}[]}<<>()>)]]>([{({<>}{()()})({{}{}}([]<>))}][
{{[[((([{{[<{<{}()>}[(<>{})<{}()>]>({((){})([]<>)}([[]<>]{{}()}))]{[{{[]()}(())}(<<><>><<><>>
<{({[((<[<{[({<>[]}{{}{}})(({}<>)<()[]>)]({{{}()}[<>[]]}[<[]{}>[{}()]])}([{[<>()]({}[])}(<[][]>
<{[[{<<[<<<{({{}[]}[<>{}])<(<>())((){})>}<[<(){}>(<>())]>>(([<[]<>>{<>()]](<[][]>{()<>}))<([[][]]([]<>)){{()(
[[<[{[(({<<((<<>{}>[{}[]])){([<>{}]){{(){}}<(){}>>}>({<[{}<>][{}{}]><(<>{})>}[<({}{})[[]{}]>[[()()][{}]]])>}
({{<[<<[([{<<{[]()}{{}<>}>(<(){}>(<>{}))>}]<{[{{<><>}<<>[]>}(<()()><[][]})]{<[{}<>]<<>[]>>}}({{{()}(
[([(({[[<({[({()[]})([[]]{()<>})]<<{[]<>}{<>[]}>>}){{({[()[]](()<>)}({[][]}))<<[<>()]<[]<>>>[{{}<>}{()[]}
(<[<[([[{[<[[{{}[]}<<>>]{[[][]]<{}{}>}]({<()()>(<>{})}[<<>><[]{}>])><{{({}<>)[<>[]]}{[[]<>](<>())}
{[[[((([<[([(([]())({}{}))<<()<>>[(){}]>](<[<><>]{<><>}>{{{}[]}{<>()})))](({(<<>[]>)}){<<<
{<(<[<{{<<{[(<()[]>{{}<>})(<()()><[]{}>)]([{()()}<<>()>](<()[]>)}}([(<[][]>)[{{}<>}<()[]>]])>{<({<[]()>{
[[[<[({([[{({(<>[])<{}>})<<<[]{}>>{[[]{}]{[][]>}>}[{<[<>[]](()[])><[{}<>][[]()]>}]]((<{{[][]}{(){}}}(([][])
(<{<[<{({<[[[{()<>}[[][]]](([]{})[{}<>])][[<[]{}>{(){}}][<<>{}>[{}()]]]]<[{{()}(<>[])}((()<>)[{}[]])]
{[{({(<{(<(<{[<>()][()[]]}[({}{})<<><>>]><<(<>[])([]{})>])>)}(<<<([[{}{}]({})])({[[][]]<[]{}>}{[<>[]
[[[(<[{([[(([({}{})(()[])][<<>()>{[]()}])<<{<>{}}([]{})><(<>[]}<()[]>>>)({[<[]>((){})]<[{}<>][[]<>]>}{<<[][]
(<[<[(<<[<<<({{}[]}({}[])){(()<>){{}{}}}>>>[{[[<{}()><{}()>]{(<><>)<{}{}>}]([{[]<>}{<>[]}])}({{([]()){<>{}}}
[([[<<[(<[[{[((){})({}())][({}{})[()[]]]}({{()[]}}{[[]<>](<>())})]{(<[{}<>]{()()}>({<><>}((){})))}]((
{<[{([{<<(<{{{[]{}}}[([]<>)(()<>)]}<<<<>>[()<>]>{([][])(<>())}>>)<({{[()[]]{<>{})}<<[]{}>(()<>)>}
[[<[{[<{{<<(<[{}<>]{<>{}}><{<>[]}[[]<>]>)>[{[({}[]){(){}}]({<>()}[<>{}])}]>{([([{}{}][<>[]])[[{}{}]]]<{[()
{<({<{([<(<(<[(){}][()[]]><{<>()}<<>{}>>)<[{[][]}]{([][])<(){}>}>>[({(<>{})<<>{}>}{{{}<>}{[]<>}}){<
(<<(([{<[(<{({[]()}[[]{}])}([<())(<>{})]<(<>{}){<>[]}>)><{[<()<>>]{<()()>{{}<>}}}{{({}<>){
[[<[[[<({<[{[{(){}}<()()>]}([{{}{}}{()()}][([]())<<>>])])[({<<<>()><[]()>>{([]()){[]}}}){{{[{}{}]<{}>
<[(<[(<{(<{[(([]()))]<{[[][]]}{[<>[]]}>}<{<([]<>)>}{[((){})<[]()>][({}{}){{}{}}]}>>{({{<{}()>[[]{}]}[((
({(<[[([<{[([[<><>]((){})]{[[]{}]{()}})<[<[][]><{}<>>]((()[]))>]}(((((()())[[]()])({<>()}))<{[
<<({[<<[<{{[([{}[]]({}))[{{}()}{{}()}]]{[<{}{}>]<{[]}{()[]}>}}}><[{<((<>()))<{{}{}}>>(<(<>{
[(((<{[{<{<<{[[][]]{[][]}}>>{<{[[]{}][<>[]]}{([]{})({}{})}>{({{}()}<()<>>){({})[{}[])}}}}>[(<{{{(){}}}<({}[]
{<<(<{({[{<{<([]())[{}()]>[[()()]<()>)}<({[]()}<[]<>>)<{<>()}(())>>>}(([[{<>()}<<>()>]]{({()<>}
[[({<<[([{([[[<><>]([][])]<([]{})[<>[]]>][<[[]<>]((){})>])<(({()()}{{}{}}))({{()[]}([][]))[[<><>]<[]{}>])>
(<{<{[(([{[{<([][])<<>()]>{({}[])<<>>}}{<{[]<>}<[]{}>>}]{(<[{}[]]({}())><{(){}}{{}<>}>)}}][[{
<{[[<[{(((([{[<>()][<>[]]}]<<{()<>}>(({}<>))>)[[({[]()}<[][]>){({}<>){[][]}}]((<{}{}>{()()}))])[<
<<<<[<[[[(<[{(()<>){()()}}([{}{}]<[]{}>)]>[{<<<>{}>{()[]}>({()}[()[]])}((({}())([][])))])]<([([<[]
{((<({({{{<<[{<>{}}(()[])]{(<>{})([]{})}>>{{{({})[<>{}]}{<{}>}}{{<[][]>[(){}]}{{{}[]}<<>()>}}
<[{[(((({{{[<<(){}>(<><>)>{{{}[]}<[]()>)]<<([][])([][])>[[<>()][[]<>]]>}((([{}])<<{}[]><()<>
[{[{<{[{<(([<(<>[])(()<>)>([[]<>]([]()))]<({{}<>}<[][]>){<<>{}>{[]()}}>))>[([(<{[]()}{{}[]}><(()<>){[]
[{[[[(([[[(([<{}[]>][[<><>]{()<>}]){[<[][]>]({<><>}[[][]])})({{{{}<>}{(){}}}<<()>[{}()]>])]]{(<<((
(((([[{{<{[{<(()())(()[])>(({}<>){{}[]})}[<({}[])[[]()]><{{}()){<>()}>]]{[{<()<>><()()>}]{{<(
{[<[(({({<[(<{<>[]}>[{{}[]}{()[]}])[<[()[]]([]())>{[[]()]{{}()}}]]{<{<<>[]>(<><>)}>{([[]<>]{()<>})<{<>}>}}>}(
[({[{((([({(([[]<>]([]{}))<({}{})>)})(({<([]<>)([][])>}({<[]{}>[<>{}]}[<<><>>([]())])))][<<<({(){}}([]()))
[{<(<<{<({<{[({}<>)<{}{}>]{<[]{}>{<>[]}}}{{{{}()}(<><>)}({<>{}})}>{{<{{}()}<<>{}>>({{}}(()[]))}(({<>{}}[
{(({<<{[((<((<{}()><()<>>)[<()()><{}[]>])[[<[]()>(()<>)][<{}()>{()[]}]]><<{(<>{})[[]{}]}[<[]<>><{}{}>]><{<{}
{{[{(<{({(<(<([]{})([][])>[{<>}<{}()>])(({()[]}[()<>>){(()<>)<{}[]>})>[(<([]<>)([]())>(<{}<>>[()[
<[(<<[{[{[[<([{}<>]<[]<>>){[{}[]][{}[]]}>{<([]{})}<{{}{}}<<>()>>}]]}[([([{[]{}}<(){}>]{[{}{}][{}{}]})<<({}{}
{[<<[{{<<[{{[[[]<>]{<>[]}]<{{}{}}(()())>}<((<>[])<<><>>)>}<{[<[]><{}<>>]<[{}<>}{()[]}>}<([(
[<([({<<[{{{(<{}<>>({}())){[<><>][<>[]]}}<{<[]<>>{[]()})[([]{})<<>[]>]>}{{{[[][]]<{}[]>}[<[]<>>(()<>)
[((([[{<{[{{((<>[])(()<>)){{[][]}{{}{}}}}({({}<>)({}())}((<>{})[{}{}]))}]<(<((<>[])<(){}>)>
<({{({[{{<{([{()[]}(<><>)](((){})(()[])))({[<>{}]<<>[]>}[<<>[]>])}>}<[{<(<{}<>>)<{<><>}<[]>>>(([{}()]
[{{<({((<([(<[<>{}](()[])><{[]()}<<>()>>)[<(<>)(<>())>)]({({()()}[()[]])}<[[[]<>]<{}<>>](({}[]){";

            var splittedInput = puzzleInput.Split("\r\n");

            Stack characterOpen = new Stack();
            List<char> charsRemaining = new List<char>();
            int lineNum = 1;
            int sum = 0;
            decimal autoCompleteScore = 0;
            List<decimal> score = new List<decimal>();
            foreach (var line in splittedInput)
            {
                Balance(line.Trim());
                lineNum++;
                if(autoCompleteScore>0)
                Console.WriteLine(autoCompleteScore);
                autoCompleteScore = 0;
            }

            score.Sort();
            var pos = score.Count / 2;
            Console.WriteLine("GOLD WINNER\t:\t"+score[pos]);

            void Balance(string line)
            {
                characterOpen.Clear();
                var index = 0;
                bool wassSyntax = false;
                while (characterOpen.Count > 0 || index < line.Length && !wassSyntax)
                {
                    if (index == line.Length)
                    {
                        if (!wassSyntax)
                        {
                            charsRemaining.Clear();
                            foreach (var item in characterOpen)
                            {
                                charsRemaining.Add((char)item);
                            }

                            for (int i = 0; i < charsRemaining.Count; i++)
                            {
                                if (autoCompleteScore < 0)
                                {

                                }
                                var ch = GetFinal(charsRemaining[i]);
                                autoCompleteScore *= 5;
                                autoCompleteScore += SwitchValueGold((char)ch);
                            }
                            
                            score.Add(autoCompleteScore);
                            autoCompleteScore = 0;
                        }
                        characterOpen.Clear();
                        wassSyntax = false;
                        continue;
                    }
                    var sym = line[index];

                    if (sym == '(' || sym == '[' || sym == '{' || sym == '<')
                    {
                        characterOpen.Push(sym);
                    }
                    else if (sym == ')' || sym == ']' || sym == '}' || sym == '>')
                    {
                        if (characterOpen.Count == 0)
                            continue;
                        var expected = characterOpen.Pop();
                        var ch = GetOpposit((char)sym);
                        if ((char)ch == (char)32)
                            continue;
                        if ((char)expected != (char)ch)
                        {
                            sum += SwitchValue((char)sym);
                            var shouldBe = GetFinal((char)expected);
                            Console.WriteLine("Expected " + shouldBe + " instead got " + (char)sym);
                            //GOLD
                            if (characterOpen.Count > 0)
                            {
                            characterOpen.Clear();
                                index = line.Length;
                            }
                            wassSyntax = true;
                            continue;
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

            int SwitchValueGold(char ch)
            {

                switch (ch)
                {
                    case ')':
                        return 1;
                        break;
                    case ']':
                        return 2;
                        break;
                    case '}':
                        return 3;
                        break;
                    case '>':
                        return 4;
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
