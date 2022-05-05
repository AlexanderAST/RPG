using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Indicators : MonoBehaviour
{
    public Image healthBar, foodBar;
    public float healthAmount = 100;
    public float foodAmount = 100;
   
  

    public float secondsToEmptyFood = 60f;
  
    public float secondsToEmptyHealth = 60f;
    void Start()
    {
        healthBar.fillAmount = healthAmount / 100;
        foodBar.fillAmount = foodAmount / 100;
       
    }

   
    void Update()
    {
        if (foodAmount > 0)
        {
            foodAmount -= 100 / secondsToEmptyFood * Time.deltaTime;
            foodBar.fillAmount = foodAmount / 100;
        }
        

        if (foodAmount <= 0)
        {
            healthAmount -= 100 / secondsToEmptyHealth * Time.deltaTime;
        }
        if (healthBar.fillAmount == 0)
        {
            SceneManager.LoadScene("Die");
        }
        
        healthBar.fillAmount = healthAmount / 100;

        
    }
    public void ChangeFoodAmount(float changeValue)
    {
        foodAmount += changeValue;
    }
    public void ChangeHealthmount(float changeValue)
    {
        healthAmount += changeValue;
    }

}