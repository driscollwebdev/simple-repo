namespace SimpleRepo
{
    using System;

    /// <summary>
    /// Represents a transactional unit of work.
    /// </summary>
    public interface IDataContext : IDisposable
    {
        /// <summary>
        /// Save pending changes in a transaction.
        /// </summary>
        void Save();
    }
}
