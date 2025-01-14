using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameManager : MonoBehaviour
{
    public static SaveData data;

    private void Awake()
    {
        data  = new SaveData();
        SaveLoad.onLoadGame += LoadData;
    }

    public void DeleteData()
    {
        SaveLoad.DeleteSaveData();
    }

    public static void SaveData()
    {
        var saveData = data;

        SaveLoad.Save(saveData);
    }

    public static void LoadData(SaveData _data)
    {
        data = _data;
    }

    public static void TryLoadData()
    {
        Debug.Log("Trying to Load");
        SaveLoad.Load();
    }
}
