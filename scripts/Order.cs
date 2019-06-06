using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script by BlackMagic
 * Discord: Ryuko#9999
 * Mail: 25546@ma-web.nl  /  tobias2002@live.nl
 */

public class Order : MonoBehaviour {

    internal static int orderNumber;
    internal static bool placedOrder;
    


	// Use this for initialization
	void Start () {

        orderNumber = 0;
        placedOrder = false;
    }
	
	// Update is called once per frame
	void Update () {
		
        if(GameplayManager.OrderComplete == false)
        {

            if (orderNumber <= 0)
            {
                orderNumber = Random.Range(1, 9);
            }
            if (orderNumber >= 0)
            {
                if (!placedOrder)
                {
                    //Here are the orders with 1 item
                    if (orderNumber == 1)
                    {
                        GameplayManager.moonster = false;
                        GameplayManager.gropeWaffles = true;
                        GameplayManager.purRitos = true;
                        GameplayManager.spaceCake = true;
                        GameplayManager.cosmoCola = true;
                        GameplayManager.moontaindoow = true;
                        placedOrder = true;
                    }

                    if (orderNumber == 2)
                    {
                        GameplayManager.moontaindoow = false;
                        GameplayManager.moonster = true;
                        GameplayManager.gropeWaffles = true;
                        GameplayManager.purRitos = true;
                        GameplayManager.spaceCake = true;
                        GameplayManager.cosmoCola = true;
                        placedOrder = true;
                    }

                    if (orderNumber == 3)
                    {
                        GameplayManager.moonster = true;
                        GameplayManager.gropeWaffles = true;
                        GameplayManager.purRitos = true;
                        GameplayManager.spaceCake = true;
                        GameplayManager.cosmoCola = false;
                        GameplayManager.moontaindoow = true;
                        placedOrder = true;
                    }

                    //Here are the orders with 2 items
                    if (orderNumber == 4)
                    {
                        GameplayManager.gropeWaffles = false;
                        GameplayManager.moonster = false;
                        GameplayManager.purRitos = true;
                        GameplayManager.spaceCake = true;
                        GameplayManager.cosmoCola = true;
                        GameplayManager.moontaindoow = true;
                        placedOrder = true;
                    }

                    if (orderNumber == 5)
                    {
                        GameplayManager.cosmoCola = false;
                        GameplayManager.spaceCake = false;
                        GameplayManager.moonster = true;
                        GameplayManager.gropeWaffles = true;
                        GameplayManager.purRitos = true;
                        GameplayManager.moontaindoow = true;
                        placedOrder = true;
                    }

                    if (orderNumber == 6)
                    {
                        GameplayManager.moontaindoow = false;
                        GameplayManager.purRitos = false;
                        GameplayManager.moonster = true;
                        GameplayManager.gropeWaffles = true;
                        GameplayManager.spaceCake = true;
                        GameplayManager.cosmoCola = true;
                        placedOrder = true;
                    }

                    //Here are the orders with 3 items
                    if (orderNumber == 7)
                    {
                        GameplayManager.moonster = false;
                        GameplayManager.purRitos = false;
                        GameplayManager.spaceCake = false;
                        GameplayManager.gropeWaffles = true;
                        GameplayManager.cosmoCola = true;
                        GameplayManager.moontaindoow = true;
                        placedOrder = true;
                    }

                    if (orderNumber == 8)
                    {
                        GameplayManager.cosmoCola = false;
                        GameplayManager.spaceCake = false;
                        GameplayManager.gropeWaffles = false;
                        GameplayManager.moonster = true;
                        GameplayManager.purRitos = true;
                        GameplayManager.moontaindoow = true;
                        placedOrder = true;
                    }

                    if (orderNumber == 9)
                    {
                        GameplayManager.moontaindoow = false;
                        GameplayManager.purRitos = false;
                        GameplayManager.gropeWaffles = false;
                        GameplayManager.moonster = true;
                        GameplayManager.spaceCake = true;
                        GameplayManager.cosmoCola = true;
                        placedOrder = true;
                    }
                }
            }

        }

	}
}
