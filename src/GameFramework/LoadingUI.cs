using System;

namespace GameFramework
{
	public class LoadingUI : Baselayer, IBgLayerUI
	{
		public new virtual bool showBG
		{
			get
			{
				return false;
			}
		}

		public override float type
		{
			get
			{
				return (float)Baselayer.LAYER_TYPE_LOADING;
			}
		}
	}
}
