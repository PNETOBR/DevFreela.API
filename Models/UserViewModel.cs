using DevFreela.API.Entities;

namespace DevFreela.API.Models
{
    public class UserViewModel
    {
        public UserViewModel(string fullName, string email, DateTime birtheDate, List<string> skills)
        {
            FullName = fullName;
            Email = email;
            BirtheDate = birtheDate;
            Skills = skills;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirtheDate { get; private set; }
        public List<string> Skills { get; private set; }

        public static UserViewModel FromEntity(User user)
        {
            var skills = user.Skills.Select(u => u.Skill.Description).ToList();

            return new UserViewModel(user.FullName, user.Email, user.BirtheDate, skills);
        }

    }
}
