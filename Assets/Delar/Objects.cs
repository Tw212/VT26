using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;




    public enum Objects
    {
       Freespin,
       Kikare,
       Gun, 
       Map,
       Kompass,
       Palmträd,
       Skalle,
       Ratt, 
       Ship,
       Chest, 
       Papegoja
    }
    

public class Objectspawner : MonoBehaviour
{    
    [System.Serializable]
    public class SpelO
    {
        public Spelobject spelobject;
        public Sprite ObjectImage;
        public int multiplier;
    }
}
