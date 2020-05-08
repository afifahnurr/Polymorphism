using System;

	public class PrinterWindows
    {
		//properties
		public string Name {get; set;}
	
		//method
		public virtual void Show()
		{
		
		}
		public virtual void Print()
		{
		
		}
	}

	public class Epson : PrinterWindows
	{
		public override void Show()
		{
			Console.WriteLine("Epson display dimension : 10*11");
		}
		public override void Print()
		{
			Console.WriteLine("Epson printer printing....");
		}
	}

	public class Canon : PrinterWindows
	{
		public override void Show()
		{
			Console.WriteLine("Canon display dimension : 9.5*12");
		}
		public override void Print()
		{
			Console.WriteLine("Canon printer printing....");
		}
	}
	public class LaserJet : PrinterWindows
	{
		public override void Show()
		{
			Console.WriteLine("LaserJet display dimension : 12*12");
		}
		public override void Print()
		{
			Console.WriteLine("LaserJet printer printing....");
		}
	}