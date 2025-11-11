using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleExadataInfrastructureMaintenanceWindowBlock
{
    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformPropertyName("days_of_week")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> DaysOfWeek { get; set; } = default!;

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    [TerraformPropertyName("hours_of_day")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<double> HoursOfDay { get; set; } = default!;

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    [TerraformPropertyName("lead_time_in_weeks")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> LeadTimeInWeeks { get; set; } = default!;

    /// <summary>
    /// The months attribute.
    /// </summary>
    [TerraformPropertyName("months")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Months { get; set; } = default!;

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    [TerraformPropertyName("patching_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PatchingMode { get; set; } = default!;

    /// <summary>
    /// The preference attribute.
    /// </summary>
    [TerraformPropertyName("preference")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Preference { get; set; } = default!;

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    [TerraformPropertyName("weeks_of_month")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<double> WeeksOfMonth { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleExadataInfrastructureTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_oracle_exadata_infrastructure resource.
/// </summary>
public class AzurermOracleExadataInfrastructure : TerraformResource
{
    public AzurermOracleExadataInfrastructure(string name) : base("azurerm_oracle_exadata_infrastructure", name)
    {
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    [TerraformPropertyName("compute_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ComputeCount { get; set; }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformPropertyName("customer_contacts")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> CustomerContacts { get; set; } = default!;

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    [TerraformPropertyName("database_server_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DatabaseServerType { get; set; } = default!;

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    [TerraformPropertyName("shape")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Shape { get; set; }

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCount is required")]
    [TerraformPropertyName("storage_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> StorageCount { get; set; }

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_server_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageServerType { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    [TerraformPropertyName("zones")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Zones { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AzurermOracleExadataInfrastructureMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleExadataInfrastructureTimeoutsBlock>? Timeouts { get; set; }

}
