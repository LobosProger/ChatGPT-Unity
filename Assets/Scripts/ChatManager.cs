using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ChatGPTWrapper;

public class ChatManager : MonoBehaviour
{
	[SerializeField] private ChatBox chatBoxForUser;
	[SerializeField] private ChatBox chatBoxForBot;

	[SerializeField] private TMP_InputField inputField;
	[SerializeField] private GameObject scrollViewContent;

	private ChatGPTConversation chatGPT;

	private void Start()
	{
		chatGPT = GetComponent<ChatGPTConversation>();
	}

	public void SendMessage()
	{
		// If the user has not entered any characters in the message sending window, do not send
		if (inputField.text != "")
		{
			// Get the value from the message sending window
			string message = inputField.text;
			inputField.text = "";

			// Create a visual element to display the message on the screen
			ChatBox chatBox = Instantiate(chatBoxForUser);
			chatBox.transform.SetParent(scrollViewContent.transform, false);
			chatBox.ShowMessage(message);
			chatGPT.SendToChatGPT(message);
		}
	}

	// Function to receive messages from ChatGPT, where message is the argument and receives the response from ChatGPT
	public void ReceiveMessage(string message)
	{
		// Create a visual element to display the message on the screen
		ChatBox chatBox = Instantiate(chatBoxForBot);
		chatBox.transform.SetParent(scrollViewContent.transform, false);
		chatBox.ShowMessage(message);
	}
}
