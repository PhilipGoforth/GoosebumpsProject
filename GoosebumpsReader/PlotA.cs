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
                                WaitForHelp();
                                ReadKey();
                                Clear();
                                break;
                            case 1:
                                LeaveCar();
                                ReadKey();
                                Clear();
                                break;
                        }
                        PlotSwitch2();
                        ReadKey();
                        Clear();
                         void WaitForHelp()
                        {
                            Console.WriteLine(@"You decide to wait. Someone should be here soon, you think. 
But after waiting in the space shuttle for at least fifteen minutes, you’re not so sure. No one has shown up to rescue you.
A chill runs down your back. You feel as if a thousand pairs of eyes are watching you from the shadows.
Now that you’re accustomed to the darkness, you can see dozens of tracks leading in and out of the tunnel.
And then you hear a rustling sound. You freeze. You listen hard. Could it be rats — or something worse?
You draw up your knees and wrap your arms around them tightly. Then you hear a hissing sound — and you smell something odd. 
It’s kind of a sweet smell — like heavy perfume. You hold your nose because the smell is making you feel strange. Dizzy. Sick");
                            ReadKey();
                            Clear();
                        }
                        void LeaveCar()
                        {
                            Console.WriteLine(@"Your pulse pounds in your ears as you carefully lift yourself out of the car. The tunnel is dark and musty and really creepy.
Anything could be lurking in the shadows.
This must be part of the ride, you reason. And the more you think about it, the more convinced you are. You’re scared. But you have to admit, this is pretty cool.
In the distance, you spot several red lights that seem to lead to other dimly lit tunnels. You cautiously head toward one of them. Overhead something dark and slimy drips.
Splattering on the top of your head. Stinging your forehead.
As you desperately try to wipe the burning slime away, something grabs you by the knees!
Aaaah! You look down. A pair of red-rimmed eyes meet yours. It’s a dwarf with scraggly red hair and a toothless smile.
“Want me to lead you out of here, kid?” he asks. You’re about to follow the dwarf, but then you stop. 
Is he part of the ride? He looks really evil. What do you do?");
                            ReadKey();
                            Clear();
                            void PlotSwitch3()
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
                                string[] options = { "Follow dwarf...", "Not follow dwarf..." };
                                Menu PlotChoose = new Menu(prompt, options);
                                int selectedIndex = PlotChoose.Run();
                                switch (selectedIndex)
                                {
                                    case 0:
                                        FollowDwarf();
                                        ReadKey();
                                        Clear();
                                        break;
                                    case 1:
                                        NotFollowDwarf();
                                        ReadKey();
                                        Clear();
                                        break;
                                }
                            }
                            PlotSwitch3();
                            ReadKey();
                            Clear();
                            void FollowDwarf()
                            {
                                Console.WriteLine(@"“Okay, get me out of here,” you say to the dwarf. “Did you help my friends, too?”
The dwarf does not answer. He sprints off and you have to race to keep up with him. Through a confusing maze of twisting tunnels. 
You’re sure glad you have a guide.
The dwarf suddenly stops. “That way,” he says gruffly, pointing straight ahead.
Before you can blink, he vanishes in a puff of smoke! And you’re left standing in front of two doors. One red. One blue. The red one has a sign that reads: danger.
The blue one has a sign that reads: big danger.");
                                ReadKey();
                                Clear();
                                void PlotSwitch4()
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
                                    string[] options = { "Leave by the red door...", "Try the blue door..." };
                                    Menu PlotChoose = new Menu(prompt, options);
                                    int selectedIndex = PlotChoose.Run();
                                    switch (selectedIndex)
                                    {
                                        case 0:
                                            RedDoor();
                                            ReadKey();
                                            Clear();
                                            break;
                                        case 1:
                                            BlueDoor();
                                            ReadKey();
                                            Clear();
                                            break;
                                    }
                                }
                                PlotSwitch4();
                                ReadKey();
                                Clear();
                                void RedDoor()
                                {
                                    Console.WriteLine(@"You push open the red door. Another tunnel lies beyond it.
You follow its twists and turns, and you realize that you’re sloshing through cold muddy water. It grows deeper and chillier as you go.
With a cold shudder, you decide to head back — until you hear a slurping noise behind you. Whirling around, you watch in horrible fascination as giant earthworms crawl out of the mud.
Gross!
No way you’re heading back there. You clench your teeth and slog onward. Up ahead, you see a dim green light. Great! An exit.
As you reach the end of the tunnel, you hear a low growl behind you. At first you try to pretend it’s your imagination. 
But there’s no mistaking the sound of thudding footsteps. 
Getting closer. And closer. And now it’s breathing down your neck!");
                                    ReadKey();
                                    Clear();
                                    Endings.SwampMonster();
                                    ReadKey();
                                    Clear();
                                }
                                void BlueDoor()
                                {
                                    Console.WriteLine(@"You open the blue door and peer through. You’re staring down a long dark passageway. At least you think it’s long.
It’s difficult to tell. It’s pitch-black. You don’t know what to do.
“Maybe I should have picked the other door,” you say to yourself. “I’m getting out of here!”
But the blue door has locked behind you! Now you’re sure you made the wrong choice. But there’s nowhere to go but forward.
Your knees begin to tremble as you inch your way down the dark hallway.
The passage ends in a bright burst of light. And in front of you, a tall purple mountain rises hundreds of feet into the air.
You breathe out a long sigh of relief. You’re out of the dark!
You study the mountain. It looks so real! But cut into its side, you spot a doorway. Above it a brightly painted sign reads: doom slide, will you be the
ONE TO SLIDE FOREVER?");
                                    ReadKey();
                                    Clear();
                                    Console.WriteLine(@"You open the door and climb a steep ramp that curves around and around. It’s cold and dark inside. 
Halfway up the ramp, you stop. There’s another sign: WARNING! — YOU MAY BE THE ONE TO SLIDE TO YOUR DOOM!
You continue up the ramp. You finally make it to the top, and find yourself standing on a wide, dimly lit platform. A row of long, curving slides stretches out before you. 
The slides are numbered from one to ten.
You think hard. The Doom Slide. You know you’ve heard about it before. But where? Where was it?
And then you remember! It was in a GOOSEBUMPS book you read! One Day at HorrorLand.
Now you know you’re in big trouble. Because you remember all about the Doom Slide from the book. 
You remember that if you pick the wrong slide, you’ll spend the rest of your life sliding and sliding — forever!
Which number is the Doom Slide? Which one?");
                                    ReadKey();
                                    Clear();
                                    void PlotSwitch5()
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
                                        string[] options = { "Pick slide 1, 4 or 5", "Pick slide 2, 7 or 9", "Pick slide 3, 6, 8 or 10" };
                                        Menu PlotChoose = new Menu(prompt, options);
                                        int selectedIndex = PlotChoose.Run();
                                        switch (selectedIndex)
                                        {
                                            case 0:
                                                Slide121();
                                                ReadKey();
                                                Clear();
                                                break;
                                            case 1:
                                                Slide95();
                                                ReadKey();
                                                Clear();
                                                break;
                                            case 3:
                                                Slide68();
                                                ReadKey();
                                                Clear();
                                                break;
                                        }
                                    }
                                    PlotSwitch5();
                                    ReadKey();
                                    Clear();
                                    void Slide121()
                                    {
                                        Console.WriteLine(@"You grab the sides of the slide and lower yourself down. 
The second you sit, the slide’s floor tilts up beneath you and propels you forward.
You shriek!
You raise your arms and scream louder. You slide faster and faster. In total darkness.
Darkness so black, you can’t even see your own feet in front of you.
Your eyes dart frantically from side to side. Faces suddenly appear in the darkness in bright flashes of light. 
Faces of hideous monsters with deformed heads and oozing flesh.
But you’re moving too fast to focus on them. You slide and slide — until the faces stop flashing and you’re covered in the thick, heavy blackness again.
You scream as you round a sharp curve. Your head is spinning. You pick up speed.
When will it end?
Then you hear the screams. Chilling screams that echo through the darkness.
Oh, no! You must have picked the Doom Slide!");
                                        ReadKey();
                                        Clear();
                                        Console.WriteLine(@"Bump.
A chute opens up. You land headfirst on soft grass.
You blink several times. A long sigh escapes from your lips. It wasn’t the Doom Slide after all.
As you climb to your feet you hear someone call your name.
You glance up and shout for joy. It’s Brad! And Patty’s there, too!
You tell them about your scary ride on the slide — about how you thought you’d slide forever.
“Cool!” Patty exclaims. “Let’s all ride it this time!”
“No!” you tell her. “This carnival is too weird. And dangerous. Something’s not right. We have to get out of here. Now!”
“Yeah,” Brad agrees. “The faster, the better.”
“I have an idea,” Patty announces. You and Brad huddle around her. “I spotted a back way out of here. But it’s a little risky. We have to squeeze through a barbed-wire fence — and it’s guarded by the carnival’s security forces. But we should try!”
Are you going to listen to Patty?");
                                        ReadKey();
                                        Clear();
                                        void PlotSwitch6()
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
                                            string[] options = { "Follow Patty...", "Dont take the way out..." };
                                            Menu PlotChoose = new Menu(prompt, options);
                                            int selectedIndex = PlotChoose.Run();
                                            switch (selectedIndex)
                                            {
                                                case 0:
                                                    FollowPatty48();
                                                    ReadKey();
                                                    Clear();
                                                    break;
                                                case 1:
                                                    DontLeave86();
                                                    ReadKey();
                                                    Clear();
                                                    break;
                                            }
                                        }
                                        PlotSwitch6();
                                        void FollowPatty48()
                                        {
                                            
                                        }
                                        void DontLeave86()
                                        {
                                            Endings.PattyMonster();
                                        }
                                    }
                                    void Slide95()
                                    {
                                        Console.WriteLine(@"");
                                        ReadKey();
                                        Clear();
                                        Console.WriteLine(@"");
                                        ReadKey();
                                        Clear();
                                    }
                                    void Slide68()
                                    {
                                        Console.WriteLine(@"");
                                        ReadKey();
                                        Clear();
                                        Console.WriteLine(@"");
                                        ReadKey();
                                        Clear();
                                    }
                                }

                            }
                            void NotFollowDwarf()
                            {

                            }
                            Console.WriteLine(@"");
                    ReadKey();
                    Clear();
                    Console.WriteLine(@"");
                }
            }
        }
    }
}
