using UnityEngine;
using System.Collections;

public class Zoomable : MonoBehaviour
{
    public float MinimumScale;
    public float MaximumScale; 

    void Update()
    {
        float power = Input.GetAxis("Mouse ScrollWheel"); 
        if (power != 0f)
        {

            if (transform.localScale.x + power < MinimumScale)
            {
                transform.localScale = new Vector3(MinimumScale, MinimumScale);
            }
            else if (transform.localScale.x + power > MaximumScale)
            {
                transform.localScale = new Vector3(MaximumScale, MaximumScale);
            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x + power, transform.localScale.y + power);
            }
        }
    }


}
