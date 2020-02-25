using System;

namespace Library.Services {
    /// <summary>
    /// Allows services to notify when their
    /// underlying data model changes.
    /// </summary>
    interface IService {
        /// <summary>
        /// Event to be raised when data model changes.
        /// </summary>
        event EventHandler Updated;
    }
}
