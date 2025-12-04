using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermSearchService.
/// Nesting mode: list
/// </summary>
public class AzurermSearchServiceIdentityBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSearchService.
/// Nesting mode: single
/// </summary>
public class AzurermSearchServiceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_search_service Terraform resource.
/// Manages a azurerm_search_service resource.
/// </summary>
public partial class AzurermSearchService(string name) : TerraformResource("azurerm_search_service", name)
{
    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    public TerraformSet<string>? AllowedIps
    {
        get => GetArgument<TerraformSet<string>>("allowed_ips");
        set => SetArgument("allowed_ips", value);
    }

    /// <summary>
    /// The authentication_failure_mode attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationFailureMode
    {
        get => GetArgument<TerraformValue<string>>("authentication_failure_mode");
        set => SetArgument("authentication_failure_mode", value);
    }

    /// <summary>
    /// The customer_managed_key_enforcement_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomerManagedKeyEnforcementEnabled
    {
        get => GetArgument<TerraformValue<bool>>("customer_managed_key_enforcement_enabled");
        set => SetArgument("customer_managed_key_enforcement_enabled", value);
    }

    /// <summary>
    /// The hosting_mode attribute.
    /// </summary>
    public TerraformValue<string>? HostingMode
    {
        get => GetArgument<TerraformValue<string>>("hosting_mode");
        set => SetArgument("hosting_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthenticationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_authentication_enabled");
        set => SetArgument("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The network_rule_bypass_option attribute.
    /// </summary>
    public TerraformValue<string>? NetworkRuleBypassOption
    {
        get => GetArgument<TerraformValue<string>>("network_rule_bypass_option");
        set => SetArgument("network_rule_bypass_option", value);
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    public TerraformValue<double>? PartitionCount
    {
        get => GetArgument<TerraformValue<double>>("partition_count");
        set => SetArgument("partition_count", value);
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
    /// The replica_count attribute.
    /// </summary>
    public TerraformValue<double>? ReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("replica_count");
        set => SetArgument("replica_count", value);
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
    /// The semantic_search_sku attribute.
    /// </summary>
    public TerraformValue<string>? SemanticSearchSku
    {
        get => GetArgument<TerraformValue<string>>("semantic_search_sku");
        set => SetArgument("semantic_search_sku", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
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
    /// The customer_managed_key_encryption_compliance_status attribute.
    /// </summary>
    public TerraformValue<string> CustomerManagedKeyEncryptionComplianceStatus
        => AsReference("customer_managed_key_encryption_compliance_status");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// The query_keys attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> QueryKeys
        => AsReference("query_keys");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryKey
        => AsReference("secondary_key");

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermSearchServiceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermSearchServiceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSearchServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSearchServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
