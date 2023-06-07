using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private ObjectPool pool;
    private int numberOfObstacles = 3;
    private int numberOfObstaclesInScene = 0;

    private float timeAcumulator = 0f;
    private float timeNewBlock = 2f;

    private void Awake()
    {
        pool.StartPool();
    }

    private void Start()
    {
        //for (int i = 0; i <= numberOfObstacles; i++)
        //{
        //    var obj = ObjectPool.instance.GetPoolObject();

        //    if (obj != null)
        //    {
        //        var x = Random.Range(13f, 18f);
        //        var y = Random.Range(-4f, 4f);

        //        obj.transform.position = new Vector2(x, y);
        //        Debug.Log(x + ", " + y);
        //        obj.SetActive(true);
        //        numberOfObstaclesInScene++;
        //    }
        //}
    }

    private void Update()
    {
        timeAcumulator += Time.deltaTime;
        if (timeAcumulator > timeNewBlock)
        {
            timeAcumulator = 0;
            var obj = ObjectPool.instance.GetPoolObject();
            if (obj != null)
            {
                var x = 18f;//Random.Range(13, 18f);
                var y = Random.Range(-2f, 2f);

                obj.transform.position = new Vector2(x, y);
                obj.SetActive(true);

            }
        }

        //if (numberOfObstaclesInScene > numberOfObstacles)
        //{
        //    var obj = ObjectPool.instance.GetPoolObject();
        //    if (obj != null)
        //    {
        //        var x = Random.Range(13, 18f);
        //        var y = Random.Range(-4f, 4f);

        //        obj.transform.position = new Vector2(x, y);
        //        Debug.Log(x + ", " + y);
        //        obj.SetActive(true);

        //    }
        //}
        
    }

    private IEnumerator GetBlock(float time)
    {
        yield return new WaitForSeconds(time);
    }


}
