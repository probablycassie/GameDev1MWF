using UnityEngine; //requires semicolon to end

public class Refresher : MonoBehaviour
{
    int option = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*  switch (number)
          {       
              case 0:
                  Debug.Log("Start");
                  break;

              case 1:
                  Debug.Log("Options");
                  break;
              case 2:

                  Debug.Log("Quit");
                  break;
          }*/

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
            i++;
        }
        while (int < 5 || i != 3) ;

        Debug.Log("End");
    }

    // Update is called once per frame
    void Update()
    {

    }
}