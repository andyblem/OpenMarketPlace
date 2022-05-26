using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Stride3DMarketPlace.Database.Extensions;
using Stride3DMarketPlace.Database.BaseInterfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Stride3DMarketPlace.Database.Data
{
    public class SoftDeleteTimeStampDbContext : DbContext
    {
        public SoftDeleteTimeStampDbContext(DbContextOptions options)
          : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyGlobalFilters<ISoftDelete>(e => e.IsDeleted == null || e.IsDeleted == false);
        }

        public override EntityEntry<TEntity> Add<TEntity>(TEntity entity)
        {
            // set some data
            if (entity != null && entity is ITimeStamp)
            {
                ((ITimeStamp)entity).CreatedAt = DateTime.Now;
                ((ITimeStamp)entity).IsModified = false;
            }

            return base.Add(entity);
        }

        public override EntityEntry Add(object entity)
        {
            // set some data
            if (entity != null && entity is ITimeStamp)
            {
                ((ITimeStamp)entity).CreatedAt = DateTime.Now;
                ((ITimeStamp)entity).IsModified = false;
            }

            return base.Add(entity);
        }

        public override EntityEntry<TEntity> Attach<TEntity>(TEntity entity)
        {
            var result = base.Attach(entity);
            if (entity is ITimeStamp)
            {
                ((ITimeStamp)result.Entity).IsModified = true;
                ((ITimeStamp)result.Entity).ModifiedAt = DateTime.Now;

                Entry((ITimeStamp)entity).Property(e => e.IsModified).IsModified = true;
                Entry((ITimeStamp)entity).Property(e => e.ModifiedAt).IsModified = true;
            }

            return result;
        }

        public override EntityEntry Attach(object entity)
        {
            var result = base.Attach(entity);
            if (entity is ITimeStamp)
            {
                ((ITimeStamp)result.Entity).IsModified = true;
                ((ITimeStamp)result.Entity).ModifiedAt = DateTime.Now;

                Entry((ITimeStamp)entity).Property(e => e.IsModified).IsModified = true;
                Entry((ITimeStamp)entity).Property(e => e.ModifiedAt).IsModified = true;
            }

            return result;
        }

        public override EntityEntry Remove(object entity)
        {
            return Remove(entity, true);
        }

        public EntityEntry Remove([NotNull] object entity, bool isSoftDelete = true)
        {
            if (isSoftDelete)
            {
                if (entity is ISoftDelete)
                {
                    // create an entry
                    var entry = Entry((ISoftDelete)entity);

                    // no need to delete detached entity
                    var initialState = entry.State;
                    if (initialState == EntityState.Detached)
                    {
                        entry.State = EntityState.Unchanged;
                    }

                    // no need to delete entity that has been added since it's not in the db
                    // modify delete data
                    if (initialState == EntityState.Added)
                    {
                        entry.State = EntityState.Detached;
                    }
                    else
                    {
                        entry.Entity.IsDeleted = true;
                        entry.Entity.DeletedAt = DateTime.Now;

                        entry.Property(e => e.DeletedAt).IsModified = true;
                        entry.Property(e => e.IsDeleted).IsModified = true;
                    }

                    return entry;
                }

                throw new Exception("Entity not soft deletable");
            }
            else
            {
                return base.Remove(entity);
            }
        }

        public override void RemoveRange(IEnumerable<object> entities)
        {
            RemoveRange(entities, true);
        }

        public void RemoveRange(IEnumerable<object> entities, bool isSoftDelete = true)
        {
            if (isSoftDelete == true)
            {
                // An Added entity does not yet exist in the database. If it is then marked as deleted there is
                // nothing to delete because it was not yet inserted, so just make sure it doesn't get inserted.
                foreach (var entity in entities)
                {
                    if (entity is ISoftDelete)
                    {
                        // create an entry
                        var entry = Entry((ISoftDelete)entity);

                        // no need to delete detached entity
                        var initialState = entry.State;
                        if (initialState == EntityState.Detached)
                        {
                            entry.State = EntityState.Unchanged;
                        }

                        // no need to delete entity that has been added since it's not in the db
                        // modify delete data
                        if (initialState == EntityState.Added)
                        {
                            entry.State = EntityState.Detached;
                        }
                        else
                        {
                            entry.Entity.IsDeleted = true;
                            entry.Entity.DeletedAt = DateTime.Now;

                            entry.Property(e => e.DeletedAt).IsModified = true;
                            entry.Property(e => e.IsDeleted).IsModified = true;
                        }
                    }
                }
            }
            else
            {
                base.RemoveRange(entities);
            }
        }

        public virtual EntityEntry Restore(object entity)
        {
            var result = base.Attach(entity);
            if (entity is ISoftDelete)
            {
                ((ISoftDelete)result.Entity).IsDeleted = false;
                ((ISoftDelete)result.Entity).DeletedAt = null;

                Entry((ISoftDelete)entity).Property(e => e.IsDeleted).IsModified = true;
                Entry((ISoftDelete)entity).Property(e => e.DeletedAt).IsModified = true;
            }

            return result;
        }

        public override EntityEntry<TEntity> Update<TEntity>(TEntity entity)
        {
            // set some data
            if (entity != null && entity is ITimeStamp)
            {
                // create an entry
                var entry = Entry((ITimeStamp)entity);

                entry.Entity.IsModified = true;
                entry.Entity.ModifiedAt = DateTime.Now;

                entry.Property(e => e.IsModified).IsModified = true;
                entry.Property(e => e.ModifiedAt).IsModified = true;
            }

            return base.Update(entity);
        }

        public override EntityEntry Update(object entity)
        {
            // set some data
            if (entity != null && entity is ITimeStamp)
            {
                // create an entry
                var entry = Entry((ITimeStamp)entity);

                entry.Entity.IsModified = true;
                entry.Entity.ModifiedAt = DateTime.Now;

                entry.Property(e => e.IsModified).IsModified = true;
                entry.Property(e => e.ModifiedAt).IsModified = true;
            }

            return base.Update(entity);
        }

        public override void UpdateRange(IEnumerable<object> entities)
        {
            foreach (var entity in entities)
            {
                // set some data
                if (entity is ITimeStamp)
                {
                    // create an entry
                    var entry = Entry((ITimeStamp)entity);

                    entry.Entity.IsModified = true;
                    entry.Entity.ModifiedAt = DateTime.Now;

                    entry.Property(e => e.IsModified).IsModified = true;
                    entry.Property(e => e.ModifiedAt).IsModified = true;
                }
            }

            base.UpdateRange(entities);
        }
    }
}
