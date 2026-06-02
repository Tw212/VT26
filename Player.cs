
using UnityEngine;
using UnityEngine.UI;

public class Player: MonoBehaviour
{
    public string PlayerName;
    public int Konto;

    public Player(string playerName, int balance)
    {
        PlayerName = playerName;
        Konto = konto;
    }

    public bool Kanbet(int amount)
    {
        return Konto >= amount;
    }

    public void LaggtillP(int amount)
    {
        Konto += amount;
    }

    public void TabortP(int amount)
    {
        Konto -= amount;
    }
}