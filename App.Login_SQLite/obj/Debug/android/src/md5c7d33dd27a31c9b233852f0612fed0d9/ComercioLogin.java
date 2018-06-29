package md5c7d33dd27a31c9b233852f0612fed0d9;


public class ComercioLogin
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Propishare.ComercioLogin, Propishare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ComercioLogin.class, __md_methods);
	}


	public ComercioLogin () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ComercioLogin.class)
			mono.android.TypeManager.Activate ("Propishare.ComercioLogin, Propishare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
