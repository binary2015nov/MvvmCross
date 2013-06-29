// MvxNumericOnlyValueCombiner.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace Cirrious.MvvmCross.Binding.Combiners
{
    public abstract class MvxNumericOnlyValueCombiner
        : MvxObjectAsStringPairwiseValueCombiner
    {
        protected override bool CombineStringAndDouble(string input1, double input2, out object value)
        {
            value = null;
            return false;
        }

        protected override bool CombineStringAndLong(string input1, long input2, out object value)
        {
            value = null;
            return false;
        }

        protected override bool CombineStringAndNull(string input1, out object value)
        {
            value = null;
            return false;
        }

        protected override sealed bool CombineStringAndString(string input1, string input2, out object value)
        {
            value = null;
            return false;
        }

        protected override sealed bool CombineLongAndString(long input1, string input2, out object value)
        {
            value = null;
            return false;
        }

        protected override sealed bool CombineDoubleAndString(double input1, string input2, out object value)
        {
            value = null;
            return false;
        }

        protected override sealed bool CombineNullAndString(string input2, out object value)
        {
            value = null;
            return false;
        }
    }
}