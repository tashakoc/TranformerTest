
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeworkMenu.Game;

namespace HomeworkMenu
{
    class RSPGame
    {
        static public void StartGame()
        {
            var game = new Game();
            game.Start();
        }
    }
    public class Game
    {
        public void Start()
        {
            var rules = new GameRules();
            rules.Create();
            //rules.Describe();
            Console.WriteLine("Enter start to play game");
            string input = Console.ReadLine();
            if (input == "start")
            {
                int compWins = 0;
                int userWins = 0;
                var rnd = new Random();
                do
                {
                    Console.WriteLine("Enter element or command");
                    Console.WriteLine("Command : show_rule | stop | show all positive opponent ");
                    Console.WriteLine($"Elements : Shocolate | Papper | Rock | Scissors | Limonade | Turn_screw | Fier");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "show all positive opponent":
                            Console.WriteLine("For which element?");
                            var element = Console.ReadLine();
                            break;
                        case "show_rule":
                            Console.WriteLine("For which element?");
                            var el = Console.ReadLine();
                            Element gameEl = (Element)Enum.Parse(typeof(Element), el);
                            ElementNode node = rules.Find(gameEl);
                            if (node != null)
                            {
                                Console.WriteLine($"{gameEl} wins at {node.WinsAt.Value} and loses at {node.LosesAt.Value}");
                            }
                            else
                            {
                                Console.WriteLine("No rules for this element");
                            }
                            break;
                        case "stop":
                            Console.WriteLine($"Total score: comp has {compWins} wins, user has {userWins} wins");
                            break;
                        default:
                            string[] names = Enum.GetNames(typeof(Element));
                            int idx = rnd.Next(0, names.Length - 1);
                            Element compPlayerEl = (Element)Enum.Parse(typeof(Element), names[idx]);
                            Element userPlayerEl = (Element)Enum.Parse(typeof(Element), input);
                            ElementNode compRule = rules.Find(compPlayerEl);
                            ElementNode userRule = rules.Find(userPlayerEl);
                            if (compRule.WinsAt == userRule)
                            {
                                compWins++;
                                Console.WriteLine($"I won with {names[idx]}");
                            }
                            else if (compRule.LosesAt == userRule)
                            {
                                userWins++;
                                Console.WriteLine($"You won over my {names[idx]}");
                            }
                            else
                            {
                                Console.WriteLine($"Tie! I chose {names[idx]}");
                            }
                            break;
                    }
                }
                while (input != "stop");
            }

        }

        public enum Element
        {
            Shocolate, Papper, Rock, Scissors, Limonade, Turn_screw, Fier
        }
    }

    public class GameRules
    {
        ElementNode head;

        //public void Describe()
        //{
        //    Console.WriteLine("Правила игры");
        //    ElementNode current = head;
        //    bool started = false;
        //    while (current != head || !started)
        //    {
        //        started = true;
        //        Console.WriteLine($"{current.Value} wins at {current.WinsAt.Value}");
        //        current = current.WinsAt;
        //    }
        //}

        public void Create()
        {
            Element[] elems = { Element.Shocolate, Element.Papper, Element.Rock, Element.Scissors, Element.Limonade, Element.Turn_screw, Element.Fier };
            ElementNode[] elemNodes = new ElementNode[elems.Length];
            for (int i = 0; i < elems.Length; i++)
            {
                elemNodes[i] = new ElementNode();
                elemNodes[i].Value = elems[i];
            }

            for (int i = 0; i < elemNodes.Length; i++)
            {
                elemNodes[i].WinsAt = elemNodes[(i + 1) % elems.Length];
                elemNodes[i].LosesAt = elemNodes[i == 0 ? elems.Length - 1 : i - 1];
            }

            head = elemNodes[0];
        }

        public ElementNode Find(Element gameEl)
        {
            ElementNode current = head;
            bool started = false;
            bool found = false;
            while (current != head || !started)
            {
                started = true;
                if (current.Value == gameEl)
                {
                    found = true;
                    break;
                }
                current = current.WinsAt;
            }
            return found ? current : null;
        }
    }

    public class ElementNode
    {
        public Element Value { get; set; }
        public ElementNode LosesAt { get; set; }
        public ElementNode WinsAt { get; set; }
    }
}
