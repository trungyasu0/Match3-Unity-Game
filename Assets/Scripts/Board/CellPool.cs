using System.Collections.Generic;
using UnityEngine;

public class CellPool
{
    private Queue<Cell> pool;
    private GameObject prefabBG;

    public CellPool(int initialSize)
    {
        pool = new Queue<Cell>(initialSize);
        prefabBG = Resources.Load<GameObject>(Constants.PREFAB_CELL_BACKGROUND);

        for (int i = 0; i < initialSize; i++)
        {
            GameObject go = GameObject.Instantiate(prefabBG);
            Cell cell = go.GetComponent<Cell>();
            go.SetActive(false);
            pool.Enqueue(cell);
        }
    }

    public Cell Get()
    {
        if (pool.Count > 0)
        {
            Cell cell = pool.Dequeue();
            cell.gameObject.SetActive(true);
            return cell;
        }
        else
        {
            GameObject go = GameObject.Instantiate(prefabBG);
            Cell cell = go.GetComponent<Cell>();
            
            Debug.Log("create cell in pool");
            
            return cell;
        }
    }

    public void Return(Cell cell)
    {
        cell.gameObject.SetActive(false);
        pool.Enqueue(cell);
    }
}