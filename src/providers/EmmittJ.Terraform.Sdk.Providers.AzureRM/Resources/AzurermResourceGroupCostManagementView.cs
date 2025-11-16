using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for dataset in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementViewDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset";

    /// <summary>
    /// The granularity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Granularity is required")]
    public required TerraformValue<string> Granularity
    {
        get => new TerraformReference<string>(this, "granularity");
        set => SetArgument("granularity", value);
    }

}

/// <summary>
/// Block type for kpi in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementViewKpiBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kpi";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for pivot in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementViewPivotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pivot";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermResourceGroupCostManagementViewTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_resource_group_cost_management_view Terraform resource.
/// Manages a azurerm_resource_group_cost_management_view resource.
/// </summary>
public partial class AzurermResourceGroupCostManagementView(string name) : TerraformResource("azurerm_resource_group_cost_management_view", name)
{
    /// <summary>
    /// The accumulated attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Accumulated is required")]
    public required TerraformValue<bool> Accumulated
    {
        get => new TerraformReference<bool>(this, "accumulated");
        set => SetArgument("accumulated", value);
    }

    /// <summary>
    /// The chart_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChartType is required")]
    public required TerraformValue<string> ChartType
    {
        get => new TerraformReference<string>(this, "chart_type");
        set => SetArgument("chart_type", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The report_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportType is required")]
    public required TerraformValue<string> ReportType
    {
        get => new TerraformReference<string>(this, "report_type");
        set => SetArgument("report_type", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => new TerraformReference<string>(this, "resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// The timeframe attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeframe is required")]
    public required TerraformValue<string> Timeframe
    {
        get => new TerraformReference<string>(this, "timeframe");
        set => SetArgument("timeframe", value);
    }

    /// <summary>
    /// Dataset block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Dataset block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    public required TerraformList<AzurermResourceGroupCostManagementViewDatasetBlock> Dataset
    {
        get => GetRequiredArgument<TerraformList<AzurermResourceGroupCostManagementViewDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Kpi block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermResourceGroupCostManagementViewKpiBlock>? Kpi
    {
        get => GetArgument<TerraformList<AzurermResourceGroupCostManagementViewKpiBlock>>("kpi");
        set => SetArgument("kpi", value);
    }

    /// <summary>
    /// Pivot block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermResourceGroupCostManagementViewPivotBlock>? Pivot
    {
        get => GetArgument<TerraformList<AzurermResourceGroupCostManagementViewPivotBlock>>("pivot");
        set => SetArgument("pivot", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermResourceGroupCostManagementViewTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermResourceGroupCostManagementViewTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
