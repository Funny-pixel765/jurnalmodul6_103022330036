// See https://aka.ms/new-console-template for more information
using jurnalmodul6_103022330036;
using System;

namespace jurnalmodul6_103022330036;
 class Program
{
    static void main()
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial design by Contract- Tio Funny");
            video.increasePlayCount(50000);
            video.printVideoDetails();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}