
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox8;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Button button4;
	private global::Gtk.Button button5;
	private global::Gtk.Button button6;
	private global::Gtk.Button button7;
	private global::Gtk.TextView textview1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox8 = new global::Gtk.VBox ();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button ();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		// Container child button4.Gtk.Container+ContainerChild
		global::Gtk.Alignment w1 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w2 = new global::Gtk.HBox ();
		w2.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w3 = new global::Gtk.Image ();
		w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_delete", global::Gtk.IconSize.Menu);
		w2.Add (w3);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w5 = new global::Gtk.Label ();
		w5.LabelProp = global::Mono.Unix.Catalog.GetString ("Limpiar");
		w5.UseUnderline = true;
		w2.Add (w5);
		w1.Add (w2);
		this.button4.Add (w1);
		this.hbox3.Add (this.button4);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button4]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.button5 = new global::Gtk.Button ();
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString ("Mayúscula");
		this.hbox3.Add (this.button5);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button5]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.button6 = new global::Gtk.Button ();
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = "Minúscula";
		this.hbox3.Add (this.button6);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button6]));
		w11.Position = 2;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.button7 = new global::Gtk.Button ();
		this.button7.CanFocus = true;
		this.button7.Name = "button7";
		this.button7.UseUnderline = true;
		// Container child button7.Gtk.Container+ContainerChild
		global::Gtk.Alignment w12 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w13 = new global::Gtk.HBox ();
		w13.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w14 = new global::Gtk.Image ();
		w14.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-harddisk", global::Gtk.IconSize.Menu);
		w13.Add (w14);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w16 = new global::Gtk.Label ();
		w16.LabelProp = global::Mono.Unix.Catalog.GetString ("_Guardar");
		w16.UseUnderline = true;
		w13.Add (w16);
		w12.Add (w13);
		this.button7.Add (w12);
		this.hbox3.Add (this.button7);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button7]));
		w20.Position = 3;
		w20.Expand = false;
		w20.Fill = false;
		this.vbox8.Add (this.hbox3);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hbox3]));
		w21.Position = 0;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.vbox8.Add (this.textview1);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.textview1]));
		w22.Position = 1;
		this.Add (this.vbox8);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 346;
		this.DefaultHeight = 386;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button4.Clicked += new global::System.EventHandler (this.OnButtonLimpiarClicked);
		this.button5.Clicked += new global::System.EventHandler (this.OnButtonMayusClicked);
		this.button6.Clicked += new global::System.EventHandler (this.OnButtonMinusClicked);
		this.button7.Clicked += new global::System.EventHandler (this.OnButtonGuardarClicked);
	}
}
