using MauiNewsApp.Models.AppModels;

namespace MauiNewsApp.Helpers
{
    public static class OptionsList
    {
        public static List<Category> GetCategories()
        {
            List<Category> categoriesList = new List<Category>
            {
                new Category{name="breaking-news", IsSelected=false},
                new Category{name="business", IsSelected=false},
                new Category{name="entertainment", IsSelected=false},
                new Category{name="health", IsSelected=false},
                new Category{name="science", IsSelected=false},
                new Category{name="sports", IsSelected=false},
                new Category{name="technology", IsSelected=false},
            };
            
            return categoriesList;
        }

        public static List<NewsSources> GetSourcesNews()
        {

            List<NewsSources> NewsSourcesList = new List<NewsSources>
            {
                new NewsSources{ SourceTitle="CNN", SourceParameter="cnn" },
                new NewsSources{ SourceTitle="The New York Times", SourceParameter="nytimes" },
                new NewsSources{ SourceTitle="ESPN", SourceParameter="espn" },
                new NewsSources{ SourceTitle="Sky News", SourceParameter="skynews" },
                new NewsSources{ SourceTitle="Al Jazeera", SourceParameter="aljazeera" },
                new NewsSources{ SourceTitle="BBC", SourceParameter="bbc" },
                new NewsSources{ SourceTitle="The Guardian", SourceParameter="guardian" },
                new NewsSources{ SourceTitle="TIME.com", SourceParameter="time" },
                new NewsSources{ SourceTitle="FOX News ", SourceParameter="foxnews" },
                new NewsSources{ SourceTitle="TMZ", SourceParameter="tmz" },
            };

            return NewsSourcesList;
        }
    }
}
