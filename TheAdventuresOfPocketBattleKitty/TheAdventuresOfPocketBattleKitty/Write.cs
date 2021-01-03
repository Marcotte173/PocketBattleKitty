﻿using System;
using System.Collections.Generic;
using System.Text;

public class Write
{
    public static void Line(string colour, string text)
    {
        Console.Write($"{colour}" + $"{text}" + Color.RESET);
    }
    public static void Line(int x, int y, string colour, string text)
    {
        Console.SetCursorPosition(x, y);
        Console.Write($"{colour}" + $"{text}" + Color.RESET);
    }

    public static void CenterText(string text)
    {
        Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
    }
    public static void CenterColourText(string colour, string text, string text2, string text3)
    {
        Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + ((text.Length + text2.Length + text3.Length) / 2) + ((colour.Length + Color.RESET.Length))) + "}", $"{text}{colour}{text2}{Color.RESET}{text3}"));
    }

    public static void CenterColourText(string colour, string colour2, string text, string text2, string text3, string text4, string text5)
    {
        Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + ((text.Length + text2.Length + text3.Length + text4.Length + text5.Length) / 2) + ((colour.Length + colour2.Length + Color.RESET.Length * 2))) + "}", text + colour + text2 + Color.RESET + text3 + colour2 + text4 + Color.RESET + text5));
    }

    public static void CenterColourText(string colour, string colour2, string colour3, string text, string text2, string text3, string text4, string text5, string text6, string text7)
    {
        Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + ((text.Length + text2.Length + text3.Length + text4.Length + text5.Length + text6.Length + text7.Length) / 2) + ((colour.Length + colour2.Length + colour3.Length + Color.RESET.Length * 3))) + "}", text + colour + text2 + Color.RESET + text3 + colour2 + text4 + Color.RESET + text5 + colour3 + text6 + Color.RESET + text7));
    }

    public static void CenterColourText(string colour, string colour2, string colour3, string colour4, string text, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9)
    {
        Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + ((text.Length + text2.Length + text3.Length + text4.Length + text5.Length + text6.Length + text7.Length + text8.Length + text9.Length) / 2) + ((colour.Length + colour2.Length + colour3.Length + colour4.Length + Color.RESET.Length * 4))) + "}", text + colour + text2 + Color.RESET + text3 + colour2 + text4 + Color.RESET + text5 + colour3 + text6 + Color.RESET + text7 + colour4 + text8 + Color.RESET + text9));
    }

    public static void Line(string colour, string text1, string text2, string text3)
    {
        Console.Write(
            $"{text1}"
            + colour + $"{text2}"
            + Color.RESET + $"{text3}\n");
    }

    public static void Line(string colour, string colour2, string text1, string text2, string text3, string text4, string text5)
    {
        Console.Write(
            $"{text1}"
            + colour
            + $"{text2}"
            + Color.RESET + $"{text3}"
            + colour2 + $"{text4}"
            + Color.RESET + $"{text5}\n");
    }

    public static void Line(string colour, string colour2, string colour3, string text1, string text2, string text3, string text4, string text5, string text6, string text7)
    {
        Console.Write(
            $"{text1}"
            + colour + $"{text2}"
            + Color.RESET + $"{text3}"
            + colour2 + $"{text4}"
            + Color.RESET + $"{text5}"
            + colour3 + $"{text6}"
            + Color.RESET
            + $"{text7}\n");
    }

    public static void Line(string colour1, string colour2, string colour3, string colour4, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9)
    {
        Console.Write(
            $"{text1}"
            + colour1
            + $"{text2}"
            + Color.RESET
            + $"{text3}"
            + colour2
            + $"{text4}"
            + Color.RESET
            + $"{text5}"
            + colour3
            + $"{text6}"
            + Color.RESET
            + $"{text7}"
            + colour4
            + $"{text8}"
            + Color.RESET
            + $"{text9}\n");
    }

    public static void Line(string colour1, string colour2, string colour3, string colour4, string colour5, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, string text11)
    {
        Console.Write(
             $"{text1}"
             + colour1
             + $"{text2}"
             + Color.RESET
             + $"{text3}"
             + colour2
             + $"{text4}"
             + Color.RESET
             + $"{text5}"
             + colour3
             + $"{text6}"
             + Color.RESET
             + $"{text7}"
             + colour4
             + $"{text8}"
             + Color.RESET
             + $"{text9}"
             + colour5
             + $"{text10}"
             + Color.RESET
             + $"{text11}\n");
    }

    internal static void Line(int x, int y, string words) { Console.SetCursorPosition(x, y); Console.Write(words + Color.RESET); }
    internal static void Line(string words) { Console.WriteLine(words + Color.RESET); }
    internal static void SetX(int x)
    {
        Console.SetCursorPosition(x, Console.CursorTop);
    }

    internal static void SetY(int y)
    {
        Console.SetCursorPosition(Console.CursorLeft, y);
    }

    internal static void Position(int x, int y)
    {
        Console.SetCursorPosition(x, y);
    }
    public static void Line(int x, int y, string colour, string text1, string text2, string text3)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(
            $"{text1}"
            + colour + $"{text2}"
            + Color.RESET + $"{text3}\n");
    }

    public static void Line(int x, int y, string colour, string colour2, string text1, string text2, string text3, string text4, string text5)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(
            $"{text1}"
            + colour
            + $"{text2}"
            + Color.RESET + $"{text3}"
            + colour2 + $"{text4}"
            + Color.RESET + $"{text5}\n");
    }

    public static void Line(int x, int y, string colour, string colour2, string colour3, string text1, string text2, string text3, string text4, string text5, string text6, string text7)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(
            $"{text1}"
            + colour + $"{text2}"
            + Color.RESET + $"{text3}"
            + colour2 + $"{text4}"
            + Color.RESET + $"{text5}"
            + colour3 + $"{text6}"
            + Color.RESET
            + $"{text7}\n");
    }

    public static void Line(int x, int y, string colour1, string colour2, string colour3, string colour4, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(
            $"{text1}"
            + colour1
            + $"{text2}"
            + Color.RESET
            + $"{text3}"
            + colour2
            + $"{text4}"
            + Color.RESET
            + $"{text5}"
            + colour3
            + $"{text6}"
            + Color.RESET
            + $"{text7}"
            + colour4
            + $"{text8}"
            + Color.RESET
            + $"{text9}\n");
    }

    public static void Line(int x, int y, string colour1, string colour2, string colour3, string colour4, string colour5, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, string text11)
    {
        Console.Write(
             $"{text1}"
             + colour1
             + $"{text2}"
             + Color.RESET
             + $"{text3}"
             + colour2
             + $"{text4}"
             + Color.RESET
             + $"{text5}"
             + colour3
             + $"{text6}"
             + Color.RESET
             + $"{text7}"
             + colour4
             + $"{text8}"
             + Color.RESET
             + $"{text9}"
             + colour5
             + $"{text10}"
             + Color.RESET
             + $"{text11}\n");
    }
    internal static void KeyPress()
    {
        Write.Line("Press any key to continue");
        Console.ReadKey(true);
    }
    internal static void KeyPress(int a)
    {
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine("");
        }
        Write.Line("Press any key to continue");
        Console.ReadKey(true);
    }
    internal static void KeyPress(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Write.Line("Press any key to continue");
        Console.ReadKey(true);
    }
}