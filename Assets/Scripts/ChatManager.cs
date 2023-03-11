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
		if (inputField.text != "")
		{
			string message = inputField.text;
			inputField.text = "";

			ChatBox chatBox = Instantiate(chatBoxForUser);
			chatBox.ShowMessage(message);
			chatBox.transform.SetParent(scrollViewContent.transform, false);
			chatGPT.SendToChatGPT(message);
		}
	}

	public void ReceiveMessage(string message)
	{
		ChatBox chatBox = Instantiate(chatBoxForBot);
		chatBox.transform.SetParent(scrollViewContent.transform, false);
		chatBox.ShowMessage(message);
	}
}
