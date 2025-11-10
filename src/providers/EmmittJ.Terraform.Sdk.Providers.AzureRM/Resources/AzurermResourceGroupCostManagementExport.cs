using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for export_data_options in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementExportExportDataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The time_frame attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeFrame is required")]
    public required TerraformProperty<string> TimeFrame
    {
        set => SetProperty("time_frame", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for export_data_storage_location in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementExportExportDataStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// The container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerId is required")]
    public required TerraformProperty<string> ContainerId
    {
        set => SetProperty("container_id", value);
    }

    /// <summary>
    /// The root_folder_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolderPath is required")]
    public required TerraformProperty<string> RootFolderPath
    {
        set => SetProperty("root_folder_path", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermResourceGroupCostManagementExportTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("active");
        SetOutput("file_format");
        SetOutput("id");
        SetOutput("name");
        SetOutput("recurrence_period_end_date");
        SetOutput("recurrence_period_start_date");
        SetOutput("recurrence_type");
        SetOutput("resource_group_id");
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool> Active
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("active");
        set => SetProperty("active", value);
    }

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    public TerraformProperty<string> FileFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_format");
        set => SetProperty("file_format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The recurrence_period_end_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodEndDate is required")]
    public required TerraformProperty<string> RecurrencePeriodEndDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recurrence_period_end_date");
        set => SetProperty("recurrence_period_end_date", value);
    }

    /// <summary>
    /// The recurrence_period_start_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrencePeriodStartDate is required")]
    public required TerraformProperty<string> RecurrencePeriodStartDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recurrence_period_start_date");
        set => SetProperty("recurrence_period_start_date", value);
    }

    /// <summary>
    /// The recurrence_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceType is required")]
    public required TerraformProperty<string> RecurrenceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recurrence_type");
        set => SetProperty("recurrence_type", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformProperty<string> ResourceGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_id");
        set => SetProperty("resource_group_id", value);
    }

    /// <summary>
    /// Block for export_data_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportDataOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataOptions block(s) allowed")]
    public List<AzurermResourceGroupCostManagementExportExportDataOptionsBlock>? ExportDataOptions
    {
        set => SetProperty("export_data_options", value);
    }

    /// <summary>
    /// Block for export_data_storage_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportDataStorageLocation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportDataStorageLocation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportDataStorageLocation block(s) allowed")]
    public List<AzurermResourceGroupCostManagementExportExportDataStorageLocationBlock>? ExportDataStorageLocation
    {
        set => SetProperty("export_data_storage_location", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermResourceGroupCostManagementExportTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
