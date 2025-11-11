using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_managed_database.
/// </summary>
public class AzurermMssqlManagedDatabaseDataSource : TerraformDataSource
{
    public AzurermMssqlManagedDatabaseDataSource(string name) : base("azurerm_mssql_managed_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformPropertyName("managed_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ManagedInstanceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The long_term_retention_policy attribute.
    /// </summary>
    [TerraformPropertyName("long_term_retention_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LongTermRetentionPolicy => new TerraformReference(this, "long_term_retention_policy");

    /// <summary>
    /// The managed_instance_name attribute.
    /// </summary>
    [TerraformPropertyName("managed_instance_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagedInstanceName => new TerraformReference(this, "managed_instance_name");

    /// <summary>
    /// The point_in_time_restore attribute.
    /// </summary>
    [TerraformPropertyName("point_in_time_restore")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PointInTimeRestore => new TerraformReference(this, "point_in_time_restore");

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [TerraformPropertyName("resource_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceGroupName => new TerraformReference(this, "resource_group_name");

    /// <summary>
    /// The short_term_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("short_term_retention_days")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ShortTermRetentionDays => new TerraformReference(this, "short_term_retention_days");

}
