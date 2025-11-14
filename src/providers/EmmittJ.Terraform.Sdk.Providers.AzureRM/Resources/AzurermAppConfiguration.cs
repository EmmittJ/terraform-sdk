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
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption";

    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    [TerraformArgument("identity_client_id")]
    public TerraformValue<string>? IdentityClientId
    {
        get => new TerraformReference<string>(this, "identity_client_id");
        set => SetArgument("identity_client_id", value);
    }

    /// <summary>
    /// The key_vault_key_identifier attribute.
    /// </summary>
    [TerraformArgument("key_vault_key_identifier")]
    public TerraformValue<string>? KeyVaultKeyIdentifier
    {
        get => new TerraformReference<string>(this, "key_vault_key_identifier");
        set => SetArgument("key_vault_key_identifier", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermAppConfigurationIdentityBlock : TerraformBlock
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
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public class AzurermAppConfigurationReplicaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replica";



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

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_app_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAppConfiguration : TerraformResource
{
    public AzurermAppConfiguration(string name) : base("azurerm_app_configuration", name)
    {
    }

    /// <summary>
    /// The data_plane_proxy_authentication_mode attribute.
    /// </summary>
    [TerraformArgument("data_plane_proxy_authentication_mode")]
    public TerraformValue<string>? DataPlaneProxyAuthenticationMode
    {
        get => new TerraformReference<string>(this, "data_plane_proxy_authentication_mode");
        set => SetArgument("data_plane_proxy_authentication_mode", value);
    }

    /// <summary>
    /// The data_plane_proxy_private_link_delegation_enabled attribute.
    /// </summary>
    [TerraformArgument("data_plane_proxy_private_link_delegation_enabled")]
    public TerraformValue<bool>? DataPlaneProxyPrivateLinkDelegationEnabled
    {
        get => new TerraformReference<bool>(this, "data_plane_proxy_private_link_delegation_enabled");
        set => SetArgument("data_plane_proxy_private_link_delegation_enabled", value);
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
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformArgument("local_auth_enabled")]
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => new TerraformReference<bool>(this, "local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
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
    /// The public_network_access attribute.
    /// </summary>
    [TerraformArgument("public_network_access")]
    public TerraformValue<string>? PublicNetworkAccess
    {
        get => new TerraformReference<string>(this, "public_network_access");
        set => SetArgument("public_network_access", value);
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformArgument("purge_protection_enabled")]
    public TerraformValue<bool>? PurgeProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "purge_protection_enabled");
        set => SetArgument("purge_protection_enabled", value);
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
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    [TerraformArgument("soft_delete_retention_days")]
    public TerraformValue<double>? SoftDeleteRetentionDays
    {
        get => new TerraformReference<double>(this, "soft_delete_retention_days");
        set => SetArgument("soft_delete_retention_days", value);
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
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformArgument("encryption")]
    public TerraformList<AzurermAppConfigurationEncryptionBlock> Encryption { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermAppConfigurationIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("replica")]
    public TerraformSet<AzurermAppConfigurationReplicaBlock> Replica { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppConfigurationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The primary_read_key attribute.
    /// </summary>
    [TerraformArgument("primary_read_key")]
    public TerraformList<object> PrimaryReadKey
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "primary_read_key").ResolveNodes(ctx));
    }

    /// <summary>
    /// The primary_write_key attribute.
    /// </summary>
    [TerraformArgument("primary_write_key")]
    public TerraformList<object> PrimaryWriteKey
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "primary_write_key").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secondary_read_key attribute.
    /// </summary>
    [TerraformArgument("secondary_read_key")]
    public TerraformList<object> SecondaryReadKey
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "secondary_read_key").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secondary_write_key attribute.
    /// </summary>
    [TerraformArgument("secondary_write_key")]
    public TerraformList<object> SecondaryWriteKey
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "secondary_write_key").ResolveNodes(ctx));
    }

}
