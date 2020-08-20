using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace _11_5_Lab_dB_2_C_2HTML
{
    class SakilaFilmTable
    {
        class Actor
        {
            //n properties/ fields -- need to verify complete list of columns, # of keys, and data types
            [Key]
            public int film_id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public int year_released { get; set; }
            public int rental_duration { get; set; }
            public string rental_cost { get; set; }
            public int length { get; set; }
            public string replacement_cost { get; set; }
            public string rating { get; set; }










        }

    }
}
