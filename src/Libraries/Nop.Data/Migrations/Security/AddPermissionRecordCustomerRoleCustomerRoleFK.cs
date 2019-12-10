﻿using FluentMigrator;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Security;

namespace Nop.Data.Migrations.Security
{
    [Migration(637097819107801301)]
    public class AddPermissionRecordCustomerRoleCustomerRoleFK : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            Create.ForeignKey().FromTable(NopMappingDefaults.PermissionRecordRoleTable)
                .ForeignColumn("CustomerRole_Id")
                .ToTable(nameof(CustomerRole))
                .PrimaryColumn(nameof(CustomerRole.Id));

            Create.Index().OnTable(NopMappingDefaults.PermissionRecordRoleTable).OnColumn("CustomerRole_Id").Ascending().WithOptions().NonClustered();
        }

        #endregion
    }
}