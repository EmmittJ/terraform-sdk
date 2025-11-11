using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for export_data_options in .
/// Nesting mode: list
/// </summary>
public partial class AzurermResourceGroupCostManagementExportExportDataOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The time_frame attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeFrame is required")]
    [TerraformProperty("time_frame")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeFrame { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for export_data_storage_location in .
/// Nesting mode: list
/// </summary>
public partial class AzurermResourceGroupCostManagementExportExportDataStorageLocationBlock : TerraformBlockBase
{
    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    [TerraformProperty("container_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerId { get; set; }

    /// <summary>
    /// The root_folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolderPath is required")]
    [TerraformProperty("root_folder_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RootFolderPath { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermResourceGroupCostManagementExportTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_resource_group_cost_management_export resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermResourceGroupCostManagementExport : TerraformResource
{
    public AzurermResourceGroupCostManagementExport(string name) : base("azurerm_resource_group_cost_management_export", name)
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformProperty("active")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Active { get; set; }

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    [TerraformProperty("file_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileFormat { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The recurrence_period_end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodEndDate is required")]
    [TerraformProperty("recurrence_period_end_date")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecurrencePeriodEndDate { get; set; }

    /// <summary>
    /// The recurrence_period_start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodStartDate is required")]
    [TerraformProperty("recurrence_period_start_date")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecurrencePeriodStartDate { get; set; }

    /// <summary>
    /// The recurrence_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceType is required")]
    [TerraformProperty("recurrence_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecurrenceType { get; set; }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    [TerraformProperty("resource_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupId { get; set; }

    /// <summary>
    /// Block for export_data_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportDataOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataOptions block(s) allowed")]
    [TerraformProperty("export_data_options")]
    public partial TerraformList<TerraformBlock<AzurermResourceGroupCostManagementExportExportDataOptionsBlock>>? ExportDataOptions { get; set; }

    /// <summary>
    /// Block for export_data_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportDataStorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataStorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataStorageLocation block(s) allowed")]
    [TerraformProperty("export_data_storage_location")]
    public partial TerraformList<TerraformBlock<AzurermResourceGroupCostManagementExportExportDataStorageLocationBlock>>? ExportDataStorageLocation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermResourceGroupCostManagementExportTimeoutsBlock>? Timeouts { get; set; }

}
