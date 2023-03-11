using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChatBox : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI textMessage;

	public void ShowMessage(string text) => textMessage.text = text;
}
