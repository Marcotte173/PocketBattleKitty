using System;
using System.Collections.Generic;
using System.Text;

public class Player
{    
    public string name = "Mittens";
    public int hp;
    public int maxHp;
    public int damage;
    public int defence;
    public int attacks;
    public int currency;
    public int refresh;
    public int xp;
    public int fish;
    public int eaten;
    public Player()
    {
        hp =maxHp =  5;
        damage = 5;
        defence = 2;
        attacks = 1;
    }

    public virtual void TakeDamage(int damage)
    {
        hp -= damage;
        hp = (hp < 0) ? 0 : hp;
        if (hp <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        
    }
}