
using System.IO;
using UnityEngine;

public static class Filhantering
{
    private static string path =
        Application.persistentDataPath + "/playerData.json";

    public static void SavePlayer(Player player)
    {
        string json = JsonUtility.ToJson(player, true);
        File.WriteAllText(path, json);
    }

    public static Player LoadPlayer()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<Player>(json);
        }

        return new Player("Player", 1000);
    }
}
    