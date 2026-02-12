using UnityEngine;
using TMPro; 

public class Variables : MonoBehaviour
{
    //Declarar variables 

    public string myName = "Juan";
    public int _edad = 17;

    [SerializeField] private TMP_InputField _imputfield;
    [SerializeField] private TMP_Text _saludo;
  


    // Update is called once per frame
    void Update()
    {
        
     
        _saludo.text = "hola" + myName;
    }
}
