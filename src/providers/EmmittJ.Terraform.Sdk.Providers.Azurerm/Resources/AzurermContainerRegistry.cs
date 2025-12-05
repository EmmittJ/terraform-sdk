using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for georeplications in AzurermContainerRegistry.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryGeoreplicationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "georeplications";

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
    /// The regional_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RegionalEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("regional_endpoint_enabled");
        set => SetArgument("regional_endpoint_enabled", value);
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
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundancyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("zone_redundancy_enabled");
        set => SetArgument("zone_redundancy_enabled", value);
    }

}


/// <summary>
/// Block type for identity in AzurermContainerRegistry.
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryIdentityBlock : TerraformBlock
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
        => CreateReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => CreateReference("tenant_id");

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
/// Block type for timeouts in AzurermContainerRegistry.
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_container_registry Terraform resource.
/// Manages a azurerm_container_registry resource.
/// </summary>
public partial class AzurermContainerRegistry(string name) : TerraformResource("azurerm_container_registry", name)
{
    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AdminEnabled
    {
        get => GetArgument<TerraformValue<bool>>("admin_enabled");
        set => SetArgument("admin_enabled", value);
    }

    /// <summary>
    /// The anonymous_pull_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AnonymousPullEnabled
    {
        get => GetArgument<TerraformValue<bool>>("anonymous_pull_enabled");
        set => SetArgument("anonymous_pull_enabled", value);
    }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DataEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("data_endpoint_enabled");
        set => SetArgument("data_endpoint_enabled", value);
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Encryption
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("encryption") ?? CreateReference("encryption");
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// The export_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExportPolicyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("export_policy_enabled");
        set => SetArgument("export_policy_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The network_rule_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkRuleSet
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("network_rule_set") ?? CreateReference("network_rule_set");
        set => SetArgument("network_rule_set", value);
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
    /// The quarantine_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? QuarantinePolicyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("quarantine_policy_enabled");
        set => SetArgument("quarantine_policy_enabled", value);
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
    /// The retention_policy_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPolicyInDays
    {
        get => GetArgument<TerraformValue<double>>("retention_policy_in_days");
        set => SetArgument("retention_policy_in_days", value);
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
    /// The trust_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TrustPolicyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("trust_policy_enabled");
        set => SetArgument("trust_policy_enabled", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundancyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("zone_redundancy_enabled");
        set => SetArgument("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformValue<string> AdminPassword
        => CreateReference("admin_password");

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string> AdminUsername
        => CreateReference("admin_username");

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    public TerraformSet<string> DataEndpointHostNames
        => CreateReference("data_endpoint_host_names");

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    public TerraformValue<string> LoginServer
        => CreateReference("login_server");

    /// <summary>
    /// Georeplications block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerRegistryGeoreplicationsBlock>? Georeplications
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryGeoreplicationsBlock>>("georeplications");
        set => SetArgument("georeplications", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermContainerRegistryIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerRegistryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerRegistryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
