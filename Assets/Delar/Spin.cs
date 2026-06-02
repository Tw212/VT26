using System.Collections.Generic;
using UnityEngine;

public class Spelobject
    {
        public Objects Type;
        public int Multiplier;

        public Spelobject(Objects type, int multiplier)
        {
            Type = type;
            Multiplier = multiplier;
        }
    }

public class Spin
{
        private List<Spelobject> spelobjects = new List<Spelobject>();
    
    public Spin()
    {
        spelobjects.Add(new Spelobject(Objects.Freespin, 2));
        spelobjects.Add(new Spelobject(Objects.Kikare, 3));
        spelobjects.Add(new Spelobject(Objects.Gun, 5));
        spelobjects.Add(new Spelobject(Objects.Map, 10));
        spelobjects.Add(new Spelobject(Objects.Kompass, 10));
        spelobjects.Add(new Spelobject(Objects.Palmträd, 10));
        spelobjects.Add(new Spelobject(Objects.Skalle, 10));
        spelobjects.Add(new Spelobject(Objects.Ratt, 10));
        spelobjects.Add(new Spelobject(Objects.Ship, 10));
        spelobjects.Add(new Spelobject(Objects.Chest, 10));
        spelobjects.Add(new Spelobject(Objects.Papegoja, 10));
    }

    public Spelobject SpinB()
    {
        int randomIndex = Random.Range(0, spelobjects.Count);
        return spelobjects[randomIndex];
    }

    public int CalculateWin(Spelobject a, Spelobject b, Spelobject c, int bet)
    {
        if (a.Type == b.Type && b.Type == c.Type)
        {
            return bet * a.Multiplier;
        }

        return 0;
    }
}
