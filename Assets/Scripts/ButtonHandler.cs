using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void OnButtonClick(string buttonName)
    {
        Debug.Log("Botón presionado: " + buttonName);
    }
}