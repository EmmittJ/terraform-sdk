using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermEventgridDomain.
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
/// Block type for input_mapping_default_values in AzurermEventgridDomain.
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
    public TerraformValue<string>? DataVersion
    {
        get => GetArgument<TerraformValue<string>>("data_version");
        set => SetArgument("data_version", value);
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    public TerraformValue<string>? EventType
    {
        get => GetArgument<TerraformValue<string>>("event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string>? Subject
    {
        get => GetArgument<TerraformValue<string>>("subject");
        set => SetArgument("subject", value);
    }

}


/// <summary>
/// Block type for input_mapping_fields in AzurermEventgridDomain.
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
    public TerraformValue<string>? DataVersion
    {
        get => GetArgument<TerraformValue<string>>("data_version");
        set => SetArgument("data_version", value);
    }

    /// <summary>
    /// The event_time attribute.
    /// </summary>
    public TerraformValue<string>? EventTime
    {
        get => GetArgument<TerraformValue<string>>("event_time");
        set => SetArgument("event_time", value);
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    public TerraformValue<string>? EventType
    {
        get => GetArgument<TerraformValue<string>>("event_type");
        set => SetArgument("event_type", value);
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
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string>? Subject
    {
        get => GetArgument<TerraformValue<string>>("subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermEventgridDomain.
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
/// Represents a azurerm_eventgrid_domain Terraform resource.
/// Manages a azurerm_eventgrid_domain resource.
/// </summary>
public partial class AzurermEventgridDomain(string name) : TerraformResource("azurerm_eventgrid_domain", name)
{
    /// <summary>
    /// The auto_create_topic_with_first_subscription attribute.
    /// </summary>
    public TerraformValue<bool>? AutoCreateTopicWithFirstSubscription
    {
        get => GetArgument<TerraformValue<bool>>("auto_create_topic_with_first_subscription");
        set => SetArgument("auto_create_topic_with_first_subscription", value);
    }

    /// <summary>
    /// The auto_delete_topic_with_last_subscription attribute.
    /// </summary>
    public TerraformValue<bool>? AutoDeleteTopicWithLastSubscription
    {
        get => GetArgument<TerraformValue<bool>>("auto_delete_topic_with_last_subscription");
        set => SetArgument("auto_delete_topic_with_last_subscription", value);
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
    /// The inbound_ip_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? InboundIpRule
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("inbound_ip_rule");
        set => SetArgument("inbound_ip_rule", value);
    }

    /// <summary>
    /// The input_schema attribute.
    /// </summary>
    public TerraformValue<string>? InputSchema
    {
        get => GetArgument<TerraformValue<string>>("input_schema");
        set => SetArgument("input_schema", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermEventgridDomainIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermEventgridDomainIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// InputMappingDefaultValues block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputMappingDefaultValues block(s) allowed")]
    public TerraformList<AzurermEventgridDomainInputMappingDefaultValuesBlock>? InputMappingDefaultValues
    {
        get => GetArgument<TerraformList<AzurermEventgridDomainInputMappingDefaultValuesBlock>>("input_mapping_default_values");
        set => SetArgument("input_mapping_default_values", value);
    }

    /// <summary>
    /// InputMappingFields block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputMappingFields block(s) allowed")]
    public TerraformList<AzurermEventgridDomainInputMappingFieldsBlock>? InputMappingFields
    {
        get => GetArgument<TerraformList<AzurermEventgridDomainInputMappingFieldsBlock>>("input_mapping_fields");
        set => SetArgument("input_mapping_fields", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventgridDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
