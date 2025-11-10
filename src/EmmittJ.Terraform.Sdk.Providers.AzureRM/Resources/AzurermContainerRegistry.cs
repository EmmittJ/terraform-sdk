using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for georeplications in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryGeoreplicationsBlock : TerraformBlock
{
    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The regional_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RegionalEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("regional_endpoint_enabled");
        set => WithProperty("regional_endpoint_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundancyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundancy_enabled");
        set => WithProperty("zone_redundancy_enabled", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryIdentityBlock : TerraformBlock
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_container_registry resource.
/// </summary>
public class AzurermContainerRegistry : TerraformResource
{
    public AzurermContainerRegistry(string name) : base("azurerm_container_registry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("admin_password");
        this.DeclareOutput("admin_username");
        this.DeclareOutput("data_endpoint_host_names");
        this.DeclareOutput("login_server");
    }

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AdminEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("admin_enabled");
        set => this.WithProperty("admin_enabled", value);
    }

    /// <summary>
    /// The anonymous_pull_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AnonymousPullEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("anonymous_pull_enabled");
        set => this.WithProperty("anonymous_pull_enabled", value);
    }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("data_endpoint_enabled");
        set => this.WithProperty("data_endpoint_enabled", value);
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public List<TerraformProperty<object>>? Encryption
    {
        get => GetProperty<List<TerraformProperty<object>>>("encryption");
        set => this.WithProperty("encryption", value);
    }

    /// <summary>
    /// The export_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExportPolicyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("export_policy_enabled");
        set => this.WithProperty("export_policy_enabled", value);
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
    /// The network_rule_bypass_option attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkRuleBypassOption
    {
        get => GetProperty<TerraformProperty<string>>("network_rule_bypass_option");
        set => this.WithProperty("network_rule_bypass_option", value);
    }

    /// <summary>
    /// The network_rule_set attribute.
    /// </summary>
    public List<TerraformProperty<object>>? NetworkRuleSet
    {
        get => GetProperty<List<TerraformProperty<object>>>("network_rule_set");
        set => this.WithProperty("network_rule_set", value);
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
    /// The quarantine_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? QuarantinePolicyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("quarantine_policy_enabled");
        set => this.WithProperty("quarantine_policy_enabled", value);
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
    /// The retention_policy_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPolicyInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_policy_in_days");
        set => this.WithProperty("retention_policy_in_days", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
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
    /// The trust_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TrustPolicyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("trust_policy_enabled");
        set => this.WithProperty("trust_policy_enabled", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundancyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundancy_enabled");
        set => this.WithProperty("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// Block for georeplications.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerRegistryGeoreplicationsBlock>? Georeplications
    {
        get => GetProperty<List<AzurermContainerRegistryGeoreplicationsBlock>>("georeplications");
        set => this.WithProperty("georeplications", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerRegistryIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermContainerRegistryIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerRegistryTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerRegistryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformExpression AdminPassword => this["admin_password"];

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformExpression AdminUsername => this["admin_username"];

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    public TerraformExpression DataEndpointHostNames => this["data_endpoint_host_names"];

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    public TerraformExpression LoginServer => this["login_server"];

}
