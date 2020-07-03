using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task1.Enums;
using Task1.Models;

namespace Task1.DAL
{
    public class TaskInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            var tasks = new List<Task>();
            tasks.Add(new Task()
            {
                name = "t1_name",
                how = "t1_how",
                what = "t1_what",
                why = "t1_why",
                Files = new List<File>()
            });
            tasks.First().Files.Add(new File() { FileType = FileTypeEnum.Python, Name = "Name", Description = "desc", TaskId = 1});
            tasks.Add(new Task() { name = "t2_name", how = "t2_how", what = "t2_what", why = "t2_why", Files = new List<File>() });
            tasks.Add(new Task() { name = "t3_name", how = "t3_how", what = "t3_what", why = "t3_why", Files = new List<File>() });
            tasks.Add(new Task() { name = "t4_name", how = "t4_how", what = "t4_what", why = "t4_why", Files = new List<File>() });
            tasks.Add(new Task() { name = "t5_name", how = "t5_how", what = "t5_what", why = "t5_why", Files = new List<File>() });

            var stories = new List<Story>();
            stories.Add(new Story()
            {
                name = "myStory",
                description = "test",
                Tasks = tasks
            });

            //tasks.ForEach(t => context.Tasks.Add(t));
            stories.ForEach(s => context.Stories.Add(s));
            context.SaveChanges();
        }
    }
}