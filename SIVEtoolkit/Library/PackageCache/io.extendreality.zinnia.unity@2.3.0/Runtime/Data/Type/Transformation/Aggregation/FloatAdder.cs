namespace Zinnia.Data.Type.Transformation.Aggregation
{
    using System;
    using System.Linq;
    using UnityEngine.Events;
    using Zinnia.Data.Collection.List;

    /// <summary>
    /// Sums up a <see cref="float"/> collection.
    /// </summary>
    /// <example>
    /// 1f + 2f + 3f = 6f
    /// </example>
    public class FloatAdder : CollectionAggregator<float, float, FloatAdder.UnityEvent, FloatObservableList, FloatObservableList.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the aggregated <see cref="float"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<float> { }

        /// <inheritdoc />
        protected override float ProcessCollection()
        {
            return Collection.NonSubscribableElements.Sum();
        }
    }
}