﻿public class ReLaunchPower : Power
{

	protected override void OnPress(bool isDown)
	{
		if (!isDown && charges > 0 && !BallManager.IsLaunching)
		{
			BallManager.ReLaunch();
			base.OnPress(false);
		}
		
	}
}

