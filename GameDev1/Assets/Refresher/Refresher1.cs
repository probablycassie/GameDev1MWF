using UnityEngine; //requires semicolon to end

public class Refresher : MonoBehaviour
{
    int option = 0;

    Fruit pineapple;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pineapple.fruit_name = "Yum Yum Pineeapple";
        pineapple.juiciness = 8;
        pineapple.price = 3.00f;


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

        /*  int i = 0;
          do
          }
              Debug.StartupLog(int);
              i++;
          {
              Debug.Log(i);
              i++;
          }
          while (int < 5 || i != 3) ;

          Debug.Log("End");*/

        Debug.Log(add(17, 99));

        Debug.Log("End");
    }

    // Update is called once per frame
    void Update()
    {

    }


    int add(int a, int b = 45)
    {
        return(a + b);
    }
}