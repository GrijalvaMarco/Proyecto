using System;
using Gtk;
using MySql.Data.MySqlClient;


public partial class NuevoForm : Gtk.Window
{
	private global::Gtk.VPaned vpaned1;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.Fixed fixed2;
	
	public NuevoForm (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "NuevoForm";
		this.Title = global::Mono.Unix.Catalog.GetString ("NuevoForm");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vpaned1 = new global::Gtk.VPaned ();
		this.vpaned1.CanFocus = true;
		this.vpaned1.Name = "vpaned1";
		this.vpaned1.Position = 190;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.vpaned1.Add (this.fixed1);
		global::Gtk.Paned.PanedChild w1 = ((global::Gtk.Paned.PanedChild)(this.vpaned1[this.fixed1]));
		w1.Resize = false;
		// Container child vpaned1.Gtk.Paned+PanedChild
		this.fixed2 = new global::Gtk.Fixed ();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		this.vpaned1.Add (this.fixed2);
		this.Add (this.vpaned1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 774;
		this.DefaultHeight = 501;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
}