using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System;

public static class JsonHandler
{    
    public static Questions GenerateQuestions(TextAsset jsonFile)
    {

        Questions questionsInJson = JsonUtility.FromJson<Questions>(jsonFile.text);

        return questionsInJson;
    }

 
    public static void SaveToJSON<T> (List<T> toSave, string fileName)
    {   
        Debug.Log(GetPath(fileName));
        string content = JsonHelper.ToJson<T>(toSave.ToArray());
        WriteFile(GetPath(fileName), content);
    }

    public static List<T> ReadFromJSON<T>(string fileName)
    {
        string content = ReadFile(GetPath(fileName));

        if (string.IsNullOrEmpty(content) || content == "{}"){
            return new List<T>();
        }

        List<T> result = JsonHelper.FromJson<T>(content).ToList();

        return result;
    }

    private static string ReadFile(string path)
    {
        if (File.Exists(path))
        {
            using (StreamReader steamReader  = new StreamReader(path))
            {
                string content = steamReader.ReadToEnd();
                return content;
            }
        }
        return "";
    }

    private static string GetPath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }

    private static void WriteFile(string path, string content)
    {
        FileStream fileStream = new FileStream(path, FileMode.Create);
        
        using(StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(content);
        }
    }


}

public static class JsonHelper
{
    public static T[] FromJson<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.Items;
    }

    public static string ToJson<T>(T[] array)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper);
    }

    public static string ToJson<T>(T[] array, bool prettyPrint)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }

    [Serializable]
    private class Wrapper<T>
    {
        public T[] Items;
    }
}
