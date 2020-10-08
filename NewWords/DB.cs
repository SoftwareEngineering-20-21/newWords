using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace NewWords
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageWords> Dictionary { get; set; }

        public DbSet<Word> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=wordsApp.db");
    }
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }

    }
    public class Language
    {
        public int id { get; set; }
        public string code { get; set; }
    }
    public class Word
    {
        public int id { get; set; }
    }
    public class LanguageWords
    {
        public int id { get; set; }
        public int langId { get; set; }
        public string definition { get; set; }
        public string word { get; set; }
        public int word_id { get; set; }
    }
}
