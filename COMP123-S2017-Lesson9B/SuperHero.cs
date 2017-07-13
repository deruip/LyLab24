using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Aron Ly
 * Date: July 13, 2017
 * Description: This is the SuperHero class which inherits from the SuperHuman class
 * Version: 0.8 - implemented IHasKarma interface
 */
namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// 
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        //private instance variables
        private int _karma;
        //public properties
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }
        //constructors
        /// <summary>
        /// This is the main constructor for the SuperHero class
        /// It takes two arguments - name (string) - karma (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        public SuperHero(string name, int karma) 
            :base (name)
            {
            this.Karma = karma;
            }
        //private methods

        //public methods

    }
}