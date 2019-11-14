using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum eCardSate
{
    drawpile,
    tableau,
    target,
    discard

}
public class CardProspector : Card
{
    [Header("Set Dynamically: CardPospector")]
    public eCardSate state = eCardSate.drawpile;
    public List<CardProspector> hiddenBy = new List<CardProspector>();
    public int layoutID;
    public SlotDef slotDef;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
