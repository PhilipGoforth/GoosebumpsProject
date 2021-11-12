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
            Clear();
            Console.WriteLine(@"
                               “Let’s go on the rides first!” you say. “That roller coaster looked awesome!”
                              “Okay,” Patty agrees. “Over this way!” she yells as she charges over to it.
                              When you reach the rides, you can only stare in amazement. These are the most fantastic rides you’ve ever seen. 
                               The towering roller coaster ... 
                               the soaring speedboats ... the twisty slides! Every one is in motion. Whizzing, whirling, doing loop-the-loops. 
                                And they’re all empty! No riders. No people in line!
                               “Cool!” Patty exclaims. “We have the whole place to ourselves.”
                               Brad’s face turns a little green as his gaze swings from the Supersonic Space Coaster to the Doom Slide. 
                              Do you think they have rides that don’t go upside down?” he asks.
                               “Come on! Let’s check out the coaster!” Patty calls to you and Brad. Then they run off to its starting gate.
                               You stop and crane your neck to gaze up at the coaster’s first hill. And you gasp!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@"The tracks stretch up so high that they seem to touch the clouds. Your gaze follows one of the cars speeding around a sharp curve. 
                                It looks like the space shuttle. You notice that it has a safety harness that locks over your body — you’ve seen those before. 
                                They keep you in when the ride turns upside down. 
                                You didn’t want to admit it before, but, like Brad, riding upside down is not your favorite thing.
                                Still, the coaster does look amazing — one part enters a tunnel — and you can see that the cars go fast. Really Fast!
                                You’re just about to walk through the Space Coaster gate when you hear spooky organ music coming from behind you. You turn around. 
                                Looming in the distance is a dark and creepy haunted house.
                                You gaze down at your map. It’s called the House of Horrors. Hmmm. You love haunted houses. And this one really looks scary.
                                Now you’re not sure what to do. You won’t have time for everything. The coaster or the haunted house? Decide now.");
            Console.ReadLine();
            Console.Clear();
            PlotSwitches.PlotSwitch();
            ReadKey();
            Clear();
        }
    }
}
