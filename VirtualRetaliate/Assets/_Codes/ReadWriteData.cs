using System.IO; //work with files
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class ReadWriteData
{
    public static void SaveData (Player player) {
        Debug.Log("Save Data called");
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath+ Path.DirectorySeparatorChar + "player.txt";

        //if no file exist on the path create one
        if (!File.Exists(path)) 
        { File.Create("player.txt"); Debug.Log("File Created"); }

            FileStream stream = new FileStream(path, FileMode.Create);
            Data data = new Data(player);
            formatter.Serialize(stream, data);
            stream.Close();

    //        Debug.LogError("File to Save Not Found at " + path);
        
    }
    public static Data LoadData() 
    {
        Debug.Log("Load Data called");
        string path = Application.persistentDataPath + Path.DirectorySeparatorChar + "player.txt";
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
            Debug.LogError("File to Load Not Found at " + path);
            return null;
        }

    }
    //from : https://youtu.be/XOjd_qU2Ido 
    //helped by : https://stackoverflow.com/questions/55268664/serializeexception-attempting-to-deserialize-an-empty-stream-error
    // for persistant path read : https://docs.unity3d.com/ScriptReference/Application-persistentDataPath.html
}
