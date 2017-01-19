package com.retrofitdemo.michael.retrofitdemo.uitilties;

import android.app.AlertDialog;
import android.app.ProgressDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.widget.Toast;

import com.retrofitdemo.michael.retrofitdemo.R;

/**
 * Created by michael on 9/7/2016.
 */
public class DialogUitls {
    private static ProgressDialog mProgressDialog;

    public static void showProgressDialog(Context context, String title, String msg, int resourceIcon, boolean isCancle) {
        if(mProgressDialog != null)	return;

        mProgressDialog = new ProgressDialog(context);
        mProgressDialog.setProgressStyle(ProgressDialog.STYLE_SPINNER);
        mProgressDialog.setMessage("Loading...");
        mProgressDialog.show();
        mProgressDialog.setCancelable(isCancle);
    }

    public static void showProgressDialog(Context context, String msg, int resourceIcon, boolean isCancle) {
        showProgressDialog(context,"",  msg,  resourceIcon,  isCancle);
    }

    public static void closeProgressDialog() {
        if(mProgressDialog != null){
            mProgressDialog.dismiss();
        }
        mProgressDialog = null;
    }

    public static void showMessageInToast(Context context, String message, boolean isLong) {
        if (context != null) {
            Toast.makeText(context, message, isLong ? Toast.LENGTH_LONG : Toast.LENGTH_SHORT).show();
        }
    }

    public static void showErrorMessage(Context context){
        AlertDialog dialog = new AlertDialog.Builder(context).setTitle("Whoops")
                .create();
        dialog.setMessage(context.getString(R.string.error_msg));
        dialog.setButton("OK", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.dismiss();
            }
        });

        dialog.show();
    }
}
