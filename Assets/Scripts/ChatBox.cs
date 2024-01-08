using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChatBox : MonoBehaviour
{
	// Visual element for displaying bot and user messages

	// Set the component for displaying messages on the screen
	[SerializeField] private TextMeshProUGUI textMessage;

	// Function to display a message on the screen
	public void ShowMessage(string text) => textMessage.text = text;
}
