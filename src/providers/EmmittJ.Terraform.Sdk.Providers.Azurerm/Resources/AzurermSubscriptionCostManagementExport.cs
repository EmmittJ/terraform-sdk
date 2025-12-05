using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for export_data_options in AzurermSubscriptionCostManagementExport.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementExportExportDataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "export_data_options";

    /// <summary>
    /// The time_frame attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeFrame is required")]
    public required TerraformValue<string> TimeFrame
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_frame");
        set => SetArgument("time_frame", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for export_data_storage_location in AzurermSubscriptionCostManagementExport.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementExportExportDataStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "export_data_storage_location";

    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    public required TerraformValue<string> ContainerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_id");
        set => SetArgument("container_id", value);
    }

    /// <summary>
    /// The root_folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolderPath is required")]
    public required TerraformValue<string> RootFolderPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("root_folder_path");
        set => SetArgument("root_folder_path", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSubscriptionCostManagementExport.
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionCostManagementExportTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_subscription_cost_management_export Terraform resource.
/// Manages a azurerm_subscription_cost_management_export resource.
/// </summary>
public partial class AzurermSubscriptionCostManagementExport(string name) : TerraformResource("azurerm_subscription_cost_management_export", name)
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformValue<bool>? Active
    {
        get => GetArgument<TerraformValue<bool>>("active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    public TerraformValue<string>? FileFormat
    {
        get => GetArgument<TerraformValue<string>>("file_format");
        set => SetArgument("file_format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recurrence_period_end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodEndDate is required")]
    public required TerraformValue<string> RecurrencePeriodEndDate
    {
        get => GetRequiredArgument<TerraformValue<string>>("recurrence_period_end_date");
        set => SetArgument("recurrence_period_end_date", value);
    }

    /// <summary>
    /// The recurrence_period_start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodStartDate is required")]
    public required TerraformValue<string> RecurrencePeriodStartDate
    {
        get => GetRequiredArgument<TerraformValue<string>>("recurrence_period_start_date");
        set => SetArgument("recurrence_period_start_date", value);
    }

    /// <summary>
    /// The recurrence_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceType is required")]
    public required TerraformValue<string> RecurrenceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("recurrence_type");
        set => SetArgument("recurrence_type", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformValue<string> SubscriptionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// ExportDataOptions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportDataOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataOptions block(s) allowed")]
    public required TerraformList<AzurermSubscriptionCostManagementExportExportDataOptionsBlock> ExportDataOptions
    {
        get => GetRequiredArgument<TerraformList<AzurermSubscriptionCostManagementExportExportDataOptionsBlock>>("export_data_options");
        set => SetArgument("export_data_options", value);
    }

    /// <summary>
    /// ExportDataStorageLocation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportDataStorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataStorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataStorageLocation block(s) allowed")]
    public required TerraformList<AzurermSubscriptionCostManagementExportExportDataStorageLocationBlock> ExportDataStorageLocation
    {
        get => GetRequiredArgument<TerraformList<AzurermSubscriptionCostManagementExportExportDataStorageLocationBlock>>("export_data_storage_location");
        set => SetArgument("export_data_storage_location", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubscriptionCostManagementExportTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubscriptionCostManagementExportTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
