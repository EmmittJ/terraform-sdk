using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for export_data_options in .
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementExportExportDataOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The time_frame attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeFrame is required")]
    [TerraformPropertyName("time_frame")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TimeFrame { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for export_data_storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementExportExportDataStorageLocationBlock : ITerraformBlock
{
    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    [TerraformPropertyName("container_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContainerId { get; set; }

    /// <summary>
    /// The root_folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolderPath is required")]
    [TerraformPropertyName("root_folder_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RootFolderPath { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionCostManagementExportTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_subscription_cost_management_export resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSubscriptionCostManagementExport : TerraformResource
{
    public AzurermSubscriptionCostManagementExport(string name) : base("azurerm_subscription_cost_management_export", name)
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformPropertyName("active")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Active { get; set; }

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    [TerraformPropertyName("file_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FileFormat { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The recurrence_period_end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodEndDate is required")]
    [TerraformPropertyName("recurrence_period_end_date")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RecurrencePeriodEndDate { get; set; }

    /// <summary>
    /// The recurrence_period_start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodStartDate is required")]
    [TerraformPropertyName("recurrence_period_start_date")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RecurrencePeriodStartDate { get; set; }

    /// <summary>
    /// The recurrence_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceType is required")]
    [TerraformPropertyName("recurrence_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RecurrenceType { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    [TerraformPropertyName("subscription_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubscriptionId { get; set; }

    /// <summary>
    /// Block for export_data_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportDataOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataOptions block(s) allowed")]
    [TerraformPropertyName("export_data_options")]
    public TerraformList<TerraformBlock<AzurermSubscriptionCostManagementExportExportDataOptionsBlock>>? ExportDataOptions { get; set; } = new();

    /// <summary>
    /// Block for export_data_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportDataStorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataStorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataStorageLocation block(s) allowed")]
    [TerraformPropertyName("export_data_storage_location")]
    public TerraformList<TerraformBlock<AzurermSubscriptionCostManagementExportExportDataStorageLocationBlock>>? ExportDataStorageLocation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSubscriptionCostManagementExportTimeoutsBlock>? Timeouts { get; set; } = new();

}
