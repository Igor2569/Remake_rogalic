using Game.Systems.GameplaySystem;

using StarSmithGames.Core;
using StarSmithGames.Go.AudioService;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Zenject;

namespace Game.UI
{
    public class UIButtonComponent : StarSmithGames.Go.UIButtonComponent
    {
		[Inject]
		private IAudioService audioService;

		[Inject]
		private GameplayConfig gameplayConfig;

		protected override void OnClicked()
		{
			base.OnClicked();

			audioService.PlaySound(gameplayConfig.buttonClicks.RandomItem());
		}
	}
}