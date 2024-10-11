using System;

public class Pet
{

    private int hunger;
    private int boredom;
    private bool isAlive;
    private List<string> words = new List<string>();
    public string name;
    Random random;

    public void Tick()
    {
        boredom++;
        hunger++;
        if(hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }

    public void Feed()
    {
        hunger--;

        if(hunger <= 0)
        {
            hunger = 0;
        }
    }

    public void Hi()
    {
        if (words.Count < 1)
        {
            Console.WriteLine($"they don't know any words");
        }
        else
        {
            int wordNumber = Random.Shared.Next(words.Count);
            Console.WriteLine($" {name} says {words[wordNumber]}");
            ReduceBoredom();
        }
    }
    public void Teach(String word)
    {
        Console.WriteLine($"{name} has learned {word}");
        words.Add(word);
        ReduceBoredom();
    }

    public void ReduceBoredom()
    {
        boredom--;

        if(boredom <= 0)
        {
            boredom = 0;
        }
    }
    
   
    public void DrawStats()
    {
        Raylib.DrawText($"{boredom}", 49, 500, 50, Color.Black);
    }

    public bool GetAlive()
    {
        return isAlive;
    }
}







