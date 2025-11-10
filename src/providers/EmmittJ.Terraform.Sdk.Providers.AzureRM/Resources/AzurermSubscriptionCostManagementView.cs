using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dataset in .
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementViewDatasetBlock : TerraformBlock
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
public class AzurermSubscriptionCostManagementViewKpiBlock : TerraformBlock
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
public class AzurermSubscriptionCostManagementViewPivotBlock : TerraformBlock
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
public class AzurermSubscriptionCostManagementViewTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_subscription_cost_management_view resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSubscriptionCostManagementView : TerraformResource
{
    public AzurermSubscriptionCostManagementView(string name) : base("azurerm_subscription_cost_management_view", name)
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
        SetOutput("subscription_id");
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
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
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
    public List<AzurermSubscriptionCostManagementViewDatasetBlock>? Dataset
    {
        set => SetProperty("dataset", value);
    }

    /// <summary>
    /// Block for kpi.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSubscriptionCostManagementViewKpiBlock>? Kpi
    {
        set => SetProperty("kpi", value);
    }

    /// <summary>
    /// Block for pivot.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSubscriptionCostManagementViewPivotBlock>? Pivot
    {
        set => SetProperty("pivot", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubscriptionCostManagementViewTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
