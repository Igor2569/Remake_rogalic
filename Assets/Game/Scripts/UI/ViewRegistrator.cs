using StarSmithGames.Core;
using StarSmithGames.Go;

using System.Linq;

namespace Game.UI
{
	public class ViewRegistrator : Registrator<IWindow>
    {
		public bool IsAnyWindowShowing()
		{
			return registers.Any((x) => x.IsShowing);
		}
		public bool IsAllHided()
		{
			return registers.All((x) => !x.IsShowing);
		}

		public void Show<T>() where T : class, IWindow
		{
			GetAs<T>().Show();
		}
		public void Hide<T>() where T : class, IWindow
		{
			GetAs<T>().Hide();
		}

		public void HideAll()
		{
			for (int i = 0; i < registers.Count; i++)
			{
				registers[i].Hide();
			}
		}
	}
}