using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnn1 : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject[] Eda;
    private GameObject inst_obj;
    public Vector3 dir;
    private float progress;
    public float speed;
    void Start()
    {
        StartCoroutine(SpawnObj());

    }
    private void Update()
    {
        Vector3 vector3 = new Vector3(0, 0, 1.5f);
    }
    void Repet()
    {
        StartCoroutine(SpawnObj());
    }

    IEnumerator SpawnObj()
    {
        int rand = Random.Range(0, Eda.Length - 1);
        yield return new WaitForSeconds(3);
        inst_obj = Instantiate(Eda[rand], SpawnPos.position, Quaternion.identity);
        Repet();

    }
    private void FixedUpdate()
    {
        inst_obj.transform.Translate(speed * dir * Time.deltaTime, Space.World);


    }
}
