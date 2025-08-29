using UnityEngine; //requires semicolon to end

public class Refresher : MonoBehaviour
{
    int number = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (number != 10)
        {
            Debug.Log("True");
        }
        else if (number > 5)
        {
            Debug.Log("Taco");
        }
        else
        {
            Debug.Log("False");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
