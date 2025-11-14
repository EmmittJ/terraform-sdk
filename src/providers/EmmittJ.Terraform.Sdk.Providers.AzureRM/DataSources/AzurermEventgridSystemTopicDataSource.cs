using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridSystemTopicDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_eventgrid_system_topic.
/// </summary>
public class AzurermEventgridSystemTopicDataSource : TerraformDataSource
{
    public AzurermEventgridSystemTopicDataSource(string name) : base("azurerm_eventgrid_system_topic", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermEventgridSystemTopicDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The metric_arm_resource_id attribute.
    /// </summary>
    [TerraformArgument("metric_arm_resource_id")]
    public TerraformValue<string> MetricArmResourceId
    {
        get => new TerraformReference<string>(this, "metric_arm_resource_id");
    }

    /// <summary>
    /// The metric_resource_id attribute.
    /// </summary>
    [TerraformArgument("metric_resource_id")]
    public TerraformValue<string> MetricResourceId
    {
        get => new TerraformReference<string>(this, "metric_resource_id");
    }

    /// <summary>
    /// The source_arm_resource_id attribute.
    /// </summary>
    [TerraformArgument("source_arm_resource_id")]
    public TerraformValue<string> SourceArmResourceId
    {
        get => new TerraformReference<string>(this, "source_arm_resource_id");
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [TerraformArgument("source_resource_id")]
    public TerraformValue<string> SourceResourceId
    {
        get => new TerraformReference<string>(this, "source_resource_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The topic_type attribute.
    /// </summary>
    [TerraformArgument("topic_type")]
    public TerraformValue<string> TopicType
    {
        get => new TerraformReference<string>(this, "topic_type");
    }

}
