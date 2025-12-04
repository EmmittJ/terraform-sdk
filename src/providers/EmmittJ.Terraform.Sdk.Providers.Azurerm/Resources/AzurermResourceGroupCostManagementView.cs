using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for dataset in AzurermResourceGroupCostManagementView.
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
        get => GetArgument<TerraformValue<string>>("granularity");
        set => SetArgument("granularity", value);
    }

    /// <summary>
    /// Aggregation block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Aggregation block(s) required")]
    public required TerraformSet<AzurermResourceGroupCostManagementViewDatasetBlockAggregationBlock> Aggregation
    {
        get => GetRequiredArgument<TerraformSet<AzurermResourceGroupCostManagementViewDatasetBlockAggregationBlock>>("aggregation");
        set => SetArgument("aggregation", value);
    }

    /// <summary>
    /// Grouping block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermResourceGroupCostManagementViewDatasetBlockGroupingBlock>? Grouping
    {
        get => GetArgument<TerraformList<AzurermResourceGroupCostManagementViewDatasetBlockGroupingBlock>>("grouping");
        set => SetArgument("grouping", value);
    }

    /// <summary>
    /// Sorting block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermResourceGroupCostManagementViewDatasetBlockSortingBlock>? Sorting
    {
        get => GetArgument<TerraformList<AzurermResourceGroupCostManagementViewDatasetBlockSortingBlock>>("sorting");
        set => SetArgument("sorting", value);
    }

}

/// <summary>
/// Block type for aggregation in AzurermResourceGroupCostManagementViewDatasetBlock.
/// Nesting mode: set
/// </summary>
public class AzurermResourceGroupCostManagementViewDatasetBlockAggregationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aggregation";

    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformValue<string> ColumnName
    {
        get => GetArgument<TerraformValue<string>>("column_name");
        set => SetArgument("column_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for grouping in AzurermResourceGroupCostManagementViewDatasetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementViewDatasetBlockGroupingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grouping";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for sorting in AzurermResourceGroupCostManagementViewDatasetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermResourceGroupCostManagementViewDatasetBlockSortingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sorting";

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformValue<string> Direction
    {
        get => GetArgument<TerraformValue<string>>("direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for kpi in AzurermResourceGroupCostManagementView.
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for pivot in AzurermResourceGroupCostManagementView.
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermResourceGroupCostManagementView.
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
        get => GetArgument<TerraformValue<bool>>("accumulated");
        set => SetArgument("accumulated", value);
    }

    /// <summary>
    /// The chart_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChartType is required")]
    public required TerraformValue<string> ChartType
    {
        get => GetArgument<TerraformValue<string>>("chart_type");
        set => SetArgument("chart_type", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The report_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportType is required")]
    public required TerraformValue<string> ReportType
    {
        get => GetArgument<TerraformValue<string>>("report_type");
        set => SetArgument("report_type", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => GetArgument<TerraformValue<string>>("resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// The timeframe attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeframe is required")]
    public required TerraformValue<string> Timeframe
    {
        get => GetArgument<TerraformValue<string>>("timeframe");
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
