using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSelector : MonoBehaviour
{
    [SerializeField]
    private Sprite[] stratightSprites;  
    [SerializeField]
    private Sprite[] bendySprites;

    public Image toAssign;

    public void selectSPrite(Vector3 direction, Vector3 oldDirection)
    {
        transform.up = direction;
        if (direction == oldDirection)
        {
            toAssign.sprite = getRandomSprite(stratightSprites);
        }
        else
        {
            Vector3 corss = Vector3.Cross(direction, oldDirection);
            toAssign.sprite = getRandomSprite(bendySprites);
            if (corss.y > 0)
            {
                transform.localScale = Vector3.one;
            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }

    private Sprite getRandomSprite(Sprite[] textures)
    {
        int index = Random.Range(0, textures.Length);
        return textures[index];
    }

}
