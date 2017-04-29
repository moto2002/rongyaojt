using System;

namespace Cross
{
	internal class _MsgProfiler
	{
		public uint MsgID = 0u;

		public uint MsgType = 0u;

		protected double _MaxProcTime = 0.0;

		protected double _MinProcTime = 4294967295.0;

		protected double _TotatlProcTime = 0.0;

		protected uint _ProcCount = 0u;

		public double AverageProcTime
		{
			get
			{
				return this._TotatlProcTime / this._ProcCount;
			}
		}

		public void onProc(double procTm)
		{
			this._ProcCount += 1u;
			this._TotatlProcTime += procTm;
			bool flag = procTm > this._MaxProcTime;
			if (flag)
			{
				this._MaxProcTime = procTm;
			}
			bool flag2 = procTm < this._MinProcTime;
			if (flag2)
			{
				this._MinProcTime = procTm;
			}
		}

		public string dumpProfile()
		{
			return string.Concat(new object[]
			{
				"  MsgType[ ",
				this.MsgType,
				" ]  MsgID[ ",
				this.MsgID,
				" ]  MaxProcTime[ ",
				this._MaxProcTime,
				" ]  MinProcTime[ ",
				this._MinProcTime,
				" ]  TotatlProcTime[ ",
				this._TotatlProcTime,
				" ]  ProcCount[ ",
				this._ProcCount,
				" ]  AverageProcTime[ ",
				this.AverageProcTime,
				" ]\n"
			});
		}
	}
}
