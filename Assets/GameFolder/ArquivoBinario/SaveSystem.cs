using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem
{
    public static void SavePlayer(Player player)
    {
        BinaryFormatter binary = new BinaryFormatter();

        string path = Application.persistentDataPath + "/player.dado";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        binary.Serialize(stream, data);
        stream.Close();

        Debug.Log("Dado salvo");

    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.dado";

        if (File.Exists(path))
        {
            BinaryFormatter binary = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = binary.Deserialize(stream) as PlayerData;

            Debug.Log("Dado carregado");

            return data;

        }
        else
        {
            Debug.Log("Arquivo nao existe " + path);
            return null;
        }

    }
}
