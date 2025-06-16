using UnityEngine;

public class PopupController : MonoBehaviour
{
    public void Open()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    public void Close()
    {
        gameObject.SetActive(false);
    }

}
