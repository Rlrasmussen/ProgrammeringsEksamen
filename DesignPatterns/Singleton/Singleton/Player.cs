using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Player
    {
        #region Field
        private static Player instance;

        #endregion

        #region Properties
        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Player();
                }

                return instance;
            }
        }
        #endregion

        #region Constructor
        private Player()
        {
        }

        #endregion

        #region Method
        /// <summary>
        /// A Hello message printet to the concole
        /// </summary>
        public void SayHi()
        {
            Console.WriteLine("Hi");
        }


        #endregion
    }
}
