using System;

namespace BreakThing
{
    class Program
    {
        static void Main(string[] args)
        {
            Boxer apollo = new Boxer();
            try
            {
                apollo.FightsDrago();
            } 
            catch(HeDiesException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cue the training montage!");
            }
        }
    }
}
