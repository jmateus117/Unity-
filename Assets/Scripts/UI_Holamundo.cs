
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_Holamundo : MonoBehaviour
{

    [SerializeField] private  TextMeshProUGUI texteMeshPro;

    [SerializeField] private Button button;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (button != null)
        {
            button.onClick.AddListener(() => ChangeTextHM("!!holaMundo!!"));

        }
        
    }

    public void ChangeTextHM (string text)
    {
        if (texteMeshPro != null)
        {
            texteMeshPro.text = text;
        }
    }


}
