using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    void Start()
    {
        LoadJsonFromFile<GameStatus>("/CommonTools/JsonUtility/TestFolder/testJson.json");
    }

    public static T LoadJsonFromFile<T>(string filePath)
    {
        if (!File.Exists(Application.dataPath + filePath))
        {
            return default(T);
        }

        StreamReader sr = new StreamReader(Application.dataPath + filePath);

        if (sr == null)
        {
            return default(T);
        }

        string json = sr.ReadToEnd();

        if (json.Length > 0)
        {
            T data = JsonUtility.FromJson<T>(json);
            sr.Close();
            return data;
        }

        sr.Close();
        return default(T);
    }
}
