using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Questionnaire
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
           
        }

        public Window1(ProgramerProfile programerProfile)
        {
            InitializeComponent();
            LastNameText.Text = programerProfile.lastName;
            FirstNameText.Text = programerProfile.firstName;
            FirstNameText.Text += $" {programerProfile.patronymic}";
            f_birthday.Text = programerProfile.birthday.ToShortDateString();
            TimeSpan ts = DateTime.Now - programerProfile.birthday;
            int tempDate = (int)(ts.TotalDays/360);
            f_full_year.Text = tempDate.ToString();
            f_aboutMe.Text = programerProfile.aboutMe;

            //programmingLanguages = "С++";
            //aboutMe = "что-то";
            //birthday = "1.11.1111";
            //englishLevel = "1";
            //likeProgramming = "100";
            //chooseOS = "Windows";
        }

    }
}
