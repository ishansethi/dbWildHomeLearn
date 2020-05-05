namespace HomeWildLearn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Title { get; set; }

        [StringLength(50)]
        public string Published_By { get; set; }

        [StringLength(100)]
        public string Blog_Image { get; set; }

        public string Blog_Content { get; set; }

        public DateTime? Published_Date { get; set; }
    }
}
