using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MoreMountains.NiceVibrations;

public class CarSkinManager : MonoBehaviour
{
    public static CarSkinManager Current;

    public int car1Price, car2Price, car3Price, car4Price, car5Price, car6Price, car7Price, car8Price, car9Price, car10Price, car11Price, car12Price;

    public Button car1UnlockButton, car2UnlockButton, car3UnlockButton, car4UnlockButton, car5UnlockButton, car6UnlockButton, car7UnlockButton, car8UnlockButton, car9UnlockButton, car10UnlockButton, car11UnlockButton, car12UnlockButton;

    public static bool car1Unlocked, car2Unlocked, car3Unlocked, car4Unlocked, car5Unlocked, car6Unlocked, car7Unlocked, car8Unlocked, car9Unlocked, car10Unlocked, car11Unlocked, car12Unlocked;


    void Start()
    {
        Current = this;
        Debug.Log(car1Unlocked);
        car1Price = 50;
        car2Price = 100;
        car3Price = 150;
        car4Price = 200;
        car5Price = 250;
        car6Price = 300;
        car7Price = 350;
        car8Price = 400;
        car9Price = 450;
        car10Price = 500;
        car11Price = 550;
        car12Price = 600;
    }

    
    void Update()
    {
        CheckButtons();

        if(PlayerPrefs.GetInt("CarSkin") == 1)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);

        }else if(PlayerPrefs.GetInt("CarSkin") == 2)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);

        }else if(PlayerPrefs.GetInt("CarSkin") == 3)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 4)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 5)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 6)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 7)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 8)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 9)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 10)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("CarSkin") == 11)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("CarSkin") == 12)
        {
            car1UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car2UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car3UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
            car4UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car5UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car6UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car7UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car8UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car9UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car10UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car11UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(false);
            car12UnlockButton.transform.GetChild(1).transform.gameObject.SetActive(true);
        }

    }


    public void CheckButtons()
    {
        if (car1Unlocked)
        {
            car1UnlockButton.interactable = true;
            car1UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car1Price)
            {
                car1UnlockButton.interactable = true;
            }
            else
            {
                car1UnlockButton.interactable = false;
            }
        }

        if (car2Unlocked)
        {
            car2UnlockButton.interactable = true;
            car2UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car2Price)
            {
                car2UnlockButton.interactable = true;
            }
            else
            {
                car2UnlockButton.interactable = false;
            }
        }

        if (car3Unlocked)
        {
            car3UnlockButton.interactable = true;
            car3UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car3Price)
            {
                car3UnlockButton.interactable = true;
            }
            else
            {
                car3UnlockButton.interactable = false;
            }
        }

        if (car4Unlocked)
        {
            car4UnlockButton.interactable = true;
            car4UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car4Price)
            {
                car4UnlockButton.interactable = true;
            }
            else
            {
                car4UnlockButton.interactable = false;
            }
        }

        if (car5Unlocked)
        {
            car5UnlockButton.interactable = true;
            car5UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car5Price)
            {
                car5UnlockButton.interactable = true;
            }
            else
            {
                car5UnlockButton.interactable = false;
            }
        }

        if (car6Unlocked)
        {
            car6UnlockButton.interactable = true;
            car6UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car6Price)
            {
                car6UnlockButton.interactable = true;
            }
            else
            {
                car6UnlockButton.interactable = false;
            }
        }

        if (car7Unlocked)
        {
            car7UnlockButton.interactable = true;
            car7UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car7Price)
            {
                car7UnlockButton.interactable = true;
            }
            else
            {
                car7UnlockButton.interactable = false;
            }
        }

        if (car8Unlocked)
        {
            car8UnlockButton.interactable = true;
            car8UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car8Price)
            {
                car8UnlockButton.interactable = true;
            }
            else
            {
                car8UnlockButton.interactable = false;
            }
        }

        if (car9Unlocked)
        {
            car9UnlockButton.interactable = true;
            car9UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car9Price)
            {
                car9UnlockButton.interactable = true;
            }
            else
            {
                car9UnlockButton.interactable = false;
                
            }
        }

        if (car10Unlocked)
        {
            car10UnlockButton.interactable = true;
            car10UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car10Price)
            {
                car10UnlockButton.interactable = true;
            }
            else
            {
                car10UnlockButton.interactable = false;
            }
        }

        if (car11Unlocked)
        {
            car11UnlockButton.interactable = false;
            car11UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car11Price)
            {
                car11UnlockButton.interactable = true;
            }
            else
            {
                car11UnlockButton.interactable = false;
            }
        }

        if (car12Unlocked)
        {
            car12UnlockButton.interactable = true;
            car12UnlockButton.transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetInt("Money") >= car12Price)
            {
                car12UnlockButton.interactable = true;
            }
            else
            {
                car12UnlockButton.interactable = false;
            }
        }
    }

    public void UnlockCar1()
    {
        if (!car1Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car1Price);
            PlayerPrefs.SetInt("CarSkin", 1);
            car1Unlocked = true;
            
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 1);
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
    }

    public void UnlockCar2()
    {

        if (!car2Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car2Price);
            PlayerPrefs.SetInt("CarSkin", 2);
            car2Unlocked = true;
            
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 2);
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
    }

    public void UnlockCar3()
    {

        if (!car3Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car3Price);
            PlayerPrefs.SetInt("CarSkin", 3);
            car3Unlocked = true;
            
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 3);
            MMVibrationManager.Haptic(HapticTypes.Success);

        }
    }

    public void UnlockCar4()
    {
        if (!car4Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car4Price);
            PlayerPrefs.SetInt("CarSkin", 4);
            car4Unlocked = true;
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 4);
            MMVibrationManager.Haptic(HapticTypes.Success);

        }
    }

    public void UnlockCar5()
    {
        if (!car5Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car5Price);
            PlayerPrefs.SetInt("CarSkin", 5);
            car5Unlocked = true;
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 5);
            MMVibrationManager.Haptic(HapticTypes.Success);

        }
    }

    public void UnlockCar6()
    {
        if (!car6Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car6Price);
            PlayerPrefs.SetInt("CarSkin", 6);
            car6Unlocked = true;
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 6);
            MMVibrationManager.Haptic(HapticTypes.Success);

        }
    }

    public void UnlockCar7()
    {
        if (!car7Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car7Price);
            PlayerPrefs.SetInt("CarSkin", 7);
            car7Unlocked = true;
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 7);
            MMVibrationManager.Haptic(HapticTypes.Success);

        }
    }

    public void UnlockCar8()
    {
        if (!car8Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car8Price);
            PlayerPrefs.SetInt("CarSkin", 8);
            car8Unlocked = true;
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 8);
            MMVibrationManager.Haptic(HapticTypes.Success);

        }
    }

    public void UnlockCar9()
    {
        if (!car9Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car9Price);
            PlayerPrefs.SetInt("CarSkin", 9);
            car9Unlocked = true;
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 9);
            MMVibrationManager.Haptic(HapticTypes.Success);

        }
    }

    public void UnlockCar10()
    {
        if (!car10Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car10Price);
            PlayerPrefs.SetInt("CarSkin", 10);
            car10Unlocked = true;
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 10);
            MMVibrationManager.Haptic(HapticTypes.Success);

        }
    }

    public void UnlockCar11()
    {
        if (!car11Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car11Price);
            PlayerPrefs.SetInt("CarSkin", 11);
            car11Unlocked = true;
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 11);
            MMVibrationManager.Haptic(HapticTypes.Success);

        }
    }

    public void UnlockCar12()
    {
        if (!car12Unlocked)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - car12Price);
            PlayerPrefs.SetInt("CarSkin", 12);
            car12Unlocked = true;
            MMVibrationManager.Haptic(HapticTypes.Success);
        }
        else
        {
            PlayerPrefs.SetInt("CarSkin", 12);
            MMVibrationManager.Haptic(HapticTypes.Success);

        }
    }




}
