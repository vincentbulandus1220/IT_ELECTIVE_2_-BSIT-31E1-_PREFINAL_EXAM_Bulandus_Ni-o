using Microsoft.AspNetCore.Mvc;
using MyMVCApp.Models;

namespace MyMVCApp.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<Question>
            {
                new Question
                {
                    Number = 1,
                    Text = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Options = new List<string>
                    {
                        "A. It makes C# code shorter",
                        "B. It prevents the application from restarting",
                        "C. Data persists after the application stops",
                        "D. It removes the need for MVC"
                    },
                    Answer = "C",
                    Explanation = "A database allows data to persist even after the application stops."
                },

                new Question
                {
                    Number = 2,
                    Text = "Which approach is used when an existing database generates EF Core entity classes?",
                    Options = new List<string>
                    {
                        "A. Code-First",
                        "B. Database-First",
                        "C. Model-First",
                        "D. Controller-First"
                    },
                    Answer = "B",
                    Explanation = "Database-First creates EF Core models from an existing database."
                },

                new Question
                {
                    Number = 3,
                    Text = "What is the primary purpose of Entity Framework Core?",
                    Options = new List<string>
                    {
                        "A. Create HTML automatically",
                        "B. Replace the Controller",
                        "C. Map objects in code to relational database data",
                        "D. Replace the C# compiler"
                    },
                    Answer = "C",
                    Explanation = "EF Core provides object-relational mapping between C# objects and relational database data."
                },

                new Question
                {
                    Number = 4,
                    Text = "Which EF Core component communicates with the database?",
                    Options = new List<string>
                    {
                        "A. DbContext",
                        "B. DbSetView",
                        "C. ControllerContext",
                        "D. RazorContext"
                    },
                    Answer = "A",
                    Explanation = "DbContext is the main EF Core class responsible for database communication."
                },

                new Question
                {
                    Number = 5,
                    Text = "What does the command 'dotnet ef dbcontext scaffold' primarily do?",
                    Options = new List<string>
                    {
                        "A. Deletes the database",
                        "B. Creates an MVC project",
                        "C. Generates EF Core models and DbContext from an existing database",
                        "D. Starts the application"
                    },
                    Answer = "C",
                    Explanation = "Scaffolding generates entity classes and a DbContext from an existing database."
                },

                new Question
                {
                    Number = 6,
                    Text = "Where is a database connection string commonly stored?",
                    Options = new List<string>
                    {
                        "A. Program.cs only",
                        "B. appsettings.json",
                        "C. Index.cshtml",
                        "D. Student.cs"
                    },
                    Answer = "B",
                    Explanation = "ASP.NET Core applications commonly store connection strings in appsettings.json."
                },

                new Question
                {
                    Number = 7,
                    Text = "A Student belongs to exactly one Section, while a Section contains many Students. What type of relationship is this?",
                    Options = new List<string>
                    {
                        "A. One-to-one",
                        "B. One-to-many",
                        "C. Many-to-many",
                        "D. Many-to-one only"
                    },
                    Answer = "B",
                    Explanation = "One Section can have many Students, making this a one-to-many relationship."
                },

                new Question
                {
                    Number = 8,
                    Text = "In 'public int SectionId { get; set; } public Section Section { get; set; }', what is SectionId?",
                    Options = new List<string>
                    {
                        "A. Primary key of Student",
                        "B. Foreign key referencing Section",
                        "C. Navigation property",
                        "D. Connection string"
                    },
                    Answer = "B",
                    Explanation = "SectionId identifies the related Section and acts as a foreign key."
                },

                new Question
                {
                    Number = 9,
                    Text = "What is the purpose of the navigation property 'public Section Section { get; set; }'?",
                    Options = new List<string>
                    {
                        "A. Store the database password",
                        "B. Represent the relationship to another entity",
                        "C. Create the database",
                        "D. Validate the student's name"
                    },
                    Answer = "B",
                    Explanation = "A navigation property represents the relationship between related entities."
                },

                new Question
                {
                    Number = 10,
                    Text = "What does .Include() generally do in EF Core?",
                    Options = new List<string>
                    {
                        "A. Delete Section",
                        "B. Load related Section data together with Students",
                        "C. Create Student",
                        "D. Validate data"
                    },
                    Answer = "B",
                    Explanation = "Include() loads related navigation-property data as part of the query."
                },

                new Question
                {
                    Number = 11,
                    Text = "Why use a ViewModel when displaying Student and Section information?",
                    Options = new List<string>
                    {
                        "A. Replace the database",
                        "B. Combine and shape the data needed by the view",
                        "C. Automatically create tables",
                        "D. Prevent controllers from using LINQ"
                    },
                    Answer = "B",
                    Explanation = "A ViewModel can contain and shape the specific data required by a view."
                },

                new Question
                {
                    Number = 12,
                    Text = "What is the benefit of Include() in 'var students = _context.Students.Include(s => s.Section).ToList();'?",
                    Options = new List<string>
                    {
                        "A. It loads the related Section navigation property",
                        "B. It creates the Section manually",
                        "C. It removes the foreign key",
                        "D. It prevents the query from accessing the database"
                    },
                    Answer = "A",
                    Explanation = "Include() loads the related Section information along with the Student records."
                },

                new Question
                {
                    Number = 13,
                    Text = "What type of validation happens in the browser before a request is sent?",
                    Options = new List<string>
                    {
                        "A. Database validation",
                        "B. Client-side validation",
                        "C. Server-side validation",
                        "D. EF migration"
                    },
                    Answer = "B",
                    Explanation = "Client-side validation can occur in the browser before the form is submitted."
                },

                new Question
                {
                    Number = 14,
                    Text = "Why is server-side validation necessary?",
                    Options = new List<string>
                    {
                        "A. Client-side validation can be bypassed",
                        "B. Client-side validation modifies the database",
                        "C. Validation only works with SQLite",
                        "D. Server-side validation cannot display messages"
                    },
                    Answer = "A",
                    Explanation = "Users can bypass browser-side validation, so the server must validate submitted data."
                },

                new Question
                {
                    Number = 15,
                    Text = "A school requires Student Number to be unique. Which rule should be used?",
                    Options = new List<string>
                    {
                        "A. Nullable",
                        "B. Unique",
                        "C. Same",
                        "D. Spaces"
                    },
                    Answer = "B",
                    Explanation = "A unique rule prevents duplicate Student Numbers."
                },

                new Question
                {
                    Number = 16,
                    Text = "What is the best reason for using a database-level unique constraint?",
                    Options = new List<string>
                    {
                        "A. It protects data integrity even if application validation is bypassed",
                        "B. It makes Razor pages faster",
                        "C. It removes the Controller",
                        "D. It automatically creates a ViewModel"
                    },
                    Answer = "A",
                    Explanation = "Database constraints provide an additional layer of protection for data integrity."
                },

                new Question
                {
                    Number = 17,
                    Text = "What is the purpose of try...catch in a controller?",
                    Options = new List<string>
                    {
                        "A. Load navigation properties",
                        "B. Catch and handle exceptions",
                        "C. Create database tables",
                        "D. Perform client-side validation"
                    },
                    Answer = "B",
                    Explanation = "try...catch allows an application to handle exceptions instead of failing unexpectedly."
                },

                new Question
                {
                    Number = 18,
                    Text = "Which middleware is commonly used for centralized exception handling?",
                    Options = new List<string>
                    {
                        "A. UseDatabase",
                        "B. UseExceptionHandler",
                        "C. UseValidationHandler",
                        "D. UseMvcDatabase"
                    },
                    Answer = "B",
                    Explanation = "UseExceptionHandler() is ASP.NET Core middleware for centralized exception handling."
                },

                new Question
                {
                    Number = 19,
                    Text = "A user requests /Student/999, but Student 999 does not exist. What is the appropriate response?",
                    Options = new List<string>
                    {
                        "A. Display the student anyway",
                        "B. 404 Not Found",
                        "C. Delete the student",
                        "D. Create the student"
                    },
                    Answer = "B",
                    Explanation = "A missing resource should normally result in a 404 Not Found response."
                },

                new Question
                {
                    Number = 20,
                    Text = "A Student already belongs to Section A for a subject, and the application attempts the same assignment again. What is the primary concern?",
                    Options = new List<string>
                    {
                        "A. Data integrity",
                        "B. HTML",
                        "C. CSS",
                        "D. Razor"
                    },
                    Answer = "A",
                    Explanation = "Duplicate assignments can violate the integrity rules of the application's data."
                }
            };

            return View(questions);
        }
    }
}