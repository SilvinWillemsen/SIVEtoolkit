﻿namespace Zinnia.Association
{
    using UnityEngine;
    using Zinnia.Association.Collection;
    using Zinnia.Extension;
    using Zinnia.Process;

    /// <summary>
    /// (De)activates <see cref="GameObjectsAssociation"/>s.
    /// </summary>
    public class GameObjectsAssociationActivator : MonoBehaviour, IProcessable
    {
        [Tooltip("The associations in order they will be activated if they match the currently expected state.")]
        [SerializeField]
        private GameObjectsAssociationObservableList associations;
        /// <summary>
        /// The associations in order they will be activated if they match the currently expected state.
        /// </summary>
        public GameObjectsAssociationObservableList Associations
        {
            get
            {
                return associations;
            }
            set
            {
                if (this.IsMemberChangeAllowed())
                {
                    OnBeforeAssociationsChange();
                }
                associations = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterAssociationsChange();
                }
            }
        }

        /// <summary>
        /// The currently activated association, or <see langword="null"/> if no association is activated.
        /// </summary>
        public GameObjectsAssociation CurrentAssociation { get; private set; }

        /// <summary>
        /// Activates the <see cref="GameObject"/>s that are part of the association if the association matches the currently expected state.
        /// </summary>
        public virtual void Activate()
        {
            if (Associations == null)
            {
                return;
            }

            GameObjectsAssociation desiredAssociation = null;
            foreach (GameObjectsAssociation association in Associations.NonSubscribableElements)
            {
                if (association == null)
                {
                    continue;
                }

                if (association.ShouldBeActive())
                {
                    desiredAssociation = association;
                    break;
                }
            }

            if (desiredAssociation == null || CurrentAssociation == desiredAssociation)
            {
                return;
            }

            CurrentAssociation = desiredAssociation;

            foreach (GameObjectsAssociation association in Associations.NonSubscribableElements)
            {
                if (association == desiredAssociation)
                {
                    continue;
                }

                foreach (GameObject associatedObject in association.GameObjects.NonSubscribableElements)
                {
                    if (associatedObject != null)
                    {
                        associatedObject.SetActive(false);
                    }
                }
            }

            foreach (GameObject associatedObject in desiredAssociation.GameObjects.NonSubscribableElements)
            {
                if (associatedObject != null)
                {
                    associatedObject.SetActive(true);
                }
            }
        }

        /// <summary>
        /// Deactivates the association that is currently activated and all other known associations.
        /// </summary>
        public virtual void Deactivate()
        {
            Deactivate(Associations);
        }

        /// <summary>
        /// Calls <see cref="Activate"/> on the specified moment.
        /// </summary>
        public void Process()
        {
            Activate();
        }

        protected virtual void Awake()
        {
            if (Associations == null)
            {
                return;
            }

            foreach (GameObjectsAssociation association in Associations.NonSubscribableElements)
            {
                if (association == null)
                {
                    continue;
                }

                foreach (GameObject associatedObject in association.GameObjects.NonSubscribableElements)
                {
                    if (associatedObject.activeInHierarchy)
                    {
                        Debug.LogWarning($"At least one association object is active in the scene on {nameof(Awake)} of this {GetType().Name}. Having multiple association objects active at the same time will most likely lead to issues. Make sure to deactivate them all before you play or create a build.");
                        return;
                    }
                }
            }
        }

        protected virtual void OnEnable()
        {
            Activate();
        }

        protected virtual void OnDisable()
        {
            Deactivate();
        }

        /// <summary>
        /// Deactivates the association that is currently activated and all other known associations.
        /// </summary>
        /// <param name="associations">The associations to deactivate.</param>
        protected virtual void Deactivate(GameObjectsAssociationObservableList associations)
        {
            if (associations == null)
            {
                return;
            }

            foreach (GameObjectsAssociation association in associations.NonSubscribableElements)
            {
                if (association == null)
                {
                    continue;
                }

                foreach (GameObject associatedObject in association.GameObjects.NonSubscribableElements)
                {
                    if (associatedObject != null)
                    {
                        associatedObject.SetActive(false);
                    }
                }
            }

            if (CurrentAssociation != null)
            {
                foreach (GameObject associatedObject in CurrentAssociation.GameObjects.NonSubscribableElements)
                {
                    if (associatedObject != null)
                    {
                        associatedObject.SetActive(false);
                    }
                }

                CurrentAssociation = null;
            }
        }

        /// <summary>
        /// Called before <see cref="Associations"/> has been changed.
        /// </summary>
        protected virtual void OnBeforeAssociationsChange()
        {
            Deactivate(Associations);
        }

        /// <summary>
        /// Called after <see cref="Associations"/> has been changed.
        /// </summary>
        protected virtual void OnAfterAssociationsChange()
        {
            Activate();
        }
    }
}