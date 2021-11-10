using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GoosebumpsReader
{
    class PlotA
    {
        public static void SideStory()
        {
            Console.WriteLine(@"“Let’s go on the rides first!” you say. “That roller coaster looked awesome!”
                              “Okay,” Patty agrees. “Over this way!” she yells as she charges over to it.
                              When you reach the rides, you can only stare in amazement. These are the most fantastic rides you’ve ever seen. The towering roller coaster ... 
the soaring speedboats ... the twisty slides! Every one is in motion. Whizzing, whirling, doing loop-the-loops. And they’re all empty! No riders. No people in line!
                               “Cool!” Patty exclaims. “We have the whole place to ourselves.”
                               Brad’s face turns a little green as his gaze swings from the Supersonic Space Coaster to the Doom Slide. 
“Do you think they have rides that don’t go upside down?” he asks.
                               “Come on! Let’s check out the coaster!” Patty calls to you and Brad. Then they run off to its starting gate.
                               You stop and crane your neck to gaze up at the coaster’s first hill. And you gasp!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@"The tracks stretch up so high that they seem to touch the clouds. Your gaze follows one of the cars speeding around a sharp curve. 
It looks like the space shuttle. You notice that it has a safety harness that locks over your body — you’ve seen those before. They keep you in when the ride turns upside down. 
You didn’t want to admit it before, but, like Brad, riding upside down is not your favorite thing.
Still, the coaster does look amazing — one part enters a tunnel — and you can see that the cars go fast. Really Fast!
You’re just about to walk through the Space Coaster gate when you hear spooky organ music coming from behind you. You turn around. 
Looming in the distance is a dark and creepy haunted house.
You gaze down at your map. It’s called the House of Horrors. Hmmm. You love haunted houses. And this one really looks scary.
Now you’re not sure what to do. You won’t have time for everything. The coaster or the haunted house? Decide now.");
            Console.ReadLine();
            Console.Clear();
            static void PlotSwitch()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                string prompt = @"
                        88888888ba,    88888888888  ,ad8888ba,   88  88888888ba,    88888888888  
                        88        8b   88          d8        8b  88  88        8b   88           
                        88         8b  88         d8             88  88         8b  88           
                        88         88  88aaaaa    88             88  88         88  88aaaaa
                        88         88  88         88             88  88         88  88 
                        88         8P  88         Y8,            88  88         8P  88
                        88        88   Y8          .a8       de  88  88       a8P   88
                        88888888Y      88888888888    Y8888Ya    88  88888888Y      88888888888  

                                           What would you like to do?
                                    (Use arrow keys and Enter to select.)";
                string[] options = { "Join Patty and Brad on Space Mountain", "Go to House of Horrors alone..." };
                Menu PlotChoose = new Menu(prompt, options);
                int selectedIndex = PlotChoose.Run();
                switch (selectedIndex)
                {
                    case 0:
                        SpaceCoaster();
                        ReadKey();
                        Clear();
                        break;
                    case 1:
                        HouseOfHorrors();
                        ReadKey();
                        Clear();
                        break;
                }
                PlotSwitch();
                ReadKey();
                Clear();
                static void HouseOfHorrors()
                {

                }
                static void SpaceCoaster()
                {
                    Console.WriteLine(@"“Hey, wait up!” you yell to Brad and Patty as you sprint through the Space Coaster gate.
They both ignore you and charge straight ahead. You follow them into a narrow tunnel that leads to the boarding area.
You gaze down at the floor. Black rubber. It makes you walk with a strange bounce.
Every few feet there is a round porthole window. When you glance out one, you see astronauts planting flags on the moon. You peer out another. 
Now they’re seated in their capsule. This is amazing, you think. The figures look real. Totally real.
After a long climb, you and Patty and Brad finally arrive at the loading area.
A sleek bullet-shaped capsule whooshes up and stops right beside you. It has three sections. Brad climbs defiantly into the last section. You leap into the front. 
Patty’s left with the middle section.
And suddenly you’re trapped!");
                    ReadKey();
                    Clear();
                    Console.WriteLine(@"Steel bars plunge down from above and drop across your lap and chest, pinning you in place.
You can’t move at all. Even your head is held by superstrong headphones that clamp over your ears. A voice comes through them announcing: “Five, four, three, two, one, BLAST OFF!”
You hear a huge bang. Smoke and fireworks fill the air as your car starts up the first big hill. Your head presses back against the seat as you climb higher and higher. 
That first hill is endless, but the view is awesome. From the top, you can see the midway, the haunted house, and a shadowy swamp. You can’t believe how big the carnival is!
“Neat!” Patty yells. “There’s AHHHH —”
Whatever she was going to say turns into a wild scream as the rocket plunges down the other side of the hill. The wind whips at your face.
You are pressed back so hard, you feel like a pancake. Everything passes in a fantastic blur.
As your car shoots up to the top of the next hill, you’re laughing and screaming at the same time. This is great, you think! But then you make a big mistake");
                    ReadKey();
                    Clear();
                    Console.WriteLine(@"You close your eyes. When you open them, your car lunges forward with a burst of speed — and you loop-the-loop. 
Your mouth drops open to scream, but no sound comes out.
Now your car starts to plunge downward — like an elevator out of control. Your heart pounds in your chest. This is the fastest and best roller coaster you’ve ever been on!
As you near the bottom, you slow down. You begin to catch your breath. And then you see what’s up ahead. A huge black hole — a tunnel!
As you shoot toward the open mouth of the tunnel, you begin to scream again. The door of the tunnel is about to close!
Snap! The door comes crashing down — behind your car. You breathe out a long sigh. But now you’re in a tunnel so dark that you can’t see a thing.
Scary! But not nearly as scary as what happens next.");
                    ReadKey();
                    Clear();
                    Console.WriteLine(@"The ride stops.
Dead.
You are sitting in the dark.
Nothing is moving.
“Patty! Brad!” you call.
Silence.
Why don’t they answer? They have to be there.
You try to twist around. But you’re locked in your harness and clamped in your headrest.
Blinking in the dim light, your eyes dart to the left. Then to the right. You spot dozens of empty space rockets lining the walls. 
They seem to come in sections, making longer and shorter space rockets.
Your mind starts working feverishly. Did your section detach from Patty and Brad’s section?
Suddenly, the silence is shattered. Your seat lock grinds open, and you are released from your harness. You quickly spin around. 
Patty’s and Brad’s cars have disappeared! If this is all part of the ride, maybe you should hop out. 
But if the ride is broken, maybe you should wait for help.");
                    ReadKey();
                    Clear();
                    static void PlotSwitch2()
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        string prompt = @"
                        88888888ba,    88888888888  ,ad8888ba,   88  88888888ba,    88888888888  
                        88        8b   88          d8        8b  88  88        8b   88           
                        88         8b  88         d8             88  88         8b  88           
                        88         88  88aaaaa    88             88  88         88  88aaaaa
                        88         88  88         88             88  88         88  88 
                        88         8P  88         Y8,            88  88         8P  88
                        88        88   Y8          .a8       de  88  88       a8P   88
                        88888888Y      88888888888    Y8888Ya    88  88888888Y      88888888888  

                                           What would you like to do?
                                    (Use arrow keys and Enter to select.)";
                        string[] options = { "Wait For Help...", "Hop out of car..." };
                        Menu PlotChoose = new Menu(prompt, options);
                        int selectedIndex = PlotChoose.Run();
                        switch (selectedIndex)
                        {
                            case 0:
                                Choices.WaitForHelp();
                                ReadKey();
                                Clear();
                                break;
                            case 1:
                                Choices.LeaveCar();
                                ReadKey();
                                Clear();
                                break;
                        }
                        PlotSwitches.PlotSwitch2();
                        ReadKey();
                        Clear();
                        
                        
                    }
                }
            }
        }
    }
}
