using UnityEngine;

public class InventoryController : MonoBehaviour
{

    public SeedDisplay[] seeds;
    public CropDisplay[] crops;

   public void OpenClose()
    {
        if (UIController.instance.theShop.gameObject.activeSelf == false)
        {
            if (gameObject.activeSelf == false)
            {
                gameObject.SetActive(true);

                UpdatedDisplay();
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }   

    public void UpdatedDisplay()
    {
        foreach (SeedDisplay seed in seeds)
        {
            seed.UpdatedDisplay();
        }

        foreach (CropDisplay crop in crops)
        {
            crop.UpdateDisplay();
        }
    }
}
