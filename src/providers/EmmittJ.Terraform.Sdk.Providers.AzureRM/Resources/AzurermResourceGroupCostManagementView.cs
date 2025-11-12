using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dataset in .
/// Nesting mode: list
/// </summary>
public partial class AzurermResourceGroupCostManagementViewDatasetBlock() : TerraformBlock("dataset")
{
    /// <summary>
    /// The granularity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Granularity is required")]
    [TerraformProperty("granularity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Granularity { get; set; }

}

/// <summary>
/// Block type for kpi in .
/// Nesting mode: list
/// </summary>
public partial class AzurermResourceGroupCostManagementViewKpiBlock() : TerraformBlock("kpi")
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for pivot in .
/// Nesting mode: list
/// </summary>
public partial class AzurermResourceGroupCostManagementViewPivotBlock() : TerraformBlock("pivot")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermResourceGroupCostManagementViewTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_resource_group_cost_management_view resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermResourceGroupCostManagementView : TerraformResource
{
    public AzurermResourceGroupCostManagementView(string name) : base("azurerm_resource_group_cost_management_view", name)
    {
    }

    /// <summary>
    /// The accumulated attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Accumulated is required")]
    [TerraformProperty("accumulated")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Accumulated { get; set; }

    /// <summary>
    /// The chart_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChartType is required")]
    [TerraformProperty("chart_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ChartType { get; set; }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The report_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportType is required")]
    [TerraformProperty("report_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReportType { get; set; }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    [TerraformProperty("resource_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupId { get; set; }

    /// <summary>
    /// The timeframe attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeframe is required")]
    [TerraformProperty("timeframe")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Timeframe { get; set; }

    /// <summary>
    /// Block for dataset.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Dataset block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    [TerraformProperty("dataset")]
    public required TerraformList<AzurermResourceGroupCostManagementViewDatasetBlock> Dataset { get; set; } = new();

    /// <summary>
    /// Block for kpi.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("kpi")]
    public TerraformList<AzurermResourceGroupCostManagementViewKpiBlock> Kpi { get; set; } = new();

    /// <summary>
    /// Block for pivot.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("pivot")]
    public TerraformList<AzurermResourceGroupCostManagementViewPivotBlock> Pivot { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermResourceGroupCostManagementViewTimeoutsBlock Timeouts { get; set; } = new();

}
