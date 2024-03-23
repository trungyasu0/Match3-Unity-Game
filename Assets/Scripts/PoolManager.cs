using UnityEngine;


public class PoolManager : MonoBehaviour
{
    public static PoolManager Instance;
 
    private GameSettings gameSetting;
     
    private CellPool _cellPool;
 
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else Destroy(gameObject);
 
        gameSetting = Resources.Load<GameSettings>(Constants.GAME_SETTINGS_PATH);
        _cellPool = new CellPool(gameSetting.BoardSizeX * gameSetting.BoardSizeY);
    }


    public CellPool GetCellPool()
    {
        return _cellPool;
    }
 
     
}