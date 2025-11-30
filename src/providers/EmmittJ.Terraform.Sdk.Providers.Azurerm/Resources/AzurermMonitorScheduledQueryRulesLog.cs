using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for criteria in AzurermMonitorScheduledQueryRulesLog.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesLogCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criteria";

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dimension is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Dimension block(s) required")]
    public required TerraformSet<AzurermMonitorScheduledQueryRulesLogCriteriaBlockDimensionBlock> Dimension
    {
        get => GetRequiredArgument<TerraformSet<AzurermMonitorScheduledQueryRulesLogCriteriaBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

}

/// <summary>
/// Block type for dimension in AzurermMonitorScheduledQueryRulesLogCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AzurermMonitorScheduledQueryRulesLogCriteriaBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

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
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorScheduledQueryRulesLog.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorScheduledQueryRulesLogTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_scheduled_query_rules_log Terraform resource.
/// Manages a azurerm_monitor_scheduled_query_rules_log resource.
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesLog(string name) : TerraformResource("azurerm_monitor_scheduled_query_rules_log", name)
{
    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    public TerraformSet<string>? AuthorizedResourceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "authorized_resource_ids").ResolveNodes(ctx));
        set => SetArgument("authorized_resource_ids", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    public required TerraformValue<string> DataSourceId
    {
        get => new TerraformReference<string>(this, "data_source_id");
        set => SetArgument("data_source_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Criteria block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Criteria block(s) allowed")]
    public required TerraformList<AzurermMonitorScheduledQueryRulesLogCriteriaBlock> Criteria
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorScheduledQueryRulesLogCriteriaBlock>>("criteria");
        set => SetArgument("criteria", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorScheduledQueryRulesLogTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorScheduledQueryRulesLogTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
