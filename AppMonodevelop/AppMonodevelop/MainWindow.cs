using System;
using Gtk;
using System.IO;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected virtual void OnButtonLimpiarClicked(object sender, System.EventArgs e)
	{
		textview1.Buffer.Text = "";
	}

	protected virtual void OnButtonMayusClicked(object sender, System.EventArgs e)
	{
		textview1.Buffer.Text = textview1.Buffer.Text.ToUpper();
	}

	protected virtual void OnButtonMinusClicked(object sender, System.EventArgs e)
	{
		textview1.Buffer.Text = textview1.Buffer.Text.ToLower();
	}

	protected virtual void OnButtonGuardarClicked(object sender, System.EventArgs e)
	{
		StreamWriter sw = new StreamWriter("Test.txt");
		sw.Write(textview1.Buffer.Text); 
		textview1.Buffer.Text = "Guardado en fichero !"; 
		sw.Close();
	}
	
}
