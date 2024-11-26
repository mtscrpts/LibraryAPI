namespace LibraryAPI.Data
{
    public static class SeedData
    {
        public static void Seed(this LibraryApiDbContext context)
        {
            if (!context.Categories.Any())
            {
                var categories = new List<Category>()
                {
                    new Category()
                    {
                        Name = "Mystery",
                        Description = "Mystery is a genre of stories that involve a secret or crime that needs to be solved, usually by the end of the story."
                    },
                    new Category()
                    {
                        Name = "Fantasy",
                        Description = "Fantasy is a genre of speculative fiction which involves themes of the supernatural, magic, and imaginary worlds and creatures."
                    },
                    new Category()
                    {
                        Name = "Thriller",
                        Description = " Thriller is a genre of fiction with numerous, often overlapping, subgenres, including crime, horror, and detective fiction."
                    },
                    new Category()
                    {
                        Name = "Horror",
                        Description = "Horror is a genre of speculative fiction that is intended to disturb, frighten, or scare. Horror is often divided into the sub-genres of psychological horror and supernatural horror, which are in the realm of speculative fiction."
                    }
                };

                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            if(!context.Books.Any())
            {
                var books = new List<Book>()
                {
                    new Book()
                    {
                        CategoryId = 1,
                        Title = "Blood Betrayal",
                        Description = "A complex and timely mystery, Blood Betrayal is the stunning follow up to Blackwater Falls, proving once again that Ausma Zehanat Khan is a writer at",
                        Author = "Ausma Zehanat Khan",
                        Cover = "https://drive.google.com/thumbnail?id=14gIxvpZkJBREpohSJvk42DANSZdHkCyx",
                        Price = 1000
                    },
                    new Book()
                    {
                        CategoryId = 1,
                        Title = "Eight Very Bad Nights",
                        Description = "Curated by New York Times bestselling author Tod Goldberg, this collection of twelv",
                        Author = "Tod Goldberg",
                        Cover = "https://drive.google.com/thumbnail?id=1aIgu84EegvRFyUZtsLt2gI1mtNl5lT88",
                        Price = 1500
                    },
                    new Book()
                    {
                        CategoryId = 2,
                        Title = "The Hymn to Dionysus",
                        Description="A timely and timeless reimagining of the story of Dionysus, Greek God of ecstasy and madness, revelry and ruin, for readers of The Song of Achilles and Elektra.",
                        Author = "Natasha Pulley",
                        Cover = "https://drive.google.com/thumbnail?id=1aRCSYOhz7XY3uiieEZUQCvtTMKhoPnWZ",
                        Price = 450
                    },
                    new Book()
                    {
                        CategoryId = 2,
                        Title = "The Last Bloodcarver (The Last Bloodcarver, #1)",
                        Description = "The tantalizing romance of These Violent Delights meets the mechanical wonders of Cinder in The Last Bloodcarver, the first in a two-book debut -- wit",
                        Author = "Vanessa Le",
                        Cover = "https://drive.google.com/thumbnail?id=1cWlIFJtoDDjLq5zt3h8YBR3iRIUiIQDi",
                        Price = 867
                    },
                    new Book()
                    {
                        CategoryId = 3,
                        Title = "The Silent Patient",
                        Description = "The story focuses on a specific patient, Alicia Berenson, who, after murdering her husband, goes silent and doesn't speak a word. We follow her psychotherapist, Theo Faber, as he tries to figure out what keeps Alicia from talking and ends up uncovering a lot more.",
                        Author = "Alex Michaelides",
                        Cover = "https://drive.google.com/thumbnail?id=15o6bBBrUFmar5PwXA9SNGwcRRWUAMzly",
                        Price = 950
                    },
                     new Book()
                    {
                        CategoryId = 3,
                        Title = "The Silence of the Lambs",
                        Description = "It is about an FBI recruit named Clarice Starling who has to work with former cannibal and serial killer Hannibal Lecter to solve a series of murders committed by Buffalo Bill.",
                        Author ="Thomas Harris",
                        Cover = "https://drive.google.com/thumbnail?id=1fUr8quTD1_9KQ1mX0mPpS5csBDPSQFJT",
                        Price = 800
                     },
                       new Book()
                    {
                        CategoryId = 4,
                        Title = "The Conjuring",
                        Description = "In 1970, paranormal investigators and demonologists Lorraine (Vera Farmiga) and Ed (Patrick Wilson) Warren are summoned to the home of Carolyn (Lili Taylor) and Roger (Ron Livingston) Perron. The Perrons and their five daughters have recently moved into a secluded farmhouse, where a supernatural presence has made itself known. Though the manifestations are relatively benign at first, events soon escalate in horrifying fashion, especially after the Warrens discover the house's macabre history.",
                        Author ="Chad Hayes and Carey W. Hayes",
                        Cover = "https://drive.google.com/thumbnail?id=1fUr8quTD1_9KQ1mX0mPpS5csBDPSQFJT",
                        Price = 1200
                     }
                };

                context.Books.AddRange(books);
                context.SaveChanges();
            }
        }
    }
}
