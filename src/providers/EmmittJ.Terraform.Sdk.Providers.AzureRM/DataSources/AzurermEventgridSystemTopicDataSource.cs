using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermEventgridSystemTopicDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_eventgrid_system_topic Terraform data source.
/// Retrieves information about a azurerm_eventgrid_system_topic.
/// </summary>
public partial class AzurermEventgridSystemTopicDataSource(string name) : TerraformDataSource("azurerm_eventgrid_system_topic", name)
{
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The metric_arm_resource_id attribute.
    /// </summary>
    public TerraformValue<string> MetricArmResourceId
    {
        get => new TerraformReference<string>(this, "metric_arm_resource_id");
    }

    /// <summary>
    /// The metric_resource_id attribute.
    /// </summary>
    public TerraformValue<string> MetricResourceId
    {
        get => new TerraformReference<string>(this, "metric_resource_id");
    }

    /// <summary>
    /// The source_arm_resource_id attribute.
    /// </summary>
    public TerraformValue<string> SourceArmResourceId
    {
        get => new TerraformReference<string>(this, "source_arm_resource_id");
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformValue<string> SourceResourceId
    {
        get => new TerraformReference<string>(this, "source_resource_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The topic_type attribute.
    /// </summary>
    public TerraformValue<string> TopicType
    {
        get => new TerraformReference<string>(this, "topic_type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventgridSystemTopicDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridSystemTopicDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
