using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int maxEnemies = 10;

    private void Awake()
    {
        InitializeLevel();
    }
    private void InitializeLevel()
    {
        for (int i = 0; i < maxEnemies; i++)
        {
            spawnEnemies();
        }
    }

    private void spawnEnemies()
    {
        bool valid;
        GameObject newEnemy;
        do
        {
            newEnemy = Instantiate(enemyPrefab);
            valid = CheckTooCloseToEnemy(newEnemy);
        } while (valid == false);
        return;
    }

    private bool CheckTooCloseToEnemy(GameObject testObject)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Dummie");

        foreach (GameObject enemy in enemies)
        {
            if (enemy != testObject)
            {
                //check if too close
                if (Vector3.Distance(testObject.transform.position, enemy.transform.position) < 5)
                {
                    Destroy(testObject);
                    return false;
                }
            }
        }
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
