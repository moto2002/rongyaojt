using Cross;
using GameFramework;
using System;

namespace MuGame
{
	internal class get_meris_res : RPCMsgProcesser
	{
		public override uint msgID
		{
			get
			{
				return 91u;
			}
		}

		public static get_meris_res create()
		{
			return new get_meris_res();
		}

		protected override void _onProcess()
		{
			(this.session as ClientSession).g_mgr.dispatchEvent(GameEvent.Create(91u, this, this.msgData, false));
		}
	}
}
