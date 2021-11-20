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

    float saturation = .4f;
    float value = .4f;

    int nutritionCutoff = 200;
    int lastNutrition = 60;

    public void selectSPrite(Vector3 direction, Vector3 oldDirection)
    {
       
        if (direction == oldDirection)
        {
            transform.up = direction;
            toAssign.sprite = getRandomSprite(stratightSprites);
        }
        else
        {
            if (oldDirection == Vector3.down)
                direction = -direction;

            Vector3 corss = Vector3.Cross(direction, oldDirection);
            toAssign.sprite = getRandomSprite(bendySprites);
            
            if (corss.z > 0)
            {
                
                transform.localScale = Vector3.one;
                transform.up = oldDirection;
            }
            else
            {   
                transform.localScale = new Vector3(-1, 1, 1);
                transform.up = oldDirection;
            }
        }
    }

    public void SetColor(int nutrition)
    {

        int nutritionValue = nutrition > nutritionCutoff ? nutritionCutoff : nutrition;
        float curentHue = (1f / (float)nutritionCutoff) * (float)nutritionValue;
        Color color = Color.HSVToRGB(curentHue, saturation, value );
        toAssign.color = color;
    }

    private Sprite getRandomSprite(Sprite[] textures)
    {
        int index = Random.Range(0, textures.Length);
        return textures[index];
    }

}
