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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The metric_arm_resource_id attribute.
    /// </summary>
    public TerraformValue<string> MetricArmResourceId
        => AsReference("metric_arm_resource_id");

    /// <summary>
    /// The metric_resource_id attribute.
    /// </summary>
    public TerraformValue<string> MetricResourceId
        => AsReference("metric_resource_id");

    /// <summary>
    /// The source_arm_resource_id attribute.
    /// </summary>
    public TerraformValue<string> SourceArmResourceId
        => AsReference("source_arm_resource_id");

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformValue<string> SourceResourceId
        => AsReference("source_resource_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The topic_type attribute.
    /// </summary>
    public TerraformValue<string> TopicType
        => AsReference("topic_type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventgridSystemTopicDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridSystemTopicDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
