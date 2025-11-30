using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for dataset in AzurermSubscriptionCostManagementView.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementViewDatasetBlock : TerraformBlock
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

    /// <summary>
    /// Aggregation block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Aggregation block(s) required")]
    public required TerraformSet<AzurermSubscriptionCostManagementViewDatasetBlockAggregationBlock> Aggregation
    {
        get => GetRequiredArgument<TerraformSet<AzurermSubscriptionCostManagementViewDatasetBlockAggregationBlock>>("aggregation");
        set => SetArgument("aggregation", value);
    }

    /// <summary>
    /// Grouping block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSubscriptionCostManagementViewDatasetBlockGroupingBlock>? Grouping
    {
        get => GetArgument<TerraformList<AzurermSubscriptionCostManagementViewDatasetBlockGroupingBlock>>("grouping");
        set => SetArgument("grouping", value);
    }

    /// <summary>
    /// Sorting block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSubscriptionCostManagementViewDatasetBlockSortingBlock>? Sorting
    {
        get => GetArgument<TerraformList<AzurermSubscriptionCostManagementViewDatasetBlockSortingBlock>>("sorting");
        set => SetArgument("sorting", value);
    }

}

/// <summary>
/// Block type for aggregation in AzurermSubscriptionCostManagementViewDatasetBlock.
/// Nesting mode: set
/// </summary>
public class AzurermSubscriptionCostManagementViewDatasetBlockAggregationBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "column_name");
        set => SetArgument("column_name", value);
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

}

/// <summary>
/// Block type for grouping in AzurermSubscriptionCostManagementViewDatasetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementViewDatasetBlockGroupingBlock : TerraformBlock
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
/// Block type for sorting in AzurermSubscriptionCostManagementViewDatasetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementViewDatasetBlockSortingBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "direction");
        set => SetArgument("direction", value);
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

}


/// <summary>
/// Block type for kpi in AzurermSubscriptionCostManagementView.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementViewKpiBlock : TerraformBlock
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
/// Block type for pivot in AzurermSubscriptionCostManagementView.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionCostManagementViewPivotBlock : TerraformBlock
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
/// Block type for timeouts in AzurermSubscriptionCostManagementView.
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionCostManagementViewTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_subscription_cost_management_view Terraform resource.
/// Manages a azurerm_subscription_cost_management_view resource.
/// </summary>
public partial class AzurermSubscriptionCostManagementView(string name) : TerraformResource("azurerm_subscription_cost_management_view", name)
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
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformValue<string> SubscriptionId
    {
        get => new TerraformReference<string>(this, "subscription_id");
        set => SetArgument("subscription_id", value);
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
    public required TerraformList<AzurermSubscriptionCostManagementViewDatasetBlock> Dataset
    {
        get => GetRequiredArgument<TerraformList<AzurermSubscriptionCostManagementViewDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Kpi block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSubscriptionCostManagementViewKpiBlock>? Kpi
    {
        get => GetArgument<TerraformList<AzurermSubscriptionCostManagementViewKpiBlock>>("kpi");
        set => SetArgument("kpi", value);
    }

    /// <summary>
    /// Pivot block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSubscriptionCostManagementViewPivotBlock>? Pivot
    {
        get => GetArgument<TerraformList<AzurermSubscriptionCostManagementViewPivotBlock>>("pivot");
        set => SetArgument("pivot", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubscriptionCostManagementViewTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubscriptionCostManagementViewTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
