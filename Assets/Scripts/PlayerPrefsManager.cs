using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
        //const string MASTER_VOLUME_KEY = "master_volume";
        const string AREA_KEY = "difficulty";
        //const string LEVEL_KEY = "Unlocked Levels_";


        //public static void SetMasterVolume(float volume)
        //{
        //    if (volume > 0f && volume <= 1f)
        //    {
        //        PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        //    }
        //    else
        //    {
        //        Debug.LogError("Master Volume Error");
        //    }
        //}
        //public static float GetMasterVolume()
        //{
        //    return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
        //}


        //public static void UnlockLevel(int level)
        //{
        //    if (level <= Application.levelCount - 1)
        //    {
        //        PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
        //    }
        //    else
        //    {
        //        Debug.LogError("The Level You are trying to open is not is build settings");
        //    }
        //}

        //public static bool IsLevelUnlocked(int level)
        //{
        //    int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        //    bool isLevelUnlocked = (levelValue == 1);

        //    if (level <= Application.levelCount - 1)
        //    {
        //        return isLevelUnlocked;
        //    }
        //    else
        //    {
        //        Debug.LogError("Trying to query level that is not in the Build Order");
        //        return false;
        //    }
        //}

        public static void SetAreaSelection(float Area)
        {
            if (Area >= 1f && Area <= 3f)
            {
                PlayerPrefs.SetFloat(AREA_KEY, Area);
            }
            else
            {
                Debug.LogError("Area not available !");
            }
        }

        public static float GetAreaSelection()
        {
            return PlayerPrefs.GetFloat(AREA_KEY);
        }
}
