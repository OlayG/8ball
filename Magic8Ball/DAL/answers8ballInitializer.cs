using Magic8Ball.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Magic8Ball.DAL
{
    public class answers8ballInitializer : DropCreateDatabaseIfModelChanges<Magic8BallContext>
    {
        protected override void Seed(Magic8BallContext context)
        {
            var _8ballAnswers = new List<answers8ball>
            {
                new answers8ball {Message = "It is certain" },
                new answers8ball {Message = "It is decidedly so" },
                new answers8ball {Message = "Without a doubt" },
                new answers8ball {Message = "Yes, definitely" },
                new answers8ball {Message = "You may rely on it" },
                new answers8ball {Message = "As I see it, yes" },
                new answers8ball {Message = "Most likely" },
                new answers8ball {Message = "Outlook good" },
                new answers8ball {Message = "Yes" },
                new answers8ball {Message = "Signs point to yes" },
                new answers8ball {Message = "Reply hazy try again" },
                new answers8ball {Message = "Ask again later" },
                new answers8ball {Message = "Better not tell you now" },
                new answers8ball {Message = "Cannot predict now" },
                new answers8ball {Message = "Concentrate and ask again" },
                new answers8ball {Message = "Don't count on it" },
                new answers8ball {Message = "My reply is no" },
                new answers8ball {Message = "My sources say no" },
                new answers8ball {Message = "Outlook not so good" },
                new answers8ball {Message = "Very doubtful" }
            };
            _8ballAnswers.ForEach(ans => context.answers8balls.Add(ans));
            context.SaveChanges();
        }
    }
}