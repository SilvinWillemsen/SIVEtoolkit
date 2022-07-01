namespace Zinnia.Data.Type.Transformation.Aggregation
{
    using System;
    using System.Linq;
    using UnityEngine.Events;
    using Zinnia.Data.Collection.List;

    /// <summary>
    /// Multiplies a <see cref="float"/> collection by multiplying each one to the next entry in the collection.
    /// </summary>
    /// <example>
    /// 2f * 2f * 2f = 8f
    /// </example>
    public class FloatMultiplier : CollectionAggregator<float, float, FloatMultiplier.UnityEvent, FloatObservableList, FloatObservableList.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the multiplied <see cref="float"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<float> { }

        /// <inheritdoc />
        protected override float ProcessCollection()
        {
            return Collection.NonSubscribableElements.Aggregate((a, b) => a * b);
        }
    }
}