using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for export_data_options in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementExportExportDataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "export_data_options";

    /// <summary>
    /// The time_frame attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeFrame is required")]
    [TerraformArgument("time_frame")]
    public required TerraformValue<string> TimeFrame
    {
        get => new TerraformReference<string>(this, "time_frame");
        set => SetArgument("time_frame", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for export_data_storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementExportExportDataStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "export_data_storage_location";

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    [TerraformArgument("container_id")]
    public required TerraformValue<string> ContainerId
    {
        get => new TerraformReference<string>(this, "container_id");
        set => SetArgument("container_id", value);
    }

    /// <summary>
    /// The root_folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolderPath is required")]
    [TerraformArgument("root_folder_path")]
    public required TerraformValue<string> RootFolderPath
    {
        get => new TerraformReference<string>(this, "root_folder_path");
        set => SetArgument("root_folder_path", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermResourceGroupCostManagementExportTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_resource_group_cost_management_export resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermResourceGroupCostManagementExport : TerraformResource
{
    public AzurermResourceGroupCostManagementExport(string name) : base("azurerm_resource_group_cost_management_export", name)
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformArgument("active")]
    public TerraformValue<bool>? Active
    {
        get => new TerraformReference<bool>(this, "active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    [TerraformArgument("file_format")]
    public TerraformValue<string>? FileFormat
    {
        get => new TerraformReference<string>(this, "file_format");
        set => SetArgument("file_format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recurrence_period_end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodEndDate is required")]
    [TerraformArgument("recurrence_period_end_date")]
    public required TerraformValue<string> RecurrencePeriodEndDate
    {
        get => new TerraformReference<string>(this, "recurrence_period_end_date");
        set => SetArgument("recurrence_period_end_date", value);
    }

    /// <summary>
    /// The recurrence_period_start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodStartDate is required")]
    [TerraformArgument("recurrence_period_start_date")]
    public required TerraformValue<string> RecurrencePeriodStartDate
    {
        get => new TerraformReference<string>(this, "recurrence_period_start_date");
        set => SetArgument("recurrence_period_start_date", value);
    }

    /// <summary>
    /// The recurrence_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceType is required")]
    [TerraformArgument("recurrence_type")]
    public required TerraformValue<string> RecurrenceType
    {
        get => new TerraformReference<string>(this, "recurrence_type");
        set => SetArgument("recurrence_type", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    [TerraformArgument("resource_group_id")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => new TerraformReference<string>(this, "resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// Block for export_data_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportDataOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataOptions block(s) allowed")]
    [TerraformArgument("export_data_options")]
    public required TerraformList<AzurermResourceGroupCostManagementExportExportDataOptionsBlock> ExportDataOptions { get; set; } = new();

    /// <summary>
    /// Block for export_data_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportDataStorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataStorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataStorageLocation block(s) allowed")]
    [TerraformArgument("export_data_storage_location")]
    public required TerraformList<AzurermResourceGroupCostManagementExportExportDataStorageLocationBlock> ExportDataStorageLocation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermResourceGroupCostManagementExportTimeoutsBlock Timeouts { get; set; } = new();

}
