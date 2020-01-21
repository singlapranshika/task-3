using System;


namespace Singleton
{
	class Program
	{
	static void Main(string[] args)
		{
		Console.WriteLine(ping.Instance.function());
		}
	}
	public sealed class ping
	{
			private ping()
			{}
		private static ping instance=null;
		public static ping Instance
		{
			get
			{
			if(instance==null)
			{
			instance=new ping();
			}
			return instance;
			}
		}
		public String function()
		{
			return "hello";
		}
	}
}