using TMPro;
using UnityEngine;

public class FontController : MonoBehaviour
{
    public TMP_Text textComponent;
    public TMP_FontAsset newFont;

    void Start()
    {
        if (textComponent != null && newFont != null)
        {
            textComponent.font = newFont;
        }
    }

    public void ChangeFont()
    {
        if (textComponent != null && newFont != null)
        {
            textComponent.font = newFont;
        }
    }
}
