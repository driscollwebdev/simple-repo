namespace SimpleRepo
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a repository of business entities
    /// </summary>
    /// <typeparam name="TEntity">The type of entity</typeparam>
    public interface ISimpleRepo<TEntity> where TEntity : class
    {
        /// <summary>
        /// Retrieves a single entity from the repository by id
        /// </summary>
        /// <typeparam name="TEntityId">The id type</typeparam>
        /// <param name="id">The id</param>
        /// <returns>A single entity matching the specified id, or null if not found.</returns>
        TEntity Single<TEntityId>(TEntityId id);

        /// <summary>
        /// Retrieves all entities in the repository
        /// </summary>
        /// <returns>An enumerable collection of all entities</returns>
        IEnumerable<TEntity> All();

        /// <summary>
        /// Retrieves a filtered collection of entities in the repository
        /// </summary>
        /// <param name="filter">The filter</param>
        /// <returns>An enumerable collection of entities matching the filter</returns>
        IEnumerable<TEntity> Find(IFilter filter);

        /// <summary>
        /// Adds an entity to the repository if it does not already exist, or updates an existing entity
        /// </summary>
        /// <param name="entity">The entity to add or update</param>
        void AddOrUpdate(TEntity entity);

        /// <summary>
        /// Removes an entity from the repository
        /// </summary>
        /// <param name="entity">The entity to remove</param>
        void Remove(TEntity entity);

        /// <summary>
        /// Removes an entity from the repository based on its id value
        /// </summary>
        /// <typeparam name="TEntityId">The type of entity id</typeparam>
        /// <param name="id">The id</param>
        void RemoveById<TEntityId>(TEntityId id);

        /// <summary>
        /// Retrieves a count of all the entities in the repository. This implementation should not have to materialize the entities.
        /// </summary>
        /// <returns>The count</returns>
        int Count();

        /// <summary>
        /// Retrieves a count of all entities matching the filter. This implementation should not have to materialize the entities
        /// </summary>
        /// <param name="filter">The filter to apply</param>
        /// <returns>The count</returns>
        int Count(IFilter filter);
    }
}
