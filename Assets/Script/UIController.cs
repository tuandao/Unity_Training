using UnityEngine;

public class UIController : MonoBehaviour
{

    public PopupController popupController;

    void Start()
    {
        CloseSetting();
    }

    void Update()
    {
        
    }

    public void OpenSetting()
    {
        popupController.Open();
    }
    public void CloseSetting()
    {
        popupController.Close();
    }


}
