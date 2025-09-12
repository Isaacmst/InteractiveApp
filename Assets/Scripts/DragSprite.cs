using UnityEngine;
using UnityEngine.EventSystems;

public class DragSprite : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector3 offset;
    private Canvas canvas;

    void Start()
    {
        canvas = FindFirstObjectByType<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = new Vector3(eventData.position.x, eventData.position.y, 0);
        offset = transform.position - GetMouseWorldPosition(mousePosition);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = new Vector3(eventData.position.x, eventData.position.y, 0);
        transform.position = GetMouseWorldPosition(mousePosition) + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Opcional: Agrega lógica al soltar, como limitar posición
    }

    private Vector3 GetMouseWorldPosition(Vector3 mousePosition)
    {
        return canvas.GetComponent<RectTransform>().InverseTransformPoint(mousePosition);
    }
}