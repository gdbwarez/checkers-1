using System;
using System.Collections;

namespace Checkers
{
    public class CheckersPieceCollection : CollectionBase, IEnumerable
    {
        public int Add(CheckersPiece item)
        {
            return InnerList.Add(item);
        }

        public void AddRange(CheckersPiece[] items)
        {
            foreach(CheckersPiece item in items)
                Add(item);
        }

        public void Insert(int index, CheckersPiece item)
        {
            InnerList.Insert(index, item);
        }

        public void Remove(CheckersPiece item)
        {
            InnerList.Remove(item);
        }

        public bool Contains(CheckersPiece item)
        {
            return InnerList.Contains(item);
        }

        public int IndexOf(CheckersPiece item)
        {
            return InnerList.IndexOf(item);
        }

        public void CopyTo(CheckersPiece[] array, int index)
        {
            InnerList.CopyTo(array, index);
        }

        /// <summary>Creates a shallow copy of the CheckersPieceCollection.</summary>
        public CheckersPieceCollection Clone()
        {
            CheckersPieceCollection clone = new CheckersPieceCollection();
            clone.AddRange(ToArray());
            return clone;
        }

        public CheckersPiece this[int index]
        {
            get
            {
                return (CheckersPiece)InnerList[index];
            }
            set
            {
                InnerList[index] = value;
            }
        }

        public CheckersPiece[] ToArray()
        {
            return (CheckersPiece[])InnerList.ToArray(typeof(CheckersPiece));
        }
    }
}
