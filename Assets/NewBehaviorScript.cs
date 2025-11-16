using UnityEngine;

public class NewBehaviorScript : Interactive
{
    private Color originalColor;
    private bool isBlue = false;

    public new void Interact()
    {
        if (!isBlue)
        {
            originalColor = GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = Color.blue;
            isBlue = true;
        }
        else
        {
            GetComponent<Renderer>().material.color = originalColor;
            isBlue = false;
        }
    }
}
