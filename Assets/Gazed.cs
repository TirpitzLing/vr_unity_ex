using UnityEngine;
using UnityEngine.EventSystems;

public class Gazed : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Color _originalColor;

    public Color highlightColor = Color.green;

    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        if (_renderer == null)
        {
            Debug.LogWarning("Gazed: No Renderer found on this GameObject.");
            return;
        }
        _originalColor = _renderer.sharedMaterial.color;
    }

    void Update()
    {
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_renderer != null)
        {
            _renderer.sharedMaterial.color = highlightColor;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (_renderer != null)
        {
            _renderer.sharedMaterial.color = _originalColor;
        }
    }
}