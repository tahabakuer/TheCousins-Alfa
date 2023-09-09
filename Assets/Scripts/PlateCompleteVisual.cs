using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlateCompleteVisual : MonoBehaviour
{
    [Serializable]
    public struct KitchenObjectSO_GameObject
    {
        public KitchenObjectSO kitchenObjectSO;
        public GameObject gameObject;
    }
    [SerializeField] private PlateKitchenObject plateKitchenObject;
    [SerializeField] private List<KitchenObjectSO_GameObject> kitchenObjectSO_GameObjectList;
    private void Start()
    {
        plateKitchenObject.OnIngredientAdded += PlateKitchenObject_OnIngredientAdded;

        foreach (KitchenObjectSO_GameObject kitchenObjectSOGameObject in kitchenObjectSO_GameObjectList)
        {
            kitchenObjectSOGameObject.gameObject.SetActive(false);
        }
    }

    private void PlateKitchenObject_OnIngredientAdded(object sender, PlateKitchenObject.OnInGredientAddedEventArgs e)
    {
        foreach (KitchenObjectSO_GameObject kitchenObjectSGameObject in kitchenObjectSO_GameObjectList)
        {
            if (kitchenObjectSGameObject.kitchenObjectSO==e.kitchenObjectSO)
            {
                kitchenObjectSGameObject.gameObject.SetActive(true);
            }
        }
    }
}
