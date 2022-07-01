﻿namespace Zinnia.Rule
{
    using UnityEngine;
    using Zinnia.Data.Collection.List;

    /// <summary>
    /// Determines whether a <see cref="GameObject"/>'s <see cref="GameObject.tag"/> is part of a list.
    /// </summary>
    public class AnyTagRule : GameObjectRule
    {
        [Tooltip("The tags to check against.")]
        [SerializeField]
        private StringObservableList tags;
        /// <summary>
        /// The tags to check against.
        /// </summary>
        public StringObservableList Tags
        {
            get
            {
                return tags;
            }
            set
            {
                tags = value;
            }
        }

        /// <inheritdoc />
        protected override bool Accepts(GameObject targetGameObject)
        {
            if (Tags == null)
            {
                return false;
            }

            foreach (string testedTag in Tags.NonSubscribableElements)
            {
                if (targetGameObject.CompareTag(testedTag))
                {
                    return true;
                }
            }

            return false;
        }
    }
}