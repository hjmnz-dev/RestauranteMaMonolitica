﻿namespace RestauranteMaMonolitica.Web.Data.Core
{
    public abstract class BaseEntity
    {
        protected BaseEntity() { 
            this.CreationDate = DateTime.Now;
            this.Deleted = false;
        }
        public int CreationUser { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public int? UserMod { get; set; }
        public int ModifyUser { get; set; }
        public int DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }

        public bool? Deleted { get; set; }
    }
}
