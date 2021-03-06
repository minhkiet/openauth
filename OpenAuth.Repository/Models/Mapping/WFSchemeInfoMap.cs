﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace OpenAuth.Repository.Models.Mapping
{
    public partial class WFSchemeInfoMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OpenAuth.Domain.WFSchemeInfo>
    {
        public WFSchemeInfoMap()
        {
            // table
            ToTable("WF_SchemeInfo", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .IsRequired();
            Property(t => t.SchemeCode)
                .HasColumnName("SchemeCode")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.SchemeName)
                .HasColumnName("SchemeName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.SchemeType)
                .HasColumnName("SchemeType")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.SchemeVersion)
                .HasColumnName("SchemeVersion")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.SchemeCanUser)
                .HasColumnName("SchemeCanUser")
                .IsOptional();
            Property(t => t.FrmType)
                .HasColumnName("FrmType")
                .IsOptional();
            Property(t => t.AuthorizeType)
                .HasColumnName("AuthorizeType")
                .IsOptional();
            Property(t => t.SortCode)
                .HasColumnName("SortCode")
                .IsOptional();
            Property(t => t.DeleteMark)
                .HasColumnName("DeleteMark")
                .IsRequired();
            Property(t => t.EnabledMark)
                .HasColumnName("EnabledMark")
                .IsRequired();
            Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.CreateDate)
                .HasColumnName("CreateDate")
                .IsRequired();
            Property(t => t.CreateUserId)
                .HasColumnName("CreateUserId")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.CreateUserName)
                .HasColumnName("CreateUserName")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.ModifyDate)
                .HasColumnName("ModifyDate")
                .IsOptional();
            Property(t => t.ModifyUserId)
                .HasColumnName("ModifyUserId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.ModifyUserName)
                .HasColumnName("ModifyUserName")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
        }
    }
}
