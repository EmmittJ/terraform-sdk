using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridDomainIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for input_mapping_default_values in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridDomainInputMappingDefaultValuesBlock : TerraformBlock
{
    /// <summary>
    /// The data_version attribute.
    /// </summary>
    public TerraformProperty<string>? DataVersion
    {
        get => GetProperty<TerraformProperty<string>>("data_version");
        set => WithProperty("data_version", value);
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    public TerraformProperty<string>? EventType
    {
        get => GetProperty<TerraformProperty<string>>("event_type");
        set => WithProperty("event_type", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformProperty<string>? Subject
    {
        get => GetProperty<TerraformProperty<string>>("subject");
        set => WithProperty("subject", value);
    }

}

/// <summary>
/// Block type for input_mapping_fields in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridDomainInputMappingFieldsBlock : TerraformBlock
{
    /// <summary>
    /// The data_version attribute.
    /// </summary>
    public TerraformProperty<string>? DataVersion
    {
        get => GetProperty<TerraformProperty<string>>("data_version");
        set => WithProperty("data_version", value);
    }

    /// <summary>
    /// The event_time attribute.
    /// </summary>
    public TerraformProperty<string>? EventTime
    {
        get => GetProperty<TerraformProperty<string>>("event_time");
        set => WithProperty("event_time", value);
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    public TerraformProperty<string>? EventType
    {
        get => GetProperty<TerraformProperty<string>>("event_type");
        set => WithProperty("event_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformProperty<string>? Subject
    {
        get => GetProperty<TerraformProperty<string>>("subject");
        set => WithProperty("subject", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    public TerraformProperty<string>? Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("secondary_access_key");
    }

    /// <summary>
    /// The auto_create_topic_with_first_subscription attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoCreateTopicWithFirstSubscription
    {
        get => GetProperty<TerraformProperty<bool>>("auto_create_topic_with_first_subscription");
        set => this.WithProperty("auto_create_topic_with_first_subscription", value);
    }

    /// <summary>
    /// The auto_delete_topic_with_last_subscription attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoDeleteTopicWithLastSubscription
    {
        get => GetProperty<TerraformProperty<bool>>("auto_delete_topic_with_last_subscription");
        set => this.WithProperty("auto_delete_topic_with_last_subscription", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The inbound_ip_rule attribute.
    /// </summary>
    public List<TerraformProperty<object>>? InboundIpRule
    {
        get => GetProperty<List<TerraformProperty<object>>>("inbound_ip_rule");
        set => this.WithProperty("inbound_ip_rule", value);
    }

    /// <summary>
    /// The input_schema attribute.
    /// </summary>
    public TerraformProperty<string>? InputSchema
    {
        get => GetProperty<TerraformProperty<string>>("input_schema");
        set => this.WithProperty("input_schema", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_auth_enabled");
        set => this.WithProperty("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermEventgridDomainIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermEventgridDomainIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for input_mapping_default_values.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputMappingDefaultValues block(s) allowed")]
    public List<AzurermEventgridDomainInputMappingDefaultValuesBlock>? InputMappingDefaultValues
    {
        get => GetProperty<List<AzurermEventgridDomainInputMappingDefaultValuesBlock>>("input_mapping_default_values");
        set => this.WithProperty("input_mapping_default_values", value);
    }

    /// <summary>
    /// Block for input_mapping_fields.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputMappingFields block(s) allowed")]
    public List<AzurermEventgridDomainInputMappingFieldsBlock>? InputMappingFields
    {
        get => GetProperty<List<AzurermEventgridDomainInputMappingFieldsBlock>>("input_mapping_fields");
        set => this.WithProperty("input_mapping_fields", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventgridDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermEventgridDomainTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

}
