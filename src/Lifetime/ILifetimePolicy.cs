﻿

using Unity.Policy;

namespace Unity.Lifetime
{
    /// <summary>
    /// A <see cref="IBuilderPolicy"/> that controls how instances are
    /// persisted and recovered from an external store. Used to implement
    /// things like singletons and per-http-request lifetime.
    /// </summary>
    public interface ILifetimePolicy 
    {
        /// <summary>
        /// Retrieve a value from the backing store associated with this Lifetime policy.
        /// </summary>
        /// <param name="container">The container this lifetime belongs to</param>
        /// <returns>the object desired, or null if no such object is currently stored.</returns>
        object GetValue(ILifetimeContainer container = null);

        /// <summary>
        /// Stores the given value into backing store for retrieval later.
        /// </summary>
        /// <param name="newValue">The object to store.</param>
        /// <param name="container">The container this lifetime belongs to</param>
        void SetValue(object newValue, ILifetimeContainer container = null);

        /// <summary>
        /// Remove the value this lifetime policy is managing from backing store.
        /// <param name="container">The container this lifetime belongs to</param>
        /// </summary>
        void RemoveValue(ILifetimeContainer container = null);
    }
}
