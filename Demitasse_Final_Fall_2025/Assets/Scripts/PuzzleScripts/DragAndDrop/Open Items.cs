using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class OpenItems : MonoBehaviour
{
    
    public List<PPiece> allItems;
    public GameObject itemGroupContainer;
    public int itemSize;

    public void gfClick()
    {
        for (int i = 0; i < itemGroupContainer.transform.childCount; i++)
        {
            Destroy(itemGroupContainer.transform.GetChild(i).gameObject);
        }

        for (int i = 0; i < itemSize; i++)
        {
            // creating a new gameobj in the scene
            // selecting random item type/identity from the list within the chest(containter) full of scriptable obj data

            var lootItem = new GameObject();
            var itemIcon = lootItem.AddComponent<Image>();
            var itemData = lootItem.AddComponent<DragDropManager>();

            // add a button and listener to the button calling 'lootClick' function in the lootData class 
            var randomItemBtn = lootItem.AddComponent<Button>();
            randomItemBtn.onClick.AddListener(itemData.itemClick);

            // assigning the randomly selected loot type/identity from the scripobj to the new gameobj
            lootItem.GetComponent<DragDropManager>().currentPiece = allItems[Random.Range(0, allItems.Count)];
            itemIcon.sprite = itemData.currentPiece.icon;

            // assign those items to the container (within the grid layout group) in the scene
            lootItem.transform.SetParent(itemGroupContainer.transform);
        }


    }

}

