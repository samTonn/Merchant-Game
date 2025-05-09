using UnityEngine;

public class openDoor : MonoBehaviour
{
    public bool isOverDoor = false;
    public GameObject shopUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shopUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isOverDoor) {

            //play an animation of the E key or the A button above the door

            if  (Input.GetKeyDown("e")) {
                openShopUI();

                // Play a keydown animation and open the shop UI
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isOverDoor = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isOverDoor = false;
        shopUI.SetActive(false);
    }

    private void openShopUI() {
        if (shopUI.activeSelf) {
            shopUI.SetActive(false);
        } else {
            shopUI.SetActive(true);
        }
    }
}
