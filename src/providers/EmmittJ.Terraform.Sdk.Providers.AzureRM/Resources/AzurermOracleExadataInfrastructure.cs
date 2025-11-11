using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOracleExadataInfrastructureMaintenanceWindowBlock : TerraformBlockBase
{
    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformProperty("days_of_week")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> DaysOfWeek { get; set; }

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    [TerraformProperty("hours_of_day")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<double> HoursOfDay { get; set; }

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    [TerraformProperty("lead_time_in_weeks")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> LeadTimeInWeeks { get; set; }

    /// <summary>
    /// The months attribute.
    /// </summary>
    [TerraformProperty("months")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Months { get; set; }

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    [TerraformProperty("patching_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PatchingMode { get; set; }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    [TerraformProperty("preference")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Preference { get; set; }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    [TerraformProperty("weeks_of_month")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<double> WeeksOfMonth { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleExadataInfrastructureTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_oracle_exadata_infrastructure resource.
/// </summary>
public partial class AzurermOracleExadataInfrastructure : TerraformResource
{
    public AzurermOracleExadataInfrastructure(string name) : base("azurerm_oracle_exadata_infrastructure", name)
    {
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    [TerraformProperty("compute_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ComputeCount { get; set; }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformProperty("customer_contacts")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> CustomerContacts { get; set; }

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    [TerraformProperty("database_server_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DatabaseServerType { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    [TerraformProperty("shape")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Shape { get; set; }

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCount is required")]
    [TerraformProperty("storage_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> StorageCount { get; set; }

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    [TerraformProperty("storage_server_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StorageServerType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    [TerraformProperty("zones")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Zones { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("maintenance_window")]
    public partial TerraformList<TerraformBlock<AzurermOracleExadataInfrastructureMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermOracleExadataInfrastructureTimeoutsBlock>? Timeouts { get; set; }

}
