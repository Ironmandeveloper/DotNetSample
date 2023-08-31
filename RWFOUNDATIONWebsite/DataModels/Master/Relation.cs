﻿using RWFOUNDATIONWebsite.DataModels.SaveAsDrafts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RWFOUNDATIONWebsite.DataModels.Master
{
    public class Relation
    {
        public int RelationId { get; set; }
        public string RelationName { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public ICollection<FamilyMember> FamilyMembers { get; set; }
        public ICollection<BeneficiaryFamilyMemberSaveAsDraft> BeneficiaryFamilyMemberSaveAsDrafts { get; set; }
    }
}
