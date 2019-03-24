using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public static class SaveSystem 
{
       public static void SavePlayer(Player player)
       {

        try
        {

            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/player.dat";
            FileStream stream = new FileStream(path, FileMode.Create);

            PlayerData data = new PlayerData(player);
            formatter.Serialize(stream, data);
            stream.Close();
        }catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }

        }



    

    public static PlayerData LoadPlayer()
    {
        try
        {
            string path = Application.persistentDataPath + "/player.dat";


            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                PlayerData data = formatter.Deserialize(stream) as PlayerData;

                stream.Close();
                return data;

            }
            else
            {
                Debug.LogError("Save file not found in" + Application.persistentDataPath + "/player.dat");
                return null;
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }


}
