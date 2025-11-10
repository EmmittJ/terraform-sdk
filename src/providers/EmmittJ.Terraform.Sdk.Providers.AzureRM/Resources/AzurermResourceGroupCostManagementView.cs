using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dataset in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementViewDatasetBlock : TerraformBlock
{
    /// <summary>
    /// The granularity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Granularity is required")]
    public required TerraformProperty<string> Granularity
    {
        set => SetProperty("granularity", value);
    }

}

/// <summary>
/// Block type for kpi in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementViewKpiBlock : TerraformBlock
{
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
/// Block type for pivot in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementViewPivotBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermResourceGroupCostManagementViewTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_resource_group_cost_management_view resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermResourceGroupCostManagementView : TerraformResource
{
    public AzurermResourceGroupCostManagementView(string name) : base("azurerm_resource_group_cost_management_view", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("accumulated");
        SetOutput("chart_type");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("report_type");
        SetOutput("resource_group_id");
        SetOutput("timeframe");
    }

    /// <summary>
    /// The accumulated attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Accumulated is required")]
    public required TerraformProperty<bool> Accumulated
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("accumulated");
        set => SetProperty("accumulated", value);
    }

    /// <summary>
    /// The chart_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChartType is required")]
    public required TerraformProperty<string> ChartType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("chart_type");
        set => SetProperty("chart_type", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The report_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportType is required")]
    public required TerraformProperty<string> ReportType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("report_type");
        set => SetProperty("report_type", value);
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
    /// The timeframe attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeframe is required")]
    public required TerraformProperty<string> Timeframe
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timeframe");
        set => SetProperty("timeframe", value);
    }

    /// <summary>
    /// Block for dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Dataset block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    public List<AzurermResourceGroupCostManagementViewDatasetBlock>? Dataset
    {
        set => SetProperty("dataset", value);
    }

    /// <summary>
    /// Block for kpi.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermResourceGroupCostManagementViewKpiBlock>? Kpi
    {
        set => SetProperty("kpi", value);
    }

    /// <summary>
    /// Block for pivot.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermResourceGroupCostManagementViewPivotBlock>? Pivot
    {
        set => SetProperty("pivot", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermResourceGroupCostManagementViewTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
