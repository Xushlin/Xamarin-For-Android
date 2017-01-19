package com.retrofitdemo.michael.retrofitdemo;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.retrofitdemo.michael.retrofitdemo.model.Movie;

import java.util.List;

import retrofit.Callback;
import retrofit.RetrofitError;
import retrofit.client.Response;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button btnMovie=(Button)findViewById(R.id.btn_movie);
        btnMovie.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent=new Intent(MainActivity.this, MovieActivity.class);
                startActivity(intent);
            }
        });
//        RetrofitdemoApplication.getInstance().myApiClient.movies(new Callback<List<Movie>>() {
//            @Override
//            public void success(List<Movie> moves, Response response) {
//                List<Movie> move2=moves;
//                Response r=response;
//            }
//            @Override
//            public void failure(RetrofitError error) {
//                String s=error.getMessage();
//            }
//        });
    }
}
