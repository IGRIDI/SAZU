using AEIS.Models;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AEIS
{
    class MyDatabase
    {
        private MyContext ctx;
        private BindingList<Project> projects;
        private BindingList<Point> points;

        private MyDatabase()
        {
            try
            {
                ctx = new MyContext("name=LocalSQLiteConnectionString");
                ctx.Projects.Load();
                projects = ctx.Projects.Local.ToBindingList();
                ctx.Points.Load();
                points = ctx.Points.Local.ToBindingList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Ошибка БД");
                Application.Exit();
            }
        }

        private static readonly Lazy<MyDatabase> lazy = new Lazy<MyDatabase>(() => new MyDatabase());
        public static MyDatabase Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public BindingList<Project> GetProjects()
        {
            return projects;
        }

        public BindingList<Point> GetPoints()
        {
            return points;
        }

        public void TrySave()
        {
            try
            {
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Ошибка БД");
                Application.Exit();
            }
        }

        public void CreateProject(string name, DateTime usageStart)
        {
            var project = new Project() { Name = name, UsageStart = usageStart };
            ctx.Projects.Add(project);
            TrySave();
        }

        public void RemoveProject(int id)
        {
            RemoveProject(ctx.Projects.Where(p => p.Id == id).First());
        }

        public void RemoveProject(Project project)
        {
            ctx.Projects.Remove(project);
            TrySave();
        }

        public BindingList<Point> GetPointsForProject(int projectId)
        {
            return new BindingList<Point>(points.Where(p => p.Project.Id == projectId).ToList());
        }

        public void CreatePoint(int projectId, DateTime dateTime)
        {
            var point = new Point() { Project = projects.Where(p => p.Id == projectId).First(), DateTime = dateTime };
            ctx.Points.Add(point);
            TrySave();
        }

        public void RemovePoint(int id)
        {
            RemovePoint(ctx.Points.Where(p => p.Id == id).First());
        }

        public void RemovePoint(Point point)
        {
            ctx.Points.Remove(point);
            TrySave();
        }
    }
}
