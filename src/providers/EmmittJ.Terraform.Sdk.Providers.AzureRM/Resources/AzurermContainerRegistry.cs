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
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The regional_endpoint_enabled attribute.
    /// </summary>
    [TerraformArgument("regional_endpoint_enabled")]
    public TerraformValue<bool>? RegionalEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "regional_endpoint_enabled");
        set => SetArgument("regional_endpoint_enabled", value);
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
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformArgument("zone_redundancy_enabled")]
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
/// Manages a azurerm_container_registry resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerRegistry : TerraformResource
{
    public AzurermContainerRegistry(string name) : base("azurerm_container_registry", name)
    {
    }

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformArgument("admin_enabled")]
    public TerraformValue<bool>? AdminEnabled
    {
        get => new TerraformReference<bool>(this, "admin_enabled");
        set => SetArgument("admin_enabled", value);
    }

    /// <summary>
    /// The anonymous_pull_enabled attribute.
    /// </summary>
    [TerraformArgument("anonymous_pull_enabled")]
    public TerraformValue<bool>? AnonymousPullEnabled
    {
        get => new TerraformReference<bool>(this, "anonymous_pull_enabled");
        set => SetArgument("anonymous_pull_enabled", value);
    }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    [TerraformArgument("data_endpoint_enabled")]
    public TerraformValue<bool>? DataEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "data_endpoint_enabled");
        set => SetArgument("data_endpoint_enabled", value);
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformArgument("encryption")]
    public TerraformList<object> Encryption
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "encryption").ResolveNodes(ctx));
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// The export_policy_enabled attribute.
    /// </summary>
    [TerraformArgument("export_policy_enabled")]
    public TerraformValue<bool>? ExportPolicyEnabled
    {
        get => new TerraformReference<bool>(this, "export_policy_enabled");
        set => SetArgument("export_policy_enabled", value);
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
    /// The network_rule_bypass_option attribute.
    /// </summary>
    [TerraformArgument("network_rule_bypass_option")]
    public TerraformValue<string>? NetworkRuleBypassOption
    {
        get => new TerraformReference<string>(this, "network_rule_bypass_option");
        set => SetArgument("network_rule_bypass_option", value);
    }

    /// <summary>
    /// The network_rule_set attribute.
    /// </summary>
    [TerraformArgument("network_rule_set")]
    public TerraformList<object> NetworkRuleSet
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "network_rule_set").ResolveNodes(ctx));
        set => SetArgument("network_rule_set", value);
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
    /// The quarantine_policy_enabled attribute.
    /// </summary>
    [TerraformArgument("quarantine_policy_enabled")]
    public TerraformValue<bool>? QuarantinePolicyEnabled
    {
        get => new TerraformReference<bool>(this, "quarantine_policy_enabled");
        set => SetArgument("quarantine_policy_enabled", value);
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
    /// The retention_policy_in_days attribute.
    /// </summary>
    [TerraformArgument("retention_policy_in_days")]
    public TerraformValue<double>? RetentionPolicyInDays
    {
        get => new TerraformReference<double>(this, "retention_policy_in_days");
        set => SetArgument("retention_policy_in_days", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
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
    /// The trust_policy_enabled attribute.
    /// </summary>
    [TerraformArgument("trust_policy_enabled")]
    public TerraformValue<bool>? TrustPolicyEnabled
    {
        get => new TerraformReference<bool>(this, "trust_policy_enabled");
        set => SetArgument("trust_policy_enabled", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformArgument("zone_redundancy_enabled")]
    public TerraformValue<bool>? ZoneRedundancyEnabled
    {
        get => new TerraformReference<bool>(this, "zone_redundancy_enabled");
        set => SetArgument("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// Block for georeplications.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("georeplications")]
    public TerraformList<AzurermContainerRegistryGeoreplicationsBlock> Georeplications { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermContainerRegistryIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerRegistryTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformArgument("admin_password")]
    public TerraformValue<string> AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformArgument("admin_username")]
    public TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
    }

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    [TerraformArgument("data_endpoint_host_names")]
    public TerraformSet<string> DataEndpointHostNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "data_endpoint_host_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [TerraformArgument("login_server")]
    public TerraformValue<string> LoginServer
    {
        get => new TerraformReference<string>(this, "login_server");
    }

}
