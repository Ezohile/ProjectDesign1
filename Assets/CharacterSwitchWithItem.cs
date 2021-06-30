using MoreMountains.CorgiEngine;
using System.Collections;
using UnityEngine;

public class CharacterSwitchWithItem : CharacterSwitchManager
{
    [SerializeField] string switchItem = "";

    protected override IEnumerator SwitchCharacter()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            var inventory = player.GetComponent<CharacterInventory>();
            if (inventory != null && inventory.MainInventory.GetQuantity(switchItem) > 0)
            {
                yield return base.SwitchCharacter();
            }
        }
        yield return null;
    }
}
