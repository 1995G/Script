using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using PureMVC.Patterns;
public class TestMediatorTest : Mediator {

	public new const string NAME="TestMediatorTest";
	private Text levelText;
	private Button levelUpButton;

	public TestMediatorTest(GameObject root) : base(NAME)
	{
		levelText = GameUnity.GetChildComponent<Text> (root, "Text/LevelText");
		levelUpButton = GameUnity.GetChildComponent<Button> (root, "LevelUpButton");
		levelUpButton.onClick.AddListener (OnClickLevelUpButton);
	}

	private void OnClickLevelUpButton()
	{
		SendNotification (NotificationConstant.LevelUp);
	}
	public override IList<string> ListNotificationInterests()
	{
		IList<string> list = new List<string> ();
		list.Add (NotificationConstant.LevelChange);
		return list;
	}
	public override void HandleNotification(PureMVC.Interfaces.INotification notification)
	{
		switch (notification.Name) {
		case NotificationConstant.LevelChange:
			CharacterInfo ci = notification.Body as CharacterInfo;
			levelText.text = ci.Level.ToString ();
			break;
		default:
			break;
		}
	}
}