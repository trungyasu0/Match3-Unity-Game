using UnityEngine;

public class GameConfig : MonoBehaviour
{
    public static GameConfig Instance;

    public ItemConfig itemConfig;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public ItemConfig GetItemConfig()
    {
        return itemConfig;
    }
}