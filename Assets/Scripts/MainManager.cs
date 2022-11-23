using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public int avatar_selected;
    public int Coins = 1000;
    private CoinsEarned earned;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadUserData();
    }

    [System.Serializable]
    class SaveData
    {
        public int avatar_selected;
        public int Coins;
    }

    public void SaveUserData()
    {
        SaveData data = new SaveData();
        data.avatar_selected = avatar_selected;
        data.Coins = Coins;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadUserData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            avatar_selected = data.avatar_selected;
            Coins = data.Coins;
        }
    }

}
