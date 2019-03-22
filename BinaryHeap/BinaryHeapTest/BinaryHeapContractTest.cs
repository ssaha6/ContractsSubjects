using System;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryHeap;
using Common.Utility;
using PexAPIWrapper;

namespace BinaryHeap.Test
{
    [TestClass, PexClass]
    public partial class BinaryHeapContractTest
    {
        [PexMethod]
        public void PUT_AddContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int priority, int value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_bhIndexOfValue = bh.IndexOf(value);
            int Old_prioirty = priority;
            int Old_value = value;

            //code
            bh.Add(priority, value);

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;
            int Newd_bhIndexOfValue = bh.IndexOf(value);
            int New_prioirty = priority;
            int New_value = value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_indexof_value", Old_bhIndexOfValue);
            PexObserve.ValueForViewing("$new_bh_indexof_value", Newd_bhIndexOfValue);
            PexObserve.ValueForViewing("$old_bh_priority", Old_prioirty);
            PexObserve.ValueForViewing("$new_bh_priority", New_prioirty);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            PexObserve.ValueForViewing("$new_bh_value", New_value);
            

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_MinimumContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh)
        {
            AssumePrecondition.IsTrue(bh.Count > 0);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_Ret_Key = 2;
            int Old_Ret_Value = 2;

            //code
            var m = bh.Minimum();
            int New_Ret_Key = m.Key;
            int New_Ret_Value = m.Value;

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_ret_key", Old_Ret_Key);
            PexObserve.ValueForViewing("$new_ret_key", New_Ret_Key);
            PexObserve.ValueForViewing("$old_ret_value", Old_Ret_Value);
            PexObserve.ValueForViewing("$new_ret_value", New_Ret_Value);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_RemoveMinimumContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh)
        {
            AssumePrecondition.IsTrue(bh.Count > 0);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_Ret_Key = 2;
            int Old_Ret_Value = 2;

            //code
            var rm = bh.RemoveMinimum();
            int New_Ret_Key = rm.Key;
            int New_Ret_Value = rm.Value;

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_ret_key", Old_Ret_Key);
            PexObserve.ValueForViewing("$new_ret_key", New_Ret_Key);
            PexObserve.ValueForViewing("$old_ret_value", Old_Ret_Value);
            PexObserve.ValueForViewing("$new_ret_value", New_Ret_Value);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_RemoveAtContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int index)
        {
            AssumePrecondition.IsTrue(index < bh.Count && index >= 0);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_index = index;
            int Old_Ret_Key = 2;
            int Old_Ret_Value = 2;

            //code
            var ra = bh.RemoveAt(index);
            int New_Ret_Key = ra.Key;
            int New_Ret_Value = ra.Value;

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;
            int New_index = index;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_index", Old_index);
            PexObserve.ValueForViewing("$new_bh_index", New_index);
            PexObserve.ValueForViewing("$old_ret_key", Old_Ret_Key);
            PexObserve.ValueForViewing("$new_ret_key", New_Ret_Key);
            PexObserve.ValueForViewing("$old_ret_value", Old_Ret_Value);
            PexObserve.ValueForViewing("$new_ret_value", New_Ret_Value);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_IndexOfContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int value)
        {
            AssumePrecondition.IsTrue(true);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_value = value;
            int Old_Ret = 2;

            //code
            int New_Ret = bh.IndexOf(value);

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;
            int New_value = value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            PexObserve.ValueForViewing("$new_bh_value", New_value);
            PexObserve.ValueForViewing("$old_ret", Old_Ret);
            PexObserve.ValueForViewing("$new_ret", New_Ret);

            PexAssert.IsTrue(false);
        }

        [PexMethod]
        public void PUT_UpdateContract([PexAssumeUnderTest]BinaryHeap.BinaryHeap<int, int> bh, int priority, int value)
        {
            AssumePrecondition.IsTrue(bh.IndexOf(value) >= 0);

            int Old_bhCount = bh.Count;
            int Old_bhCapacity = bh.Capacity;
            int Old_bhIndexOfValue = bh.IndexOf(value);
            int Old_prioirty = priority;
            int Old_value = value;

            //code
            bh.Update(priority, value);

            int New_bhCount = bh.Count;
            int New_bhCapacity = bh.Capacity;
            int Newd_bhIndexOfValue = bh.IndexOf(value);
            int New_prioirty = priority;
            int New_value = value;

            PexObserve.ValueForViewing("$old_bh_count", Old_bhCount);
            PexObserve.ValueForViewing("$new_bh_count", New_bhCount);
            PexObserve.ValueForViewing("$old_bh_capacity", Old_bhCapacity);
            PexObserve.ValueForViewing("$new_bh_capacity", New_bhCapacity);
            PexObserve.ValueForViewing("$old_bh_indexof_value", Old_bhIndexOfValue);
            PexObserve.ValueForViewing("$new_bh_indexof_value", Newd_bhIndexOfValue);
            PexObserve.ValueForViewing("$old_bh_priority", Old_prioirty);
            PexObserve.ValueForViewing("$new_bh_priority", New_prioirty);
            PexObserve.ValueForViewing("$old_bh_value", Old_value);
            PexObserve.ValueForViewing("$new_bh_value", New_value);


            PexAssert.IsTrue(false);
        }
    }
}