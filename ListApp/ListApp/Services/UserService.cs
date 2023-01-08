using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListApp.Data;
using ListApp.Models;

namespace ListApp.Services
{
	public class UserService
	{
        public async Task<List<Person>> GetUsers()
        {
            try
            {
                var url = Constants.UsersUrl;
                var items = await App.RestService.GetResponse<List<Person>>(url);
                if (items != null)
                {
                    if (items.Any())
                    {
                        var users = new List<Person>();
                        foreach (var item in items)
                        {
                            if (!users.Where(x => x.id == item.id).Any())
                                users.Add(item);
                        }
                        if (users.Any()) return users;
                    }
                }
            }
            catch (Exception ex)
            {
                App.Log(ex.ToString());
            }
            return null;
        }
    }
}

