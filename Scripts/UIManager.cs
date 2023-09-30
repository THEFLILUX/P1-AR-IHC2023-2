using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenuCanvas;
    [SerializeField] private GameObject ItemsMenuCanvas;
    [SerializeField] private GameObject DrinksMenuCanvas;
    [SerializeField] private GameObject DessertMenuCanvas;
    [SerializeField] private GameObject ItemCanvas;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnItemsMenu += ActivateItemsMenu;
        GameManager.instance.OnDrinksMenu += ActivateDrinksMenu;
        GameManager.instance.OnDessertMenu += ActivateDessertMenu;
        GameManager.instance.OnItem += ActivateItem;
    }

    private void ActivateMainMenu(){
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
        ItemsMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ItemsMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        DrinksMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        DrinksMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        DrinksMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        DrinksMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        DessertMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        DessertMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        DessertMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        DessertMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ItemCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateItemsMenu(){
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        ItemsMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        DrinksMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        DrinksMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        DrinksMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        DrinksMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        DessertMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        DessertMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        DessertMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        DessertMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateDrinksMenu(){
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        ItemsMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        DrinksMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        DrinksMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        DrinksMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        DrinksMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        DessertMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        DessertMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        DessertMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        DessertMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateDessertMenu(){
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        MainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        ItemsMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        DrinksMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        DrinksMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        DrinksMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        DrinksMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        DessertMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        DessertMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        DessertMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        DessertMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateItem(){
        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        MainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);
        ItemsMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ItemsMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        DrinksMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        DrinksMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        DrinksMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        //DrinksMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        //DrinksMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        DessertMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        DessertMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        DessertMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
        //DessertMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        //DessertMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        ItemCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }

}
