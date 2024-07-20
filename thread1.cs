using System;
using System.Threading;

class Character
{
    private string name;
    private string action;

    public Character(string name, string action)
    {
        this.name = name;
        this.action = action;
    }

    public void PerformAction()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(name+" is "+ action);
            Thread.Sleep(500); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Character warrior = new Character("Warrior", "attacking");
        Character mage = new Character("Mage", "casting a spell");
        Character archer = new Character("Archer", "shooting an arrow");

        Thread warriorThread = new Thread(warrior.PerformAction);
        Thread mageThread = new Thread(mage.PerformAction);
        Thread archerThread = new Thread(archer.PerformAction);

        warriorThread.Start();
        mageThread.Start();
        archerThread.Start();

        warriorThread.Join();
        mageThread.Join();
        archerThread.Join();
    }
}
}