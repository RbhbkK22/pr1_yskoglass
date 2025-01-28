using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pr1
{
    public static class AppStateHandler
    {
        private static List<Form> forms = new List<Form> { 
            new Form1(),
            new Form2(),
            new Form3(),
            new Form4(),
            new Form5(),
            new Form6(),
            new Form7(),

        };

        private static int f = 0;

        public static void AddClosHandler(Form form)
        {
            form.FormClosing += (sender, e) => Application.Exit();
        }

        public static void GoToForm(int newIndex)
        {
            if (newIndex >= 0 && newIndex < forms.Count)
            {
                forms[f].Hide(); // Скрываем текущую форму
                f = newIndex;    // Обновляем индекс
                forms[f].Show(); // Показываем новую форму
            }
        }

        public static Form GetForm()
        {
            return forms[f];
        }

        public static int CurrentIndex => f;
    }
}
