using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private TMP_Text _textField;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _expText;
    [SerializeField] private TMP_Text _coinText;

    public void UpdateTextField(string message)
    {
        StopAllCoroutines();
        _textField.text = message;
        StartCoroutine(ClearDisplay());
    }

    public void UpdateScore(int value)
    {
        _scoreText.text = "Score: " + value.ToString();
    }

    public void UpdateHealth(int health)
    {
        _healthText.text = "Health: " + health.ToString();
    }

    public void UpdateExperience(int experience)
    {
        _expText.text = "Exp: " + experience.ToString();
    }

    public void UpdateGold(int value)
    {
        _coinText.text = "Coin: " + value;
    }




    IEnumerator ClearDisplay()
    {
        yield return new WaitForSeconds(3);
        _textField.text = "";       
    }
}
