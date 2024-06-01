using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class dialogCON : MonoBehaviour
{
    public TMP_Text nameUi;
    public TMP_Text doalogUi;
    public Button continueButton;
    //定位对话
    private int index;
    private string[] dialog;
    private void Start()
    {
        continueButton.onClick.AddListener(continuedoalog);
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Show(string name, string[] dialog1)
    {
        Show();
        index = 0;
        nameUi = transform.Find("name/nametext").GetComponent<TMP_Text>();
        doalogUi = transform.Find("dialog").GetComponent<TMP_Text>();
        continueButton = transform.Find("continueButton").GetComponent<Button>();

        this.dialog = dialog1;
        nameUi.text = name;
        doalogUi.text = dialog[index];
    }
    private void continuedoalog()
    {
        print(index);
        index++;
        if (index >= dialog.Length)
        {//当索引超出的时候就结束
           gameObject.SetActive(false);
           return;
        }
        doalogUi.text = dialog[index];

    }
}
