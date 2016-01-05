package md5824bc16c3f6f0a3cc8f930030c509f9a;


public class Sample2Activity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener,
		android.animation.ValueAnimator.AnimatorUpdateListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onAnimationUpdate:(Landroid/animation/ValueAnimator;)V:GetOnAnimationUpdate_Landroid_animation_ValueAnimator_Handler:Android.Animation.ValueAnimator/IAnimatorUpdateListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("CircularProgressButton.Sample2Activity, CircularProgressButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Sample2Activity.class, __md_methods);
	}


	public Sample2Activity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Sample2Activity.class)
			mono.android.TypeManager.Activate ("CircularProgressButton.Sample2Activity, CircularProgressButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);


	public void onAnimationUpdate (android.animation.ValueAnimator p0)
	{
		n_onAnimationUpdate (p0);
	}

	private native void n_onAnimationUpdate (android.animation.ValueAnimator p0);

	java.util.ArrayList refList;
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
