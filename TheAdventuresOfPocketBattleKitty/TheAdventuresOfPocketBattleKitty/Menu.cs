using System;
using System.Collections.Generic;
using System.Text;

public class Menu
{
    public static Player p = new Player();
    public static void Go()
    {
        string a = Color.HEALTH + "*";
        string b = Color.BLOOD + "*";
        Write.Line(Color.SPEAK+"Welcome Mittens, What do you wish to do?");
        Write.Line(0, 7, Color.HEALTH+"HP:        " + Color.RESET + a+a+a+a+a+a+a+a+a+a+a+a+a+a+a+b+b);
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
        Return.Option();
    }    
}