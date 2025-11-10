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
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The regional_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RegionalEndpointEnabled
    {
        set => SetProperty("regional_endpoint_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundancyEnabled
    {
        set => SetProperty("zone_redundancy_enabled", value);
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
public class AzurermContainerRegistryTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_container_registry resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerRegistry : TerraformResource
{
    public AzurermContainerRegistry(string name) : base("azurerm_container_registry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("admin_password");
        SetOutput("admin_username");
        SetOutput("data_endpoint_host_names");
        SetOutput("login_server");
        SetOutput("admin_enabled");
        SetOutput("anonymous_pull_enabled");
        SetOutput("data_endpoint_enabled");
        SetOutput("encryption");
        SetOutput("export_policy_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network_rule_bypass_option");
        SetOutput("network_rule_set");
        SetOutput("public_network_access_enabled");
        SetOutput("quarantine_policy_enabled");
        SetOutput("resource_group_name");
        SetOutput("retention_policy_in_days");
        SetOutput("sku");
        SetOutput("tags");
        SetOutput("trust_policy_enabled");
        SetOutput("zone_redundancy_enabled");
    }

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AdminEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("admin_enabled");
        set => SetProperty("admin_enabled", value);
    }

    /// <summary>
    /// The anonymous_pull_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AnonymousPullEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("anonymous_pull_enabled");
        set => SetProperty("anonymous_pull_enabled", value);
    }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DataEndpointEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("data_endpoint_enabled");
        set => SetProperty("data_endpoint_enabled", value);
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public List<TerraformProperty<object>> Encryption
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("encryption");
        set => SetProperty("encryption", value);
    }

    /// <summary>
    /// The export_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ExportPolicyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("export_policy_enabled");
        set => SetProperty("export_policy_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The network_rule_bypass_option attribute.
    /// </summary>
    public TerraformProperty<string> NetworkRuleBypassOption
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_rule_bypass_option");
        set => SetProperty("network_rule_bypass_option", value);
    }

    /// <summary>
    /// The network_rule_set attribute.
    /// </summary>
    public List<TerraformProperty<object>> NetworkRuleSet
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("network_rule_set");
        set => SetProperty("network_rule_set", value);
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
    /// The quarantine_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> QuarantinePolicyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("quarantine_policy_enabled");
        set => SetProperty("quarantine_policy_enabled", value);
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
    /// The retention_policy_in_days attribute.
    /// </summary>
    public TerraformProperty<double> RetentionPolicyInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_policy_in_days");
        set => SetProperty("retention_policy_in_days", value);
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
    /// The trust_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TrustPolicyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("trust_policy_enabled");
        set => SetProperty("trust_policy_enabled", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneRedundancyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_redundancy_enabled");
        set => SetProperty("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// Block for georeplications.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerRegistryGeoreplicationsBlock>? Georeplications
    {
        set => SetProperty("georeplications", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerRegistryIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerRegistryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
