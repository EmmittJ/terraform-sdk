using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for export_data_options in .
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementExportExportDataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The time_frame attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeFrame is required")]
    public required TerraformProperty<string> TimeFrame
    {
        get => GetProperty<TerraformProperty<string>>("time_frame");
        set => WithProperty("time_frame", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for export_data_storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementExportExportDataStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    public required TerraformProperty<string> ContainerId
    {
        get => GetProperty<TerraformProperty<string>>("container_id");
        set => WithProperty("container_id", value);
    }

    /// <summary>
    /// The root_folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolderPath is required")]
    public required TerraformProperty<string> RootFolderPath
    {
        get => GetProperty<TerraformProperty<string>>("root_folder_path");
        set => WithProperty("root_folder_path", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionCostManagementExportTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_subscription_cost_management_export resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSubscriptionCostManagementExport : TerraformResource
{
    public AzurermSubscriptionCostManagementExport(string name) : base("azurerm_subscription_cost_management_export", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool>? Active
    {
        get => GetProperty<TerraformProperty<bool>>("active");
        set => this.WithProperty("active", value);
    }

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    public TerraformProperty<string>? FileFormat
    {
        get => GetProperty<TerraformProperty<string>>("file_format");
        set => this.WithProperty("file_format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recurrence_period_end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodEndDate is required")]
    public required TerraformProperty<string> RecurrencePeriodEndDate
    {
        get => GetProperty<TerraformProperty<string>>("recurrence_period_end_date");
        set => this.WithProperty("recurrence_period_end_date", value);
    }

    /// <summary>
    /// The recurrence_period_start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodStartDate is required")]
    public required TerraformProperty<string> RecurrencePeriodStartDate
    {
        get => GetProperty<TerraformProperty<string>>("recurrence_period_start_date");
        set => this.WithProperty("recurrence_period_start_date", value);
    }

    /// <summary>
    /// The recurrence_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceType is required")]
    public required TerraformProperty<string> RecurrenceType
    {
        get => GetProperty<TerraformProperty<string>>("recurrence_type");
        set => this.WithProperty("recurrence_type", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformProperty<string> SubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for export_data_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataOptions block(s) allowed")]
    public List<AzurermSubscriptionCostManagementExportExportDataOptionsBlock>? ExportDataOptions
    {
        get => GetProperty<List<AzurermSubscriptionCostManagementExportExportDataOptionsBlock>>("export_data_options");
        set => this.WithProperty("export_data_options", value);
    }

    /// <summary>
    /// Block for export_data_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataStorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataStorageLocation block(s) allowed")]
    public List<AzurermSubscriptionCostManagementExportExportDataStorageLocationBlock>? ExportDataStorageLocation
    {
        get => GetProperty<List<AzurermSubscriptionCostManagementExportExportDataStorageLocationBlock>>("export_data_storage_location");
        set => this.WithProperty("export_data_storage_location", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubscriptionCostManagementExportTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSubscriptionCostManagementExportTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
