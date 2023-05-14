using Sirenix.OdinInspector;

using StarSmithGames.Core;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	[System.Serializable]
	public class Information
	{
		[TitleGroup("Information")]
		[HorizontalGroup("Information/Split", LabelWidth = 100)]
		[VerticalGroup("Information/Split/Left")]
		[PreviewField(ObjectFieldAlignment.Left, Height = 64)]
		[HideLabel]
		public Sprite portrait;

		[VerticalGroup("Information/Split/Right")]
		[HorizontalGroup("Information/Split/Right/SplitName")]
		[LabelText("@NameLabel")]
		public string name;
		[VerticalGroup("Information/Split/Right")]
		[HorizontalGroup("Information/Split/Right/SplitName")]
		[HideLabel]
		public bool isNameId = true;

		[VerticalGroup("Information/Split/Right")]
		[HorizontalGroup("Information/Split/Right/SplitDescription")]
		[LabelText("@DescriptionLabel")]
		public string description;
		[VerticalGroup("Information/Split/Right")]
		[HorizontalGroup("Information/Split/Right/SplitDescription")]
		[HideLabel]
		public bool isDescriptionId = true;

		public bool IsHasPortrait => portrait != null;

		private string NameLabel => isNameId ? "Name Id" : "Name";
		private string DescriptionLabel => isDescriptionId ? "Description Id" : "Description";
	}
}