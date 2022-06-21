using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveMan
{
    public class Stage
    {
        private readonly Man[] _men = new Man[]
        {
            new Man(5,5,-1,0), new Man(6,5,1,0), new Man(9,5,1,0),  new Man(15,6,0,10){IsLeftHanded = true},new Man(10,6,0,10){IsLeftHanded = true},new Man(5,6,0,10){IsLeftHanded = true}
        };

        public void ShowAndMove()
        {
            Console.Clear();
            foreach (var person in _men)
            {
                person.Show();
                person.Move();
            }

        }
    }
}
