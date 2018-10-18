using System;
using System.Collections.Generic;
using System.Linq;
using Assignment4;
namespace Assignment4
{
    public class DataService
    {
        public List<Category> GetCategories()
        {
            using (var db = new NorthwindContext())
            {
                return db.Categories.ToList();
            }
        }

        public Category GetCategory(int i)
        {
            using (var db = new NorthwindContext())
            {
                foreach (var elem in db.Categories)
                {
                    if (elem.Id == i)
                    {
                        return elem;
                    }
                }
            }
            return null;
        }
        
        public Category CreateCategory(string a, string b)
        {
            using (var db = new NorthwindContext())
            {
                db.Categories.Add(new Category { Id = 9, Name = a, Description = b });
                db.SaveChanges();
                var cat = db.Categories.FirstOrDefault(x => x.Description == b);
                if(cat != null)
                {
                    return cat;
                }
                else return null;
            }
            
        }

        public bool DeleteCategory(int i)
        {
            using (var db = new NorthwindContext())
            {
                var record = db.Categories.FirstOrDefault(x => x.Id == i);
                if (record != null)
                {
                    var cat = record;
                    db.Categories.Remove(cat);
                    db.SaveChanges();
                    return true;
                }
                else return false;
            }

        }
    }
}
