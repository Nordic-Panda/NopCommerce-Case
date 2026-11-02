using FluentMigrator;
using Nop.Core.Domain.Catalog;
using Nop.Data.Extensions;

namespace Nop.Data.Migrations.UpgradeTo510;

[NopSchemaMigration("2026-11-02 00:00:01", "SchemaMigration for 5.00.1")]
public class SchemaMigration : ForwardOnlyMigration
{
    /// <summary>
    /// Collect the UP migration expressions
    /// </summary>
    public override void Up()
    {
        //# Availability action (the action to perform when the product availability end date is reached)
        this.AddOrAlterColumnFor<Product>(t => t.AvailabilityActionId)
            .AsInt32()
            .NotNullable()
            .WithDefaultValue((int)ProductAvailabilityAction.HideProduct);
    }
}
