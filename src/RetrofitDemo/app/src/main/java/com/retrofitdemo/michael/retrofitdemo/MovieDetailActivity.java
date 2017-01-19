package com.retrofitdemo.michael.retrofitdemo;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.TextView;
import com.google.gson.Gson;
import com.retrofitdemo.michael.retrofitdemo.model.Movie;

public class MovieDetailActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_movie_detail);

        Movie movie =new Gson().fromJson(getIntent().getStringExtra("movie"),Movie.class);

        BindData(movie);
    }

    public  void BindData(Movie movie)
    {
        TextView name = (TextView)findViewById(R.id.txtName);
        TextView grade = (TextView)findViewById(R.id.txtGrade);
        TextView storyType =(TextView)findViewById(R.id.txtStory);
        TextView director = (TextView)findViewById(R.id.txtDirector);
        TextView actor = (TextView)findViewById(R.id.txtActor);

        name.setText(movie.getName());
        grade.setText(movie.getGrade());
        storyType.setText(movie.getStory());
        director.setText(movie.getDirector());
        actor.setText(movie.getActor());
    }
}
