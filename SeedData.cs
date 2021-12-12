namespace Portfolio
{
    public static class SeedData
    {
        public static void Initialize(PortfolioContext db)
        {
            var projects = new Project[]
            {
                new Project() 
                { 
                    Name = "Defer", 
                    Description = "Defer is a card game made in Unity 3D", 
                    ImageUrl = "images/projects/defer.png"
                },
                new Project() 
                { 
                    Name = "Elevator", 
                    Description = "Simple elevator simulation made in Java Swing", 
                    ImageUrl = "images/gminaWierzbno/gminaWierzbno.png"
                },
                new Project() 
                { 
                    Name = "Car forum", 
                    Description = "Made in Java with Springboot, thymeleaf, bootstrap", 
                    ImageUrl = "images/gminaWierzbno.png"
                },
                new Project()
                {
                    Name = "TCP multichat",
                    Description = "Java TCP multichat with telnet",
                    ImageUrl = "images/gminaWierzbno/gminaWierzbno.png"
                },
                new Project() 
                { 
                    Name = "Phone forum", 
                    Description = "Phone forum made in php, js, jquery", 
                    ImageUrl = "images/gminaWierzbno/gminaWierzbno.png"
                },
                new Project() 
                { 
                    Name = "Car rental", 
                    Description = "Car rental webpage made in node, react and mysql", 
                    ImageUrl = "images/gminaWierzbno/gminaWierzbno.png"
                },
                new Project() 
                { 
                    Name = "Guess number", 
                    Description = "Simple number guessing game in Java with JavaFX", 
                    ImageUrl = "images/gminaWierzbno/gminaWierzbno.png"
                },
            };
            db.Projects.AddRange(projects);
            db.SaveChanges();
        }
    }
}