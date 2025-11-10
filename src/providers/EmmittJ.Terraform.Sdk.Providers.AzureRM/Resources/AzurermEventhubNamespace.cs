using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventhubNamespaceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_eventhub_namespace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermEventhubNamespace : TerraformResource
{
    public AzurermEventhubNamespace(string name) : base("azurerm_eventhub_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("default_primary_connection_string");
        SetOutput("default_primary_connection_string_alias");
        SetOutput("default_primary_key");
        SetOutput("default_secondary_connection_string");
        SetOutput("default_secondary_connection_string_alias");
        SetOutput("default_secondary_key");
        SetOutput("auto_inflate_enabled");
        SetOutput("capacity");
        SetOutput("dedicated_cluster_id");
        SetOutput("id");
        SetOutput("local_authentication_enabled");
        SetOutput("location");
        SetOutput("maximum_throughput_units");
        SetOutput("minimum_tls_version");
        SetOutput("name");
        SetOutput("network_rulesets");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("tags");
    }

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoInflateEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_inflate_enabled");
        set => SetProperty("auto_inflate_enabled", value);
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double> Capacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("capacity");
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string> DedicatedClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dedicated_cluster_id");
        set => SetProperty("dedicated_cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalAuthenticationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_authentication_enabled");
        set => SetProperty("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    public TerraformProperty<double> MaximumThroughputUnits
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_throughput_units");
        set => SetProperty("maximum_throughput_units", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string> MinimumTlsVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("minimum_tls_version");
        set => SetProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_rulesets attribute.
    /// </summary>
    public List<TerraformProperty<object>> NetworkRulesets
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("network_rulesets");
        set => SetProperty("network_rulesets", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermEventhubNamespaceIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventhubNamespaceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryConnectionString => this["default_primary_connection_string"];

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryConnectionStringAlias => this["default_primary_connection_string_alias"];

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryKey => this["default_primary_key"];

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryConnectionString => this["default_secondary_connection_string"];

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryConnectionStringAlias => this["default_secondary_connection_string_alias"];

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryKey => this["default_secondary_key"];

}
