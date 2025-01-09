using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ButtonShop : ButtonBase
{

    private static bool isOpenShop=false;
   
    [SerializeField] private GameObject shopPanel;

    private void Awake()
    {
        LoadGameObject();
    }
    void LoadGameObject()
    {
        shopPanel = FindGameObjectByNameHide.FindGameObjectByName(TagInGame.pnShop);

    }

    // Start is called before the first frame update
    protected override void OnClick()
    {
        OpenShop();
    }

    protected void OpenShop()
    {
        if (!isOpenShop)
        {
            isOpenShop = true;
            Debug.Log("hirn thi shop");
            shopPanel.SetActive(true);
        }
        else
        {
            isOpenShop= false;
            Debug.Log("tawt shop ra shop");
            shopPanel.SetActive(false);
        }
    }
}