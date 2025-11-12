using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_managed_database.
/// </summary>
public partial class AzurermMssqlManagedDatabaseDataSource : TerraformDataSource
{
    public AzurermMssqlManagedDatabaseDataSource(string name) : base("azurerm_mssql_managed_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformProperty("managed_instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedInstanceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The long_term_retention_policy attribute.
    /// </summary>
    [TerraformProperty("long_term_retention_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LongTermRetentionPolicy { get; }

    /// <summary>
    /// The managed_instance_name attribute.
    /// </summary>
    [TerraformProperty("managed_instance_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagedInstanceName { get; }

    /// <summary>
    /// The point_in_time_restore attribute.
    /// </summary>
    [TerraformProperty("point_in_time_restore")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PointInTimeRestore { get; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [TerraformProperty("resource_group_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceGroupName { get; }

    /// <summary>
    /// The short_term_retention_days attribute.
    /// </summary>
    [TerraformProperty("short_term_retention_days")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ShortTermRetentionDays { get; }

}
