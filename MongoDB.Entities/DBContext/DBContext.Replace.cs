﻿namespace MongoDB.Entities
{
    public partial class DBContext
    {
        /// <summary>
        /// Starts a replace command for the given entity type
        /// <para>TIP: Only the first matched entity will be replaced</para>
        /// </summary>
        /// <typeparam name="T">The type of entity</typeparam>
        public virtual Replace<T> Replace<T>() where T : IEntity
        {
            ThrowIfModifiedByIsEmpty<T>();
            return OnBeforeReplace(new Replace<T>(session, ModifiedBy, globalFilters));
        }
    }
}