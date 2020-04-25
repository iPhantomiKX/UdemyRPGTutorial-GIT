using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using RPG.UI.Dragging;
using RPG.Inventories;

namespace RPG.UI.Inventories
{
    public class InventorySlotUI : MonoBehaviour, IDragContainer<Sprite>
    {
        // CONFIG DATA
        [SerializeField] InventoryItemIcon icon = null;

        // STATE
        int index;
        InventoryItem item;
        Inventory inventory;

        // PUBLIC
        public void Setup(Inventory inventory, int index)
        {
            this.inventory = inventory;
            this.index = index;
            //icon.SetItem(inventory.GetItemInSlot(index), inventory.GetNumberInSlot(index));
        }

        public int MaxAcceptable(Sprite item)
        {
            if (GetItem() == null)
            {
                return int.MaxValue;
            }
            return 0;
        }

        public void AddItems(Sprite item, int number)
        {
            print(gameObject + "Add Item " + item);
            icon.SetItem(item);
        }

        public Sprite GetItem()
        {
            print(gameObject + "Get Item " + icon.GetItem());
            return icon.GetItem();
        }

        public int GetNumber()
        {
            return 1;
        }

        public void RemoveItems(int number)
        {
            print(gameObject + "Remove Item " + icon.GetItem()); 
            icon.SetItem(null);
        }
    }
}