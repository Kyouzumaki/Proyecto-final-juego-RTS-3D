using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Renderer rendererObject;

    public Color defaultColor;
    public Color newColor;
    public bool colorChanged = false;

    void Start()
    {
         rendererObject = GetComponent<Renderer>();
        rendererObject.material.color = defaultColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            {
                if (!colorChanged)
                {
                    ChangeColorMetchod(newColor);
                }

                else
                {
                    ChangeColorMetchod(defaultColor);
                }
            }
        }

    }

    private void ChangeColorMetchod(Color colorToChange)
    {
        colorChanged = !colorChanged;

        rendererObject.material.color = colorToChange;
    }
}
