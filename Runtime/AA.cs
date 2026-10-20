using UnityEngine;

public class AA : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.ResetLocal();
        transform.DestroyChildren();

        Debug.Log($"1과 4를더한 값 : {MyMath.Add(1, 4)}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
