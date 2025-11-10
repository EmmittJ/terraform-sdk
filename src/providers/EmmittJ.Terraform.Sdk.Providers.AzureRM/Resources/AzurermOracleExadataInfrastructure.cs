using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleExadataInfrastructureMaintenanceWindowBlock : ITerraformBlock
{
    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [TerraformPropertyName("days_of_week")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> DaysOfWeek { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "days_of_week");

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    [TerraformPropertyName("hours_of_day")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<double>>> HoursOfDay { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<double>>>("", "hours_of_day");

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    [TerraformPropertyName("lead_time_in_weeks")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> LeadTimeInWeeks { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "lead_time_in_weeks");

    /// <summary>
    /// The months attribute.
    /// </summary>
    [TerraformPropertyName("months")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Months { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "months");

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    [TerraformPropertyName("patching_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PatchingMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "patching_mode");

    /// <summary>
    /// The preference attribute.
    /// </summary>
    [TerraformPropertyName("preference")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Preference { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "preference");

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    [TerraformPropertyName("weeks_of_month")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<double>>> WeeksOfMonth { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<double>>>("", "weeks_of_month");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleExadataInfrastructureTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public required TerraformProperty<TerraformProperty<double>> ComputeCount { get; set; }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformPropertyName("customer_contacts")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> CustomerContacts { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "customer_contacts");

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    [TerraformPropertyName("database_server_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DatabaseServerType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_server_type");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    [TerraformPropertyName("shape")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Shape { get; set; }

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCount is required")]
    [TerraformPropertyName("storage_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> StorageCount { get; set; }

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_server_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageServerType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_server_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    [TerraformPropertyName("zones")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Zones { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AzurermOracleExadataInfrastructureMaintenanceWindowBlock>>? MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleExadataInfrastructureTimeoutsBlock>? Timeouts { get; set; } = new();

}
