using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Presenter
    {
        private Model currentModel;
        private IView view;

        public Presenter(IView view)
        {
            this.view = view;
            CurrentModel = new Model();
        }

        public Presenter()
        {
            CurrentModel = new Model();
        }

        public Model CurrentModel { get { return this.currentModel; } set { this.currentModel = value; } }

    }
}
