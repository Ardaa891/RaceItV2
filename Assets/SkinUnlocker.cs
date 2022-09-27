using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinUnlocker : MonoBehaviour
{
    public GameObject car1, car2, car3, car4, car5, car6, car7, car8, car9, car10, car11, car12;

    public GameObject baseCar;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (PlayerPrefs.GetInt("CarSkin") == 1)
        {
            baseCar.SetActive(false);
            car1.SetActive(true);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(false);


        }
        else if (PlayerPrefs.GetInt("CarSkin") == 2)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(true);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(false);


        }
        else if (PlayerPrefs.GetInt("CarSkin") == 3)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(true);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 4)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(true);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 5)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(true);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 6)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(true);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 7)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(true);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 8)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(true);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 9)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(true);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 10)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(true);
            car11.SetActive(false);
            car12.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 11)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(true);
            car12.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 12)
        {
            baseCar.SetActive(false);
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(true);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 0)
        {
            baseCar.SetActive(true);

            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
            car5.SetActive(false);
            car6.SetActive(false);
            car7.SetActive(false);
            car8.SetActive(false);
            car9.SetActive(false);
            car10.SetActive(false);
            car11.SetActive(false);
            car12.SetActive(false);
        }
    }

   
}
