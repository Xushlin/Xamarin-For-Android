using Android.App;
using Android.Content;
using Android.Widget;

namespace AndroidDemo.Common
{
public class DialogUitls {

	private static ProgressDialog _mProgressDialog;

	public static void ShowProgressDialog(Activity context, string msg="Loading",  string title="",bool isCancle=false) {
		if(_mProgressDialog != null)	return;
		
		_mProgressDialog = new ProgressDialog(context);
		_mProgressDialog.SetProgressStyle(ProgressDialogStyle.Spinner);
		_mProgressDialog.SetTitle(title);
        _mProgressDialog.SetMessage(msg);
        _mProgressDialog.SetCancelable(isCancle);
	    if (!context.IsFinishing)
	    {
	        _mProgressDialog.Show();
	    }
	}
	
    public static void CloseProgressDialog(Activity context) {
        if (!context.IsFinishing && _mProgressDialog != null)
        {
    		_mProgressDialog.Dismiss();
    	}
    	_mProgressDialog = null;
	}
}
}
