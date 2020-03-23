using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing101.utils
{
    public class ImageState
    {
        private int _index = 0;
        private readonly List<Bitmap> StateList = new List<Bitmap>();
        public Bitmap Image
        {
            get
            {
                return StateList[_index];
            }
            private set
            {
                StateList[_index] = value;
            }
        }

        public ImageState(Bitmap initState)
        {
            StateList.Add(new Bitmap(initState));
        }

        public void Undo()
        {
            if (_index > 0)
            {
                _index--;
            }
        }

        public void Redo()
        {
            if (_index < StateList.Count - 1)
            {
                _index++;
            }
        }

        public void Edit(Bitmap bitmap)
        {
            StateList.RemoveRange(_index + 1, StateList.Count - _index - 1);
            StateList.Add(new Bitmap(bitmap));
            _index++;
        }
    }
}
