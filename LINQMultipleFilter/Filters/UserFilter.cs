using LINQMultipleFilter.Models;

namespace LINQMultipleFilter.Filters
{
    public class UserFilter
    {
        public int Filter_MinAge { get; set; }
        public int Filter_MaxAge { get; set; }
        public bool Filter_OnlyActive { get; set; }
        public string Filter_GeneralTextSeach { get; set; }

        public UserFilter()
        {
            Filter_MinAge = 0;
            Filter_MaxAge = 99;
            Filter_OnlyActive = false;
            Filter_GeneralTextSeach = string.Empty;
        }

        public IEnumerable<User> ApplyFilters(IEnumerable<User> users)
        {
            
                return users.Where(x => CheckFilters(x));    
        
        }


        private bool CheckFilters(User user)
        {
            if (CheckActive(user) && CheckMinAge(user) && CheckMaxAge(user) && CheckGeneralTextSearch(user))
            {
                return true;
            }
            return false;
        }


        private bool CheckActive(User user)
        {
            if (!Filter_OnlyActive)
            {
                return true;
            }

            if (user.Active)
            {
                return true;
            }

            return false;
        }

        private bool CheckMaxAge(User user)
        {
            if (user.Age <= Filter_MaxAge)
            {
                return true;
            }

            return false;
        }

        private bool CheckMinAge(User user)
        {
            if (user.Age >= Filter_MinAge)
            {
                return true;
            }

            return false;
        }


        private bool CheckGeneralTextSearch(User user)
        {
            if (string.IsNullOrWhiteSpace(Filter_GeneralTextSeach))
            {
                return true;
            }

            if (user.Name.Trim().ToUpper().Contains(Filter_GeneralTextSeach.Trim().ToUpper()))
            {
                return true;
            }

            return false;
        }
    }
}
