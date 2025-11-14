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
/// Block type for default_access_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDefaultAccessPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_access_policy";

}

/// <summary>
/// Block type for directory_active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDirectoryActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "directory_active_directory";

    /// <summary>
    /// The cache_netbios_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheNetbiosName is required")]
    [TerraformArgument("cache_netbios_name")]
    public required TerraformValue<string> CacheNetbiosName
    {
        get => new TerraformReference<string>(this, "cache_netbios_name");
        set => SetArgument("cache_netbios_name", value);
    }

    /// <summary>
    /// The dns_primary_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsPrimaryIp is required")]
    [TerraformArgument("dns_primary_ip")]
    public required TerraformValue<string> DnsPrimaryIp
    {
        get => new TerraformReference<string>(this, "dns_primary_ip");
        set => SetArgument("dns_primary_ip", value);
    }

    /// <summary>
    /// The dns_secondary_ip attribute.
    /// </summary>
    [TerraformArgument("dns_secondary_ip")]
    public TerraformValue<string>? DnsSecondaryIp
    {
        get => new TerraformReference<string>(this, "dns_secondary_ip");
        set => SetArgument("dns_secondary_ip", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformArgument("domain_name")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_netbios_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNetbiosName is required")]
    [TerraformArgument("domain_netbios_name")]
    public required TerraformValue<string> DomainNetbiosName
    {
        get => new TerraformReference<string>(this, "domain_netbios_name");
        set => SetArgument("domain_netbios_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformArgument("password")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformArgument("username")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for directory_flat_file in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDirectoryFlatFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "directory_flat_file";

    /// <summary>
    /// The group_file_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupFileUri is required")]
    [TerraformArgument("group_file_uri")]
    public required TerraformValue<string> GroupFileUri
    {
        get => new TerraformReference<string>(this, "group_file_uri");
        set => SetArgument("group_file_uri", value);
    }

    /// <summary>
    /// The password_file_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordFileUri is required")]
    [TerraformArgument("password_file_uri")]
    public required TerraformValue<string> PasswordFileUri
    {
        get => new TerraformReference<string>(this, "password_file_uri");
        set => SetArgument("password_file_uri", value);
    }

}

/// <summary>
/// Block type for directory_ldap in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDirectoryLdapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "directory_ldap";

    /// <summary>
    /// The base_dn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseDn is required")]
    [TerraformArgument("base_dn")]
    public required TerraformValue<string> BaseDn
    {
        get => new TerraformReference<string>(this, "base_dn");
        set => SetArgument("base_dn", value);
    }

    /// <summary>
    /// The certificate_validation_uri attribute.
    /// </summary>
    [TerraformArgument("certificate_validation_uri")]
    public TerraformValue<string>? CertificateValidationUri
    {
        get => new TerraformReference<string>(this, "certificate_validation_uri");
        set => SetArgument("certificate_validation_uri", value);
    }

    /// <summary>
    /// The download_certificate_automatically attribute.
    /// </summary>
    [TerraformArgument("download_certificate_automatically")]
    public TerraformValue<bool>? DownloadCertificateAutomatically
    {
        get => new TerraformReference<bool>(this, "download_certificate_automatically");
        set => SetArgument("download_certificate_automatically", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformArgument("encrypted")]
    public TerraformValue<bool>? Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformArgument("server")]
    public required TerraformValue<string> Server
    {
        get => new TerraformReference<string>(this, "server");
        set => SetArgument("server", value);
    }

}

/// <summary>
/// Block type for dns in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns";

    /// <summary>
    /// The search_domain attribute.
    /// </summary>
    [TerraformArgument("search_domain")]
    public TerraformValue<string>? SearchDomain
    {
        get => new TerraformReference<string>(this, "search_domain");
        set => SetArgument("search_domain", value);
    }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Servers is required")]
    [TerraformArgument("servers")]
    public TerraformList<string>? Servers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "servers").ResolveNodes(ctx));
        set => SetArgument("servers", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheIdentityBlock : TerraformBlock
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
public class AzurermHpcCacheTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_hpc_cache resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermHpcCache : TerraformResource
{
    public AzurermHpcCache(string name) : base("azurerm_hpc_cache", name)
    {
    }

    /// <summary>
    /// The automatically_rotate_key_to_latest_enabled attribute.
    /// </summary>
    [TerraformArgument("automatically_rotate_key_to_latest_enabled")]
    public TerraformValue<bool>? AutomaticallyRotateKeyToLatestEnabled
    {
        get => new TerraformReference<bool>(this, "automatically_rotate_key_to_latest_enabled");
        set => SetArgument("automatically_rotate_key_to_latest_enabled", value);
    }

    /// <summary>
    /// The cache_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheSizeInGb is required")]
    [TerraformArgument("cache_size_in_gb")]
    public required TerraformValue<double> CacheSizeInGb
    {
        get => new TerraformReference<double>(this, "cache_size_in_gb");
        set => SetArgument("cache_size_in_gb", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_key_id")]
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
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
    /// The mtu attribute.
    /// </summary>
    [TerraformArgument("mtu")]
    public TerraformValue<double>? Mtu
    {
        get => new TerraformReference<double>(this, "mtu");
        set => SetArgument("mtu", value);
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
    /// The ntp_server attribute.
    /// </summary>
    [TerraformArgument("ntp_server")]
    public TerraformValue<string>? NtpServer
    {
        get => new TerraformReference<string>(this, "ntp_server");
        set => SetArgument("ntp_server", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformArgument("sku_name")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// Block for default_access_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAccessPolicy block(s) allowed")]
    [TerraformArgument("default_access_policy")]
    public TerraformList<AzurermHpcCacheDefaultAccessPolicyBlock> DefaultAccessPolicy { get; set; } = new();

    /// <summary>
    /// Block for directory_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryActiveDirectory block(s) allowed")]
    [TerraformArgument("directory_active_directory")]
    public TerraformList<AzurermHpcCacheDirectoryActiveDirectoryBlock> DirectoryActiveDirectory { get; set; } = new();

    /// <summary>
    /// Block for directory_flat_file.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryFlatFile block(s) allowed")]
    [TerraformArgument("directory_flat_file")]
    public TerraformList<AzurermHpcCacheDirectoryFlatFileBlock> DirectoryFlatFile { get; set; } = new();

    /// <summary>
    /// Block for directory_ldap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryLdap block(s) allowed")]
    [TerraformArgument("directory_ldap")]
    public TerraformList<AzurermHpcCacheDirectoryLdapBlock> DirectoryLdap { get; set; } = new();

    /// <summary>
    /// Block for dns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    [TerraformArgument("dns")]
    public TerraformList<AzurermHpcCacheDnsBlock> Dns { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermHpcCacheIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermHpcCacheTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The mount_addresses attribute.
    /// </summary>
    [TerraformArgument("mount_addresses")]
    public TerraformList<string> MountAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "mount_addresses").ResolveNodes(ctx));
    }

}
