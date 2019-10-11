using System;
using System.Collections.Generic;

namespace SamuraiModel
{
    public partial class Quotes
    {
        public int Id { get; set; }
        public int SamuraiId { get; set; }
        public string Text { get; set; }

        public Samurais Samurai { get; set; }
    }
}
