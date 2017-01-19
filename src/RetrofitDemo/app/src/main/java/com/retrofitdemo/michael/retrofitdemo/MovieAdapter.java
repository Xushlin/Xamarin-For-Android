package com.retrofitdemo.michael.retrofitdemo;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;


import com.retrofitdemo.michael.retrofitdemo.model.Movie;

import java.util.List;

/**
 * Created by michael on 9/7/2016.
 */
public class MovieAdapter extends BaseAdapter {
    private List<Movie> mMovies;
    private Context mContext;


    public MovieAdapter(Context context, List<Movie> movies) {
        mContext=context;
        mMovies=movies;
    }

    @Override
    public int getCount() {
        return mMovies.size();
    }

    @Override
    public Object getItem(int i) {
        return mMovies.get(i);
    }

    @Override
    public long getItemId(int i) {
        return i;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        View v = view;
        Movie item = mMovies.get(i);
        if (v == null)
        {
            LayoutInflater layoutInflater =(LayoutInflater)mContext.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            v=layoutInflater.inflate(R.layout.movie_item,null);
        }

        TextView name =(TextView) v.findViewById(R.id.txtName);
        TextView grade = (TextView) v.findViewById(R.id.txtGrade);
        TextView storyType = (TextView) v.findViewById(R.id.txtStory);
        TextView director =(TextView) v.findViewById(R.id.txtDirector);
        TextView actor =(TextView) v.findViewById(R.id.txtActor);

        ImageView image = (ImageView) v.findViewById(R.id.imageViewPicture);

        name.setText(item.getName());
        grade.setText(item.getGrade());
        storyType.setText(item.getStory());
        director.setText(item.getDirector());
        actor.setText(item.getActor());
        image.setImageResource(R.drawable.shawshank);

        return v;
    }
}
