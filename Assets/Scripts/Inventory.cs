using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour, IHasChanged {

    [SerializeField]
    Transform slots;

    [SerializeField]
    Text inventoryText;

	// Use this for initialization
	void Start () {
	    HasChanged();
	}

    public void HasChanged()
    {
        var builder = new StringBuilder();
        builder.Append(" - ");
        foreach (Transform slotTransform in slots)
        {
            GameObject item = slotTransform.GetComponent<Slot>().Item;
            
            if (item)
            {
                builder.Append(item.name);
                builder.Append(" - ");
            }        
        }
        inventoryText.text = builder.ToString();
    }
}

namespace UnityEngine.EventSystems
{
    public interface IHasChanged : IEventSystemHandler
    {
        void HasChanged();
    }

}