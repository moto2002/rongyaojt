using GameFramework;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MuGame
{
	internal class a3_baotuUI : FloatUi
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			public static readonly a3_baotuUI.<>c <>9 = new a3_baotuUI.<>c();

			public static Action<GameObject> <>9__0_0;

			public static Action<GameObject> <>9__0_1;

			internal void <init>b__0_0(GameObject go)
			{
				SelfRole.fsm.Stop();
				SelfRole.moveToNPc(10, 1001, null, null);
				InterfaceMgr.getInstance().close(InterfaceMgr.A3_BAOTUUI);
			}

			internal void <init>b__0_1(GameObject go)
			{
				InterfaceMgr.getInstance().close(InterfaceMgr.A3_BAOTUUI);
			}
		}

		public override void init()
		{
			BaseButton arg_37_0 = new BaseButton(base.transform.FindChild("go"), 1, 1);
			Action<GameObject> arg_37_1;
			if ((arg_37_1 = a3_baotuUI.<>c.<>9__0_0) == null)
			{
				arg_37_1 = (a3_baotuUI.<>c.<>9__0_0 = new Action<GameObject>(a3_baotuUI.<>c.<>9.<init>b__0_0));
			}
			arg_37_0.onClick = arg_37_1;
			BaseButton arg_73_0 = new BaseButton(base.transform.FindChild("ok"), 1, 1);
			Action<GameObject> arg_73_1;
			if ((arg_73_1 = a3_baotuUI.<>c.<>9__0_1) == null)
			{
				arg_73_1 = (a3_baotuUI.<>c.<>9__0_1 = new Action<GameObject>(a3_baotuUI.<>c.<>9.<init>b__0_1));
			}
			arg_73_0.onClick = arg_73_1;
		}

		public override void onShowed()
		{
			base.transform.SetAsLastSibling();
		}
	}
}