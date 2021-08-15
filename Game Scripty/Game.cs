using System;

namespace Scripty
{
    public class Game
    {
        public static void Start()
        {
            //PrintSky();
            string say = "\"My name is Scripty!\"";
            Console.WriteLine($"  ,,,, \n (o.o) {say} \n/(___)\\\n  l.l.");
            //PrintTerrain();
            Console.WriteLine("Напиши количество шагов:");
            int steps = Convert.ToInt32(Console.ReadLine());
            Run(steps);
        }

        private static void PrintSky(int skyHeight)
        {
            for (int i = 0; i < skyHeight; i++)
            {
                Console.WriteLine();
            }
        }

        private static void PrintSky()
        {
            Console.Write(" \n \n \n \n");
        }

        private static void PrintTerrain(int terrainLenght)
        {
            string terrain = "";
            for (int i = 0; i < terrainLenght; i++)
            {
                terrain = terrain + "█";
            }


            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(terrain);
                Console.ResetColor();
                terrain = terrain.Remove(terrain.Length / 2, 2);
                terrain = " " + terrain;
            }


            //▀▄█▌▐░▒▓■▬
        }
        private static void PrintTerrain()
        {
            string terraint = "██████████"; // 10
            Console.WriteLine(terraint + terraint + terraint + terraint);
        }

        private static void Run(int stepsCount)
        {
            string horizontal = "";

            int countSteps = 0;
            bool FacingDirection = true;
            bool checkWay = true;

            int randomWayFront = 0;
            int randomWayBack = 0;

            int intervalFrame = 0;

            int animFrame = 0;
            for (animFrame = 0; animFrame < 6; animFrame++)
            {
                if (animFrame == 5)
                { animFrame = 0; }
                

                Console.Clear();

                //PrintSky();

                if (FacingDirection)
                {
                    char _ = '}';
                    switch (animFrame)
                    {
                        case 0:
                            Console.WriteLine($"{horizontal}   ,,,:\n{horizontal}  (o.o)\n{horizontal}Г(___)v\n{horizontal} .-' \\.");
                            break;
                        case 1:
                            Console.WriteLine($"{horizontal}   ,,:;\n{horizontal}  (O.o)\n{horizontal}<(___)V\n{horizontal} .> 1.");
                            break;
                        case 2:
                            Console.WriteLine($"{horizontal}   ,;;,\n{horizontal}  (0.O)\n{horizontal}/(___)i.\n{horizontal}  \\.{_}");
                            break;
                        case 3:
                            Console.WriteLine($"{horizontal}   .,,,\n{horizontal}  (o.0)\n{horizontal}1(___)l\n{horizontal}  1.-'");
                            break;
                        case 4:
                            Console.WriteLine($"{horizontal}   ,,,,\n{horizontal}  (o.o)\n{horizontal}<(___)\\\n{horizontal}  {_}.>");
                            break;
                    }
                }
                else
                {
                    char _ = '{';
                    switch (animFrame)
                    {
                        case 0:
                            Console.WriteLine($"{horizontal}  :...\n{horizontal}  (o.o)\n{horizontal}  v(___)7\n{horizontal}  ./ '-.");
                            break;
                        case 1:
                            Console.WriteLine($"{horizontal}  ;:..\n{horizontal}  (o.O)\n{horizontal}  V(___)>\n{horizontal}   .j <.");
                            break;
                        case 2:
                            Console.WriteLine($"{horizontal}  .::.\n{horizontal}  (O.0)\n{horizontal} .J(___)\\\n{horizontal}    {_}./");
                            break;
                        case 3:
                            Console.WriteLine($"{horizontal}  ...,\n{horizontal}  (0.o)\n{horizontal}  j(___)l\n{horizontal}   '-.l");
                            break;
                        case 4:
                            Console.WriteLine($"{horizontal}  ....\n{horizontal}  (o.o)\n{horizontal}  /(___)>\n{horizontal}    <.{_}");
                            break;
                    }
                }
                //PrintTerrain(52);

                if (checkWay)
                {
                    Random r = new Random();
                    randomWayFront = r.Next(1, stepsCount);
                    randomWayFront = stepsCount - randomWayFront;
                    randomWayBack = r.Next(1, randomWayFront);

                    intervalFrame = r.Next(25, 150);
                    checkWay = false;
                }

                System.Threading.Thread.Sleep(intervalFrame);



                if (countSteps <= randomWayFront && FacingDirection)
                {
                    countSteps++;
                    horizontal = horizontal + " ";

                }
                else
                {
                    FacingDirection = false;
                    countSteps--;
                    horizontal = horizontal.Remove(0, 1);
                    if (countSteps == randomWayBack)
                    {
                        FacingDirection = true;
                        checkWay = true;
                    }
                }
            }
        }

        public static void Animations()
        {
            //IDLE
            Console.WriteLine("IDLE");
            Console.WriteLine("  ,,,,\n (o.o) \n/(___)\\\n  l.l.");// right
            Console.WriteLine(" .... \n (o.o) \n/(___)\\\n .1.1"); // left
            
            //CROUCH
            Console.WriteLine("CROUCH");
            Console.WriteLine("  ,,,,\n (o.o)\n<(___)>\n ~'~'");    // right
            Console.WriteLine(" .... \n (o.o) \n<(___)>\n  '~'~");    // left
            
            //JUMP
            Console.WriteLine("JUMP");
            Console.WriteLine("  ,,,,\n (o.o)\n\\(___)/\n .>.>");   // right
            Console.WriteLine(" .... \n (o.o)\n\\(___)/\n  <.<.");   // left
            
            //DEAD
            Console.WriteLine("DEAD");
            Console.WriteLine("  ,,,,\n (x.x)\n-(___)-\n  l.l.");   // right
            Console.WriteLine(" .... \n (x.x)\n-(___)-\n .1.1");   // left

            Console.WriteLine("");
        }

    }
}
