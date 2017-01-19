package com.retrofitdemo.michael.retrofitdemo.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

/**
 * Created by michael on 11/22/2016.
 */
public class Movie {
    @SerializedName("DetailUrl")
    @Expose
    public String DetailUrl ;
    @SerializedName("Name")
    @Expose
    public String Name ;
    @SerializedName("Description")
    @Expose
    public String Description;
    @SerializedName("Image")
    @Expose
    public String Image ;
    @SerializedName("Grade")
    @Expose
    public String Grade ;
    @SerializedName("Director")
    @Expose
    public String Director ;
    @SerializedName("Story")
    @Expose
    public String Story ;
    @SerializedName("Actor")
    @Expose
    public String Actor;

    public String getDetailUrl() {
        return DetailUrl;
    }

    public void setDetailUrl(String detailUrl) {
        DetailUrl = detailUrl;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getDescription() {
        return Description;
    }

    public void setDescription(String description) {
        Description = description;
    }

    public String getImage() {
        return Image;
    }

    public void setImage(String image) {
        Image = image;
    }

    public String getGrade() {
        return Grade;
    }

    public void setGrade(String grade) {
        Grade = grade;
    }

    public String getDirector() {
        return Director;
    }

    public void setDirector(String director) {
        Director = director;
    }

    public String getStory() {
        return Story;
    }

    public void setStory(String story) {
        Story = story;
    }

    public String getActor() {
        return Actor;
    }

    public void setActor(String actor) {
        Actor = actor;
    }
}
