using System.Collections.Generic;

namespace GameEntities;

public class Armor
{
    //properties
    public ArmorType Type { get; set; }
    public List<ElementalResist> ResistStatus {get; set; }
    public int Level { get; set; }
    public int DefStatus { get; private set; }

    //methods
    public void TakeDamage(int damageReceived){
        DefStatus -= damageReceived;
    }
}