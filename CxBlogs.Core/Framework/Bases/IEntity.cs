using System;

namespace CxBlogs.Core.Framework
{
    public interface IEntity : IEntity<int> { }
    public interface IEntity<TPrimary>
    {
        TPrimary Id { get; set; }
    }
    public abstract class Entity : Entity<int>, IEntity { }
    public abstract class Entity<TPrimary> : IEntity<TPrimary>
    {
        public TPrimary Id { get; set; }
    }
    public interface ICreateEntity
    {
        /// <summary>
        /// 创建人Id
        /// </summary>
        int CreatorId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        DateTime CreationTime { get; set; }
    }
    public abstract class CreateEntity : CreateEntity<int>, IEntity { }
    public abstract class CreateEntity<TPrimary> : Entity<TPrimary>, ICreateEntity
    {
        public int CreatorId { get; set; }
        public DateTime CreationTime { get; set; }
    }
    public interface IModifyEntity
    {
        /// <summary>
        /// 修改人Id
        /// </summary>
        int ModifierId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        DateTime? ModificationTime { get; set; }
    }
    public abstract class ModifyEntity : ModifyEntity<int>, IEntity { }
    public abstract class ModifyEntity<TPrimary> : Entity<TPrimary>, IModifyEntity
    {
        public int ModifierId { get; set; }
        public DateTime? ModificationTime { get; set; }
    }
    public abstract class FullEntity : FullEntity<int>, IEntity { }
    public abstract class FullEntity<TPrimary> : Entity<TPrimary>, ICreateEntity, IModifyEntity
    {
        public int CreatorId { get; set; }
        public DateTime CreationTime { get; set; }
        public int ModifierId { get; set; }
        public DateTime? ModificationTime { get; set; }
    }
}
