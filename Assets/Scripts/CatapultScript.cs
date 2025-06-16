using UnityEngine;

public class CatapultScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("skripti toimii!!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
    }
    void Launch()
    {
        Debug.Log("ampuu!!!!");
    }
}
