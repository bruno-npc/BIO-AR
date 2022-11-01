using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObj : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    void Update()
    {
        
        if(Input.touchCount > 0) //Reconhece que um dedo tocou na tela.
        {
            Touch t = Input.GetTouch(0); //Considere apenas o primeiro toque na tela.

            if(t.phase == TouchPhase.Moved) //Considera a movimentação do primeiro toque.
            {   
                Vector2 rotationObj = new Vector2(t.deltaPosition.y, t.deltaPosition.x * -1); //Posição do dedo em 2d, com correções de rotação.                                    
                transform.Rotate(rotationObj * speed * Time.deltaTime, Space.World); //Orientação em relação ao mundo.
            }
        }

    }
}
