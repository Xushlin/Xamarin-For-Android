package com.retrofitdemo.michael.retrofitdemo;

import android.app.Application;

import com.squareup.okhttp.OkHttpClient;

import net.danlew.android.joda.JodaTimeAndroid;

import retrofit.RequestInterceptor;
import retrofit.RestAdapter;
import retrofit.client.OkClient;

/**
 * Created by michael on 11/22/2016.
 */
public class RetrofitdemoApplication extends Application {

    private static RetrofitdemoApplication sInstance;
    public APIClient myApiClient;
    private RestAdapter mRestAdapter;

//    private static final String baseUrl = "http://testweb2.sprakservice.se:8085";
    private static final String baseUrl = "http://192.168.1.123:8090";

    @Override
    public void onCreate() {
        super.onCreate();

        sInstance = this;
        JodaTimeAndroid.init(this);

        OkHttpClient client = new OkHttpClient();
        mRestAdapter = new RestAdapter.Builder()
                .setEndpoint(baseUrl)
                .setClient(new OkClient(client))
                .build();

        myApiClient = mRestAdapter.create(APIClient.class);

    }

    public static synchronized RetrofitdemoApplication getInstance() {
        return sInstance;
    }
}

