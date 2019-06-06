using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Script by BlackMagic
 * Discord: Ryuko#9999
 * Mail: 25546@ma-web.nl  /  tobias2002@live.nl
 */

public class GameplayManager : MonoBehaviour
{
    public Text showText;

    private bool changeText;
    public Button orderButtonOne, orderButtonTwo, orderButtonThree, orderButtonFour, orderButtonFive, orderButtonSix, handOverOrder, nextOrder;
    internal static bool moonster;
    internal static bool moontaindoow;
    internal static bool cosmoCola;

    internal static bool spaceCake;
    internal static bool purRitos;
    internal static bool gropeWaffles;

    private static bool orderComplete;

    private static float timer;
    internal static bool OrderComplete;

    void Start()
    {
        changeText = false;

        orderButtonOne.onClick.AddListener(moontaindoowOrder);
        orderButtonTwo.onClick.AddListener(moonsterOrder);
        orderButtonThree.onClick.AddListener(cosmoColaOrder);
        orderButtonFour.onClick.AddListener(spaceCakeOrder);
        orderButtonFive.onClick.AddListener(purRitosOrder);
        orderButtonSix.onClick.AddListener(gropeWafflesOrder);
        handOverOrder.onClick.AddListener(handOver);
        nextOrder.onClick.AddListener(proceedToNextOrder);

        orderComplete = false;

        gropeWaffles = false;
        purRitos = false;
        spaceCake = false;
        cosmoCola = false;
        moontaindoow = false;
        moonster = false;

    }

    void Update()
    {
        
        if (!orderComplete)
        {
            timer = 0;

            
        }
        if (orderComplete)
        {

           

            timer += Time.deltaTime;

        }

    }

    void moonsterOrder()
    {
        moonster = true;
        print("click");
    }

    void moontaindoowOrder()
    {
        moontaindoow = true;
        print("click");
    }

    void cosmoColaOrder()
    {
        cosmoCola = true;
        print("click");
    }

    void spaceCakeOrder()
    {
        spaceCake = true;
        print("click");
    }

    void purRitosOrder()
    {
        purRitos = true;
        print("click");
    }

    void gropeWafflesOrder()
    {
        gropeWaffles = true;
        print("click");
    }

    void handOver()
    {
        if(moonster && moontaindoow && cosmoCola && spaceCake && purRitos && gropeWaffles)
        {
            
            orderComplete = true;

            print("Order Done");
        }
    }

    void proceedToNextOrder()
    {

        if (orderComplete)
        {
            orderComplete = false;
            Order.placedOrder = false;
            Order.orderNumber = 0;

        }
    }

    void OnGUI()
    {


            if (!orderComplete)
        {

                if (Order.orderNumber == 1)
                {
                    showText.text = "I would like a moonster";
                    //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "I would like a moonster");

                }
                else if (Order.orderNumber == 2)
                {
                    showText.text = "I would like a moontaindoow";
                    //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "I would like a moontaindoow");

                }
                else if (Order.orderNumber == 3)
                {
                    showText.text = "I would like a cosmoCola";
                    //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "I would like a cosmoCola");

                }
                else if (Order.orderNumber == 4)
                {
                    showText.text = "I would like a moonster and some gropeWaffles";

                    //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "I would like a moonster and some gropeWaffles");

                }
                else if (Order.orderNumber == 5)
                {
                    showText.text = "I would like a cosmoCola and a spaceCake";

                    //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "I would like a cosmoCola and a moonster");

                }
                else if (Order.orderNumber == 6)
                {
                    showText.text = "I would like a moontaindoow and some purRitos";

                    //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "I would like a moontaindoow and some purRitos");

                }
                else if (Order.orderNumber == 7)
                {
                    showText.text = "I would like a moonser, some purRitos and a spaceCake";
                    //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "I would like a moonser, some purRitos and a spaceCake");

                }
                else if (Order.orderNumber == 8)
                {
                    showText.text = "I would like a cosmoCola, a spaceCake and some gropeWaffles";
                    //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "I would like a cosmoCola, a spaceCake and some gropeWaffles");

                }
                else if (Order.orderNumber == 9)
                {
                    showText.text = "I would like a moontaindoow, some purRitos and some gropeWaffles";
                    //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "I would like a moontaindoow, some purRitos and some gropeWaffles");
                }
            
        }
        if (orderComplete)
        {
            
            if(timer < 10)
            {
                showText.text = "Thanks!";
                //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 100), "Thanks!");
            }
        }
    }
}

