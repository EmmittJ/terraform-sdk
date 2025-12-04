using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermEventgridSystemTopic.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridSystemTopicIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

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
/// Block type for timeouts in AzurermEventgridSystemTopic.
/// Nesting mode: single
/// </summary>
public class AzurermEventgridSystemTopicTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_eventgrid_system_topic Terraform resource.
/// Manages a azurerm_eventgrid_system_topic resource.
/// </summary>
public partial class AzurermEventgridSystemTopic(string name) : TerraformResource("azurerm_eventgrid_system_topic", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_arm_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? SourceArmResourceId
    {
        get => GetArgument<TerraformValue<string>>("source_arm_resource_id");
        set => SetArgument("source_arm_resource_id", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceResourceId
    {
        get => GetArgument<TerraformValue<string>>("source_resource_id");
        set => SetArgument("source_resource_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The topic_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicType is required")]
    public required TerraformValue<string> TopicType
    {
        get => GetArgument<TerraformValue<string>>("topic_type");
        set => SetArgument("topic_type", value);
    }

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
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermEventgridSystemTopicIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermEventgridSystemTopicIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventgridSystemTopicTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridSystemTopicTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
