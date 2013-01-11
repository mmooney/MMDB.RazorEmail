using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace System
{
	public static class JsonExtensions
	{
		public static string ToJson(this object obj, bool format = false)
		{
			if (format)
			{
				JsonSerializer serializer = new JsonSerializer();
				StringBuilder sb = new StringBuilder();
				using (var writer = new StringWriter(sb))
				{
					using (var jsonWriter = new JsonTextWriter(writer) { Formatting = Formatting.Indented })
					{
						serializer.Serialize(jsonWriter, obj);
						return sb.ToString();
					}
				}
			}
			else
			{
				JsonSerializer serializer = new JsonSerializer();
				StringBuilder sb = new StringBuilder();
				using (var writer = new StringWriter(sb))
				{
					serializer.Serialize(writer, obj);
					return sb.ToString();
				}
			}
		}
	}
}