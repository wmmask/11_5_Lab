using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace _11_5_Lab_dB_2_C_2HTML
{
    class SakilaFilmTable
    {
        //n properties/ fields -- need to verify complete list of columns, # of keys, and data types
        [Key]
        public int film_id { get; set; }  //SQL
        public string title { get; set; }  //Lab-- Title  SQL varchar(255)
        public string description { get; set; } //Lab--Desrciption   SQL--text L=16
        public string release_year { get; set; }  //Lab--year_released  SQL-- varchar(4)
        public byte language_id {get; set;}     //SQL--languade_id tinyint not null
        public byte original_language_id { get; set; }  //SQL--FK tinyint not null
        public byte rental_duration { get; set; }  //Lab--   SQL- tinyint
        public decimal rental_rate { get; set; } // Lab--rental_cost SQL--decimal(4,2)
        public Int16 length { get; set; } //Lab--length SQL--smallint
        public decimal replacement_cost { get; set; }    //Lab-- SQL--decimal(5,2)
        public string rating { get; set; }  //Lab  SQL--varchar(10)
        public DateTime last_update {get; set;} //SQL--datetime
        public string special_features { get; set; }
        

        public SakilaFilmTable(string title, string description, string release_year, byte rental_duration,
            decimal rental_rate, Int16 length, decimal replacement_cost, string rating)
        {
            this.title = title; //varchar(255)
            this.description = description; //text, L=16
            this.release_year = release_year; //varchar(4)
            this.language_id = 255; // language_id; //tinyint 
            this.original_language_id = 255;    // original_language_id;  //tinyint
            this.rental_duration = rental_duration; //tiny int
            this.rental_rate = rental_rate;   //decimal(4,2)
            this.length = length;   //smallint
            this.replacement_cost = replacement_cost; //decimal(5,2)
            this.rating = rating;   //varchar(10)
            this.last_update = DateTime.Now;    //datetime
            this.special_features = "Trailers";

        }
    }
}
