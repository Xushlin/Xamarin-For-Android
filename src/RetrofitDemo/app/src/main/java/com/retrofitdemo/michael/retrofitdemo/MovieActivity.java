package com.retrofitdemo.michael.retrofitdemo;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.Toast;

import com.google.gson.Gson;
import com.retrofitdemo.michael.retrofitdemo.model.Movie;
import com.retrofitdemo.michael.retrofitdemo.uitilties.DialogUitls;

import java.util.List;

import retrofit.Callback;
import retrofit.RetrofitError;
import retrofit.client.Response;

public class MovieActivity extends AppCompatActivity {

    ListView mListView;
    List<Movie> mMovies;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_movie);

        mListView=(ListView) findViewById(R.id.listViewMovie);
        DialogUitls.showProgressDialog(MovieActivity.this, "Loading...",
                R.mipmap.ic_launcher, true);
        RetrofitdemoApplication.getInstance().myApiClient.movies(new Callback<List<Movie>>() {
            @Override
            public void success(List<Movie> moves, Response response) {
                mMovies=moves;
                mListView.setAdapter(new MovieAdapter(MovieActivity.this,moves));
                Response r=response;
                DialogUitls.closeProgressDialog();
            }
            @Override
            public void failure(RetrofitError error) {
                DialogUitls.closeProgressDialog();
                String s=error.getMessage();
                Toast.makeText(MovieActivity.this, "get data from API failuar",
                        Toast.LENGTH_LONG).show();
            }
        });

        mListView.setOnItemClickListener(new AdapterView.OnItemClickListener(){

            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
               Movie movie= (Movie) adapterView.getAdapter().getItem(i);

                Intent intent=new Intent(MovieActivity.this,MovieDetailActivity.class);
                intent.putExtra("movie",new Gson().toJson(movie));

                startActivity(intent);
            }
        });
    }
}
