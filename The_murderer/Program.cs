using System;
using System.Globalization;

namespace The_murderer
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------INTRO---------------------------

            //Storyline - writes text in terminal.
            Console.WriteLine("The Murderer\n\nThe misty forest crackeled as you walked down a damp path." +
                    "\nThe sun was setting in an unsetteling way, and the darkness creeped in the distance." +
                    "\nBehind an old, decrepit tree, the overgrown path divided in to two small trails leading in furter into the forest." +
                    "\nNow you have to make a choice: \n\nLeft or Right?\n (l)     (r)\n");

            //Initializing userInput variable
            string userInput;

            //Gets user input all lowercase
            userInput = Console.ReadLine().ToLower();


            //--------------------------LEFT------------------------------

            if (userInput == "left" || userInput == "l")
            {
                //Changing color of text
                Console.ForegroundColor = ConsoleColor.Black;

                //Changing background of text
                Console.BackgroundColor = ConsoleColor.DarkYellow;

                //Changing whole background
                Console.Clear();

                //ASCII-art -- Did not work w @
                Console.WriteLine(@"
_______________ZZZ__Z____$
______________Z____ZZ___$$$
____________ZZ____ZZ___$$$$$
____________Z___ZZ____$$___$$
____________$$$$_____$$_____$$
____________$__$____$$_______$$
____________$__$___$$____#____$$ 
__________$$$$$$$$$$____###___$$ 
_________$ZZZZZZZ$$______#______$$ 
________$ZZZZZZZ$$_______________$$ 
_______$ZZZZZZZ$$_________________$$ 
______$ZZZZZZZ$$__$$$$$$$_$$$$$$$__$$ 
______$$_$|$_$$____$_$$$_$_$_$$$_$__$$ 
______$$_$|$_$$____$$$$$$$_$$$$$$$___$$ 
____$$$$$$$$$$$_____________________$$ 
___$ZZZZZZZZZZ$$$$$$$$$$$$$$$$$$$$$$$$ 
__$ZZZZZZZZZZZ$ZZZZZZZZZZZZZZZZZZZZZZ$ 
_$ZZZZZZZZZZZ$ZZZZZZZZZZZZZZZZZZZZZZZZ$ 
$ZZZZZZZZZZZ$ZZZZZZZZZZZZZZZZZZZZZZZZZZ$ 
$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ 
__$$_$__$__$___$$__$ZZZZ$___$$_$__$__$_$$ 
__$$_$__$__$___$$__$_ZZ_$___$$_$__$__$_$$ 
__$$ZZZZZZZZZZZ$$__$___#$___$$ZZZZZZZZZ$$ 
__$$_#_#_#_#_#$$_ $_ZZ_$___$$#_#_#_#_$$ 
__$$#_#_#_#_#_$$__$$$$$$___$$_#_#_#_#$$
__$$$$$$$$$$$$$$##########$$$$$$$$$$$$$"

            );

                //Storyline
                Console.WriteLine(
                       "\n\nYou choose Left.\n\nWhile walking down the small path, you notice a poor, lonely house." +
                       "\nYou look around to see if anyone's around but the only thing you can see is the shadows of the tall spruce." +
                       "\n\nSomething that feels like a finger touching your bare neck, startles you as you quickly turn around." +
                       "\nWhen the only thing you see is darkness, you look up to find heavy looking clouds." +
                       "\nIt was only a drop of water you think, as you wonder if you should enter the house:" +
                       "\n\nYes or No?\n"
                   );

                //-----------------------YES------------------------
                userInput = Console.ReadLine().ToLower();

                if (userInput == "yes")
                {
                    //colors
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Clear();

                    //storyline
                    Console.WriteLine(
                        "\nYou choose Yes.\n" +
                        "\n\nYou open the crooked door to find a narrow hallway.\nYou continue to walk in when the floorboard below you" +
                        "\ncreeks loudly and your whole body goes numb.\n\nI hope no one heard that, you think as you slowly" +
                        "\nmove your body once again.\n\nBy opening a small door you find a staircase leading down into the basement." +
                        "\nYou go down slowly, like someone could hear every movement and scream when you find a dead body lying on the wet floor." +
                        "\n\nLuckily, you take this as a warning. You find a small emergency exit and take out as fast as possible." +
                        "\nYou run until you're out of breath and take a look behind you.\nThere you see the silhouette of a massive man, holding a machete." +
                        "\n\nYou managed to escape the murderer, but what about next time?"
                        );
                }

                //------------------------NO------------------------
                else if (userInput == "no")
                {

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();

                    Console.WriteLine(
                        "\n\nYou choose No.\n\nInstead of entering, you walk beside the house and look inside a window." +
                        "\n\nYou see a small, dirty kitchen and what seems to be..." +
                        "\nLike a small drop of warm water, you feel something dripping down your back." +
                        "\nYou slowly turn around to find nothing but the dark forest. Instead you look up." +
                        "\nYou see a dead body laying on the edge of the tilted roof, dripping blood." +
                        "\nIn horror, you realise that the body is freshly killed since the blood is still warm." +
                        "\nSuddenly, something knocks you in the head and you blackout.\n\n"
                    );

                    Console.WriteLine("\nYou didn't manage to escape the murderer, but what about next time?");

                }



            }


            //----------------------------RIGHT-----------------------------
            else if (userInput == "right" || userInput == "r")
            {

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();

                Console.WriteLine(
                    "\n\nYou choose right.\n\nWhile walking down the small the small path, the tall spruce surrounding you casts shadows making" +
                    "\nit hard for you to follow, as the path gets more narrow for every step you take." +
                    "\nYou pause for a minute as you hear a rattle in the bushes to your left.\n\nTrying to make youself seem as invisible as possible" +
                    "\nyou ask yourself:\n\nShould I Check it out, run or be quiet?\n            (a)        (b)     (c)\n"
                );

                userInput = Console.ReadLine().ToLower();


                //-------------------CheckItOut-------------------


                //instead of 2 else if statements, switch is initiated.
                switch (userInput)
                {
                    // 2 cases gives two possible varibles for same answer.
                    case "check it out":
                    case "a":

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Clear();

                        Console.WriteLine(
                            "\nYou choose Check it out.\n\nYou slowly reach for the bushes.\n" +
                            "You twitch when a small rabbit run out of the bushes.\n\nPhew... It was only an animal, you think as you turn around to continue down the path.\n" +
                            "\nWhen you turn around you see a shadow, quickly blowing by. Your body starts shaking as the air gets cooler." +
                            "\nNow you see the shadow once more. It is moving towards you.\nQuickly you turn around and run as the shadow goes faster and faster towards you." +
                            "\n\nYou feel a choke hold against your neck. You fall down unconsious."
                        );

                        Console.WriteLine("\nYou didn't manage to escape the murderer, but what about next time?");

                        break;

                    case "run":
                    case "b":

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear();

                        Console.WriteLine(
                            "\nYou choose to Run.\n\nYou turn around and run for your life. You run behind a mossy, big rock and" +
                            "\nship for air. You feel a brush of breath streaking your neck and your body gets ice cold." +
                            "\nYou turn around and get stabbed in the chest by a massive man."
                        );

                        Console.WriteLine("\nYou didn't manage to escape the murderer, but what about next time?");

                        break;

                    case "be quiet":
                    case "c":

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();

                        Console.WriteLine(
                            "\nYou choose to be quiet.\n\nThe forest kept on wispering when you looked around.\nFar, far in front od you, you saw what seemed" +
                            "\nto be a tall silhouette of a massive man, standing completely still with a sharp machette in its hand." +
                            "\nYou run into the forest, in hope that it didn't see you and you hide in the tall grass, behind a big mossy rock.\n" +
                            "\nYou hear leaf-crushing from the other side of the rock and hold you breath. After taking a moment to listen, the footsteps carry on " +
                            "\nand you're alone again."
                        );

                        Console.WriteLine("\nYou managed to escape the murderer, but what about next time?");

                        break;

                    default:

                        Console.WriteLine("u stopid, why you no pick answer >:(");

                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
