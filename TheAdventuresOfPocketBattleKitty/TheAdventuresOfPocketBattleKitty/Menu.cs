using System;
using System.Collections.Generic;
using System.Threading;

public class Menu
{
    public static Player p = new Player();
    public static void Go()
    {
        string a = (p.hp>0)?Color.HEALTH :Color.BLOOD;
        string b = (p.hp >= p.maxHp * 2 / 5) ?Color.HEALTH :Color.BLOOD;
        string c = (p.hp >= p.maxHp * 3 / 5) ?Color.HEALTH :Color.BLOOD;
        string d = (p.hp >= p.maxHp*4/5)?Color.HEALTH :Color.BLOOD;
        string e = (p.hp >=p.maxHp) ? Color.HEALTH : Color.BLOOD;
        Console.Clear();
        Write.Line(Color.SPEAK+"Welcome Mittens, What do you wish to do?");        
        Write.Line(0, 7, Color.HEALTH + "HP:        " + Color.RESET + p.hp + "/" + p.maxHp);
        Write.Line(0, 8, Color.DAMAGE+"Pounce:   " + Color.RESET + $" {p.damage}");
        Write.Line(0, 9, Color.MITIGATION+"Defence:  " + Color.RESET + $" {p.defence}");
        Write.Line(0, 10, Color.CLASS+"Scratches:" + Color.RESET + $" { p.attacks}");
        Write.Line(30, 7,Color.GOLD+"Yarn:   " + Color.RESET + $" {p.currency}");
        Write.Line(30, 8,Color.ENERGY+"Cat Nip:" + Color.RESET + $" {p.refresh}");
        Write.Line(30, 9,Color.XP+"Purrs:  " + Color.RESET + $" {p.xp}");
        Write.Line(30, 10,Color.ITEM+"Fish:   " + Color.RESET + $" {p.fish}");
        Write.Line(0, 22,Color.SPEAK, "Please select an action");
        Write.Line(0, 24, "["+Color.DAMAGE+"F"+Color.RESET+     "]"+Color.DAMAGE + "ight in Master's Coat Pocket Dungeon");
        Write.Line(0, 25, "["+Color.GOLD+"U"+Color.RESET+     "]"+Color.GOLD + "pgrade");
        Write.Line(0, 26, "["+Color.XP+"E"+Color.RESET+     "]"+Color.XP + "xhange Purrs for Cat Nip");
        Write.Line(0, 27, "["+Color.NAME+"M"+Color.RESET+     "]"+Color.NAME + "editate for Random Prizes");
        Write.Line(0, 28, "["+Color.CLASS+ "C" + Color.RESET + "]" + Color.CLASS + "atch a fish");
        Write.Line(91, 2, Color.HEALTH + a + "*" + b + "*" + c + "*" + d + "*" + e + "*");
        Write.Line(90,3," /\\_/\\  ");
        Write.Line(90,4,"=(o.o)=  ");
        Write.Line(90,5," (____)~~  ");
        string choice = Return.Option();
        if (choice == "c") Fish();
        else if (choice == "e") Catnip();
        else if (choice == "u") Upgrade();
        Go();
    }

    private static void Upgrade()
    {
        Console.Clear();
        if (p.currency <5)
        {
            Write.Line("Sorry, you don't have enough Yarn\n");
            Write.KeyPress();
            Go();
        }
        else
        {
            int upgrade = p.currency / 5;
            Write.Line("Congrats, Mittens just became stronger\n");
            Write.Line($"Pounce increased by {2 * upgrade}");
            Write.Line($"Defence increased by {upgrade}");
            Write.Line($"Health increase by {upgrade}");
            int scratchInt = (p.attacks + upgrade < 20) ? upgrade : 20 - p.attacks ;
            if (scratchInt > 0) Write.Line("Scratches increased by " + scratchInt);
            Write.Line($"You have spent {5 * upgrade} Yarn\n");
            for (int i = 0; i < upgrade; i++)
            {
                p.damage += 2;
                p.defence++;
                p.maxHp++;
                p.hp++;
                p.eaten++;
                if (p.attacks < 20) p.attacks++;
                p.currency -= 5;
            }            
            Write.KeyPress();
            Go();
        }
    }

    private static void Fish()
    {
        Console.Clear();
        Write.Line("  [ 20 Fish Will Get Auto Traded. ]  ");
        Write.Line("    [ Whenever you have 20 Fish. ]    ");
        Write.Line("       [ Session Only Game. ]        ");
        Write.Line("          [ Fish Time. ]             ");
        Write.Line("     [ Now Fishing in masters ]     ");

        Write.Line("         [ Goldfish Bowl... ]        ");
        Write.Line("......................................");
        Write.Line(".                                     ");
        Write.Line("       ___________                    ");
        Write.Line("       \\_________/                    ");

        Write.Line("       /         \\    /\\_/\\           ");
        Write.Line("       \\  )=(o)  /   =(o.o)=          ");
        Write.Line("        \\_______/     (____)~~        ");
        Write.Line(".                                     ");
        Write.Line("......................................");
        Write.Line("You caught...                         ");
        Write.Line(0,16,"......................................");        
        int caught = Return.RandomInt(0, 8);
        Thread.Sleep(1500);
        Write.Line(14,15,(caught < 3) ? " a fish" : (caught < 5)?" fish poo":"nothing");
        if (caught < 3) p.fish++;
        Write.KeyPress(0,28);
    }

    public static void Catnip()
    {
        Console.Clear();
        if (p.xp < 25)
        {
            Write.Line("Sorry, you don't have enough Purrs\n");
            Write.KeyPress();
            Go();
        }
        else
        {
            int upgrade = p.xp / 525;
            int remaining = p.xp - upgrade*525;
            int upgrade2 = remaining / 25;
            Write.Line("Congrats, Mittens just became stronger\n");
            Write.Line($"Catnip increased by {upgrade + upgrade2}");
            if (upgrade >0) Write.Line($"Pounce increased by {upgrade}\n");
            Write.KeyPress();
            Go();
            for (int i = 0; i < upgrade; i++)
            {
                p.xp -= 25;
                p.refresh++;
            }
            for (int i = 0; i < upgrade2; i++)
            {
                p.xp -= 525; 
                p.refresh++;
                p.damage++;
            }            
            Write.KeyPress();
            Go();
        }
    }
}