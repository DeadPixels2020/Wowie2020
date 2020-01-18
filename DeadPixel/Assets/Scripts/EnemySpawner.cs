using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject target;

    [SerializeField] private GameObject[] enemies;

    [SerializeField] private int enemiesToSpawn;
    [SerializeField] private bool useRandomIntervals;
    [SerializeField,Tooltip("in seconds")] private float interval;
    [SerializeField,Tooltip("in seconds")] private float minInterval;
    [SerializeField,Tooltip("in seconds")] private float maxInterval;

    [SerializeField] private Transform minPoint;
    [SerializeField] private Transform maxPoint;

    private bool isSpawning;
    private int spawnedEnemies;

    public bool IsSpawning{get => isSpawning;}

    private void spawn(){
        
        createEnemy();
        spawnedEnemies++;
        if(spawnedEnemies >= enemiesToSpawn){
            stopSpawning();
        }else{

            float interval = useRandomIntervals ? Random.Range(minInterval,maxInterval) : this.interval;

            Invoke("spawn",interval);

        }
    }    

    private void createEnemy(){
        int radnomIndex = Random.Range(0,enemies.Length);

        Vector2 randomPos = randomPosition();

        GameObject enemy = Instantiate(enemies[radnomIndex],randomPos,Quaternion.identity) as GameObject;
        enemy.SetActive(true);//They all start non active becouse of the prototype
        enemy.transform.parent = transform;
    }

    private Vector2 randomPosition(){
        float randX;
        float randY;

        //Randomizing Axsis
        if(Random.Range(0,2) == 0){
            
            //Use Y
            randX = Random.Range(0,2) == 0 ? minPoint.position.x : maxPoint.position.x;
            randY = Random.Range(minPoint.position.y,minPoint.position.y);

        }else{
            
            //Use X
            randX = Random.Range(minPoint.position.x,minPoint.position.x);
            randY = Random.Range(0,2) == 0 ? minPoint.position.y : maxPoint.position.y;

        }

        return new Vector2(randX,randY);
    }

    private void stopSpawning(){
        isSpawning = false;
        if(OnFinishSpawning != null) OnFinishSpawning();
    }

    public void StartSpawning(){
        if(isSpawning) 
            return;

        
        isSpawning = true;
        spawnedEnemies = 0;
        spawn();
        if(OnStartSpawning != null) OnStartSpawning();
    }
    
    public bool AreAllEnemiesDead(){
        
        bool are = transform.childCount == 0;
        if(are && OnAllEnemiesAreDead != null){
            OnAllEnemiesAreDead();
        }

        return are;

    }

    private void Start() {
        StartSpawning();
    }

    public event Action OnStartSpawning;
    public event Action OnFinishSpawning;
    public event Action OnAllEnemiesAreDead;

}
