using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for georeplications in .
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
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The regional_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RegionalEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "regional_endpoint_enabled");
        set => SetArgument("regional_endpoint_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundancyEnabled
    {
        get => new TerraformReference<bool>(this, "zone_redundancy_enabled");
        set => SetArgument("zone_redundancy_enabled", value);
    }

}

/// <summary>
/// Block type for identity in .
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "admin_enabled");
        set => SetArgument("admin_enabled", value);
    }

    /// <summary>
    /// The anonymous_pull_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AnonymousPullEnabled
    {
        get => new TerraformReference<bool>(this, "anonymous_pull_enabled");
        set => SetArgument("anonymous_pull_enabled", value);
    }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DataEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "data_endpoint_enabled");
        set => SetArgument("data_endpoint_enabled", value);
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Encryption
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption").ResolveNodes(ctx));
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// The export_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExportPolicyEnabled
    {
        get => new TerraformReference<bool>(this, "export_policy_enabled");
        set => SetArgument("export_policy_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_rule_bypass_option attribute.
    /// </summary>
    public TerraformValue<string>? NetworkRuleBypassOption
    {
        get => new TerraformReference<string>(this, "network_rule_bypass_option");
        set => SetArgument("network_rule_bypass_option", value);
    }

    /// <summary>
    /// The network_rule_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkRuleSet
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_rule_set").ResolveNodes(ctx));
        set => SetArgument("network_rule_set", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The quarantine_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? QuarantinePolicyEnabled
    {
        get => new TerraformReference<bool>(this, "quarantine_policy_enabled");
        set => SetArgument("quarantine_policy_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retention_policy_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPolicyInDays
    {
        get => new TerraformReference<double>(this, "retention_policy_in_days");
        set => SetArgument("retention_policy_in_days", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The trust_policy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TrustPolicyEnabled
    {
        get => new TerraformReference<bool>(this, "trust_policy_enabled");
        set => SetArgument("trust_policy_enabled", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundancyEnabled
    {
        get => new TerraformReference<bool>(this, "zone_redundancy_enabled");
        set => SetArgument("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformValue<string> AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
    }

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    public TerraformSet<string> DataEndpointHostNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "data_endpoint_host_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    public TerraformValue<string> LoginServer
    {
        get => new TerraformReference<string>(this, "login_server");
    }

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
