using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
    public class Sentences
    {

        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public int EntryWord { get; set; }
    }
}
