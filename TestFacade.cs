using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class TestFacade :Facade {

	public TestFacade (GameObject canvas)
	{
	
		RegisterCommand (NotificationConstant.LevelUp, typeof(TestCommand));
		RegisterMediator (new TestMediatorTest(canvas));
		RegisterProxy (new TestProxy ());
	}
}
