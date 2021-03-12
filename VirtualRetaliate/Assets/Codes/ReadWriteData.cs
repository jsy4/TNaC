using System.IO; //work with files
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class ReadWriteData
{
    public static void SaveData (Player player) {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        Data data = new Data(player);
        formatter.Serialize(stream, data);
        stream.Close();

    }
    public static Data LoadData() 
    {
        string path = Application.persistentDataPath + "/player.txt";
        if (File.Exists(path)) 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            Data data = formatter.Deserialize(stream) as Data;
            stream.Close();
  
            return data;
        }
        else
        {
            Debug.LogError("File to Save Not Found at " + path);
            return null;
        }

    }
    //from : https://youtu.be/XOjd_qU2Ido 
    //helped by : https://stackoverflow.com/questions/55268664/serializeexception-attempting-to-deserialize-an-empty-stream-error
   // Cannot load if Lv is uninitialized, so set Lv = 1 at eventscreen
}
