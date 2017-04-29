using System;
using System.IO;
using System.Net;
using UnityEngine;

namespace Cross
{
	public class DownLoadURLImpl : IURLReq
	{
		protected string m_url;

		protected string m_dataFormat = "text";

		protected string m_method = "get";

		protected string m_contentType = "application/x-www-form-urlencoded";

		protected string m_data = null;

		protected HttpWebRequest m_request;

		protected byte[] m_loadedData;

		protected StreamReader m_reader;

		protected Stream m_response;

		protected int m_length;

		protected static GameObject m_loaderObj = null;

		protected static DownerBehavior m_loader = null;

		public string url
		{
			get
			{
				return this.m_url;
			}
			set
			{
				this.m_url = value;
			}
		}

		public string contentType
		{
			get
			{
				return this.m_contentType;
			}
			set
			{
				this.m_contentType = value;
			}
		}

		public string dataFormat
		{
			get
			{
				return this.m_dataFormat;
			}
			set
			{
				string text = value.ToLower();
				bool flag = text.IndexOf("text") >= 0;
				if (flag)
				{
					this.m_dataFormat = "text";
				}
				else
				{
					bool flag2 = text.IndexOf("binary") >= 0;
					if (flag2)
					{
						this.m_dataFormat = "binary";
					}
					else
					{
						this.m_dataFormat = "text";
						DebugTrace.add(Define.DebugTrace.DTT_ERR, "Unsupported urlreq format: " + text);
					}
				}
			}
		}

		public string data
		{
			get
			{
				return this.m_data;
			}
			set
			{
				this.m_data = value;
			}
		}

		public string method
		{
			get
			{
				return this.m_method;
			}
			set
			{
				this.m_method = value.ToLower();
			}
		}

		public DownLoadURLImpl()
		{
			bool flag = DownLoadURLImpl.m_loader == null;
			if (flag)
			{
				DownLoadURLImpl.m_loaderObj = new GameObject();
				DownLoadURLImpl.m_loader = DownLoadURLImpl.m_loaderObj.AddComponent<DownerBehavior>();
			}
			this.m_url = this.url;
		}

		public void load(Action<IURLReq, object> onFin, Action<IURLReq, float> onProg, Action<IURLReq, string> onFail)
		{
			DownLoadURLImpl.m_loader.load(this.url, this.m_method, this.m_dataFormat, this.m_data, delegate(object result)
			{
				bool flag = onFin != null;
				if (flag)
				{
					onFin(this, result);
				}
			}, delegate(float progress)
			{
				bool flag = onProg != null;
				if (flag)
				{
					onProg(this, progress);
				}
			}, delegate(string err)
			{
				bool flag = onFail != null;
				if (flag)
				{
					onFail(this, err);
				}
			});
		}

		public void close()
		{
		}
	}
}
