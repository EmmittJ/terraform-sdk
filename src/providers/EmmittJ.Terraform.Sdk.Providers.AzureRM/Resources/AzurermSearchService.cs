using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermSearchServiceIdentityBlock : TerraformBlock
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
public class AzurermSearchServiceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_search_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSearchService : TerraformResource
{
    public AzurermSearchService(string name) : base("azurerm_search_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("customer_managed_key_encryption_compliance_status");
        SetOutput("primary_key");
        SetOutput("query_keys");
        SetOutput("secondary_key");
        SetOutput("allowed_ips");
        SetOutput("authentication_failure_mode");
        SetOutput("customer_managed_key_enforcement_enabled");
        SetOutput("hosting_mode");
        SetOutput("id");
        SetOutput("local_authentication_enabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network_rule_bypass_option");
        SetOutput("partition_count");
        SetOutput("public_network_access_enabled");
        SetOutput("replica_count");
        SetOutput("resource_group_name");
        SetOutput("semantic_search_sku");
        SetOutput("sku");
        SetOutput("tags");
    }

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AllowedIps
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("allowed_ips");
        set => SetProperty("allowed_ips", value);
    }

    /// <summary>
    /// The authentication_failure_mode attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationFailureMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_failure_mode");
        set => SetProperty("authentication_failure_mode", value);
    }

    /// <summary>
    /// The customer_managed_key_enforcement_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CustomerManagedKeyEnforcementEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("customer_managed_key_enforcement_enabled");
        set => SetProperty("customer_managed_key_enforcement_enabled", value);
    }

    /// <summary>
    /// The hosting_mode attribute.
    /// </summary>
    public TerraformProperty<string> HostingMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hosting_mode");
        set => SetProperty("hosting_mode", value);
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
    /// The partition_count attribute.
    /// </summary>
    public TerraformProperty<double> PartitionCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("partition_count");
        set => SetProperty("partition_count", value);
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
    /// The replica_count attribute.
    /// </summary>
    public TerraformProperty<double> ReplicaCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("replica_count");
        set => SetProperty("replica_count", value);
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
    /// The semantic_search_sku attribute.
    /// </summary>
    public TerraformProperty<string> SemanticSearchSku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("semantic_search_sku");
        set => SetProperty("semantic_search_sku", value);
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
    public List<AzurermSearchServiceIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSearchServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The customer_managed_key_encryption_compliance_status attribute.
    /// </summary>
    public TerraformExpression CustomerManagedKeyEncryptionComplianceStatus => this["customer_managed_key_encryption_compliance_status"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The query_keys attribute.
    /// </summary>
    public TerraformExpression QueryKeys => this["query_keys"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

}
