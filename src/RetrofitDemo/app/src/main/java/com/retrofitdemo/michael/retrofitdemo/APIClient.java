package com.retrofitdemo.michael.retrofitdemo;

import com.retrofitdemo.michael.retrofitdemo.model.Movie;

import java.util.List;

import retrofit.Callback;
import retrofit.http.GET;

/**
 * Created by michael on 11/22/2016.
 */
public interface APIClient {

    @GET("/api/movies")
    void movies(Callback<List<Movie>> callback);
}
