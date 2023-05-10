using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeepButtonSelected : MonoBehaviour
{
    public GameObject firstButtonSelected;
    public List<GameObject> menuButtons;
    public List<GameObject> cancelAndSwapButtons;
    public GameObject lastSelectedButton;

    void Start()
    {

        emptyAndSetSelectedGameObject(firstButtonSelected);
    }

    void Update()
    {

        GameObject selectedGameObject = EventSystem.current.currentSelectedGameObject;

        foreach (GameObject menuButton in menuButtons)
        {
            if (menuButton == selectedGameObject)
            {
                lastSelectedButton = menuButton;
            }

            if (!menuButtons.Contains(selectedGameObject) || !cancelAndSwapButtons.Contains(selectedGameObject))
            {

                emptyAndSetSelectedGameObject(lastSelectedButton);
            }
        }
    }

    void emptyAndSetSelectedGameObject(GameObject gameObjectToSelect)
    {

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(gameObjectToSelect);
    }

}
