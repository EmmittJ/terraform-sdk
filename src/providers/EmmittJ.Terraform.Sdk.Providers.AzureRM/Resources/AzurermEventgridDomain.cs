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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridDomainIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for input_mapping_default_values in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridDomainInputMappingDefaultValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_mapping_default_values";

    /// <summary>
    /// The data_version attribute.
    /// </summary>
    [TerraformArgument("data_version")]
    public TerraformValue<string>? DataVersion
    {
        get => new TerraformReference<string>(this, "data_version");
        set => SetArgument("data_version", value);
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [TerraformArgument("event_type")]
    public TerraformValue<string>? EventType
    {
        get => new TerraformReference<string>(this, "event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformArgument("subject")]
    public TerraformValue<string>? Subject
    {
        get => new TerraformReference<string>(this, "subject");
        set => SetArgument("subject", value);
    }

}

/// <summary>
/// Block type for input_mapping_fields in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridDomainInputMappingFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_mapping_fields";

    /// <summary>
    /// The data_version attribute.
    /// </summary>
    [TerraformArgument("data_version")]
    public TerraformValue<string>? DataVersion
    {
        get => new TerraformReference<string>(this, "data_version");
        set => SetArgument("data_version", value);
    }

    /// <summary>
    /// The event_time attribute.
    /// </summary>
    [TerraformArgument("event_time")]
    public TerraformValue<string>? EventTime
    {
        get => new TerraformReference<string>(this, "event_time");
        set => SetArgument("event_time", value);
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [TerraformArgument("event_type")]
    public TerraformValue<string>? EventType
    {
        get => new TerraformReference<string>(this, "event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformArgument("subject")]
    public TerraformValue<string>? Subject
    {
        get => new TerraformReference<string>(this, "subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [TerraformArgument("topic")]
    public TerraformValue<string>? Topic
    {
        get => new TerraformReference<string>(this, "topic");
        set => SetArgument("topic", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_eventgrid_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermEventgridDomain : TerraformResource
{
    public AzurermEventgridDomain(string name) : base("azurerm_eventgrid_domain", name)
    {
    }

    /// <summary>
    /// The auto_create_topic_with_first_subscription attribute.
    /// </summary>
    [TerraformArgument("auto_create_topic_with_first_subscription")]
    public TerraformValue<bool>? AutoCreateTopicWithFirstSubscription
    {
        get => new TerraformReference<bool>(this, "auto_create_topic_with_first_subscription");
        set => SetArgument("auto_create_topic_with_first_subscription", value);
    }

    /// <summary>
    /// The auto_delete_topic_with_last_subscription attribute.
    /// </summary>
    [TerraformArgument("auto_delete_topic_with_last_subscription")]
    public TerraformValue<bool>? AutoDeleteTopicWithLastSubscription
    {
        get => new TerraformReference<bool>(this, "auto_delete_topic_with_last_subscription");
        set => SetArgument("auto_delete_topic_with_last_subscription", value);
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
    /// The inbound_ip_rule attribute.
    /// </summary>
    [TerraformArgument("inbound_ip_rule")]
    public TerraformList<object>? InboundIpRule
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "inbound_ip_rule").ResolveNodes(ctx));
        set => SetArgument("inbound_ip_rule", value);
    }

    /// <summary>
    /// The input_schema attribute.
    /// </summary>
    [TerraformArgument("input_schema")]
    public TerraformValue<string>? InputSchema
    {
        get => new TerraformReference<string>(this, "input_schema");
        set => SetArgument("input_schema", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformArgument("local_auth_enabled")]
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => new TerraformReference<bool>(this, "local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermEventgridDomainIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for input_mapping_default_values.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputMappingDefaultValues block(s) allowed")]
    [TerraformArgument("input_mapping_default_values")]
    public TerraformList<AzurermEventgridDomainInputMappingDefaultValuesBlock> InputMappingDefaultValues { get; set; } = new();

    /// <summary>
    /// Block for input_mapping_fields.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputMappingFields block(s) allowed")]
    [TerraformArgument("input_mapping_fields")]
    public TerraformList<AzurermEventgridDomainInputMappingFieldsBlock> InputMappingFields { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermEventgridDomainTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformArgument("primary_access_key")]
    public TerraformValue<string> PrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "primary_access_key");
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformArgument("secondary_access_key")]
    public TerraformValue<string> SecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "secondary_access_key");
    }

}
