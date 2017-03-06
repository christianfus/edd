using System;
using System.Diagnostics;
using Gtk;
using System.Collections.Generic;



public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		Table Table = new Table (9, 10, true);

		IList<int> bolas = new List<int> ();
		for (int numero = 1; numero <= 90; numero++) {
			bolas.Add (numero);
			uint index = numero - 1;
			Button button = new Button ();
			button.Label = "" + numero;
			button.Visible = true;
			uint row = index / 10;
			uint column = index % 10;
			Table.Attach (button, column + 1, row, row + 1);
		}


		Table.Visible = true;
		vBoxMain.Add (Table);

		Random random = new Random ();

		buttonGoForward.Clicked += delegate {

			int randomIndex = Random.Next (bolas.Count);
			int bola = bolas [randomIndex];
			Console.WriteLine("Bola = " + bola);
			bolas.Remove(bola);
			if(bolas.Count == 0)
				buttonGoForward.Sensitive = false;

			Process.Start("espeak", bola.ToString());

			buttonGoForward.ModifyBg (StateType.Normal, new Gdk.Color(0,255,0));
		}

	private String tospeak(){

		
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}


}
