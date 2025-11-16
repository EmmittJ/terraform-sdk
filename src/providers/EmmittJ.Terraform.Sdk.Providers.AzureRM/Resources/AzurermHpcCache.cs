using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public required TerraformValue<string> CacheNetbiosName
    {
        get => new TerraformReference<string>(this, "cache_netbios_name");
        set => SetArgument("cache_netbios_name", value);
    }

    /// <summary>
    /// The dns_primary_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsPrimaryIp is required")]
    public required TerraformValue<string> DnsPrimaryIp
    {
        get => new TerraformReference<string>(this, "dns_primary_ip");
        set => SetArgument("dns_primary_ip", value);
    }

    /// <summary>
    /// The dns_secondary_ip attribute.
    /// </summary>
    public TerraformValue<string>? DnsSecondaryIp
    {
        get => new TerraformReference<string>(this, "dns_secondary_ip");
        set => SetArgument("dns_secondary_ip", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_netbios_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNetbiosName is required")]
    public required TerraformValue<string> DomainNetbiosName
    {
        get => new TerraformReference<string>(this, "domain_netbios_name");
        set => SetArgument("domain_netbios_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
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
    public required TerraformValue<string> GroupFileUri
    {
        get => new TerraformReference<string>(this, "group_file_uri");
        set => SetArgument("group_file_uri", value);
    }

    /// <summary>
    /// The password_file_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordFileUri is required")]
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
    public required TerraformValue<string> BaseDn
    {
        get => new TerraformReference<string>(this, "base_dn");
        set => SetArgument("base_dn", value);
    }

    /// <summary>
    /// The certificate_validation_uri attribute.
    /// </summary>
    public TerraformValue<string>? CertificateValidationUri
    {
        get => new TerraformReference<string>(this, "certificate_validation_uri");
        set => SetArgument("certificate_validation_uri", value);
    }

    /// <summary>
    /// The download_certificate_automatically attribute.
    /// </summary>
    public TerraformValue<bool>? DownloadCertificateAutomatically
    {
        get => new TerraformReference<bool>(this, "download_certificate_automatically");
        set => SetArgument("download_certificate_automatically", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
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
    public TerraformValue<string>? SearchDomain
    {
        get => new TerraformReference<string>(this, "search_domain");
        set => SetArgument("search_domain", value);
    }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Servers is required")]
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
public class AzurermHpcCacheTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_hpc_cache Terraform resource.
/// Manages a azurerm_hpc_cache resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermHpcCache(string name) : TerraformResource("azurerm_hpc_cache", name)
{
    /// <summary>
    /// The automatically_rotate_key_to_latest_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticallyRotateKeyToLatestEnabled
    {
        get => new TerraformReference<bool>(this, "automatically_rotate_key_to_latest_enabled");
        set => SetArgument("automatically_rotate_key_to_latest_enabled", value);
    }

    /// <summary>
    /// The cache_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheSizeInGb is required")]
    public required TerraformValue<double> CacheSizeInGb
    {
        get => new TerraformReference<double>(this, "cache_size_in_gb");
        set => SetArgument("cache_size_in_gb", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
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
    /// The mtu attribute.
    /// </summary>
    public TerraformValue<double>? Mtu
    {
        get => new TerraformReference<double>(this, "mtu");
        set => SetArgument("mtu", value);
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
    /// The ntp_server attribute.
    /// </summary>
    public TerraformValue<string>? NtpServer
    {
        get => new TerraformReference<string>(this, "ntp_server");
        set => SetArgument("ntp_server", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// DefaultAccessPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAccessPolicy block(s) allowed")]
    public AzurermHpcCacheDefaultAccessPolicyBlock? DefaultAccessPolicy
    {
        get => GetArgument<AzurermHpcCacheDefaultAccessPolicyBlock>("default_access_policy");
        set => SetArgument("default_access_policy", value);
    }

    /// <summary>
    /// DirectoryActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryActiveDirectory block(s) allowed")]
    public AzurermHpcCacheDirectoryActiveDirectoryBlock? DirectoryActiveDirectory
    {
        get => GetArgument<AzurermHpcCacheDirectoryActiveDirectoryBlock>("directory_active_directory");
        set => SetArgument("directory_active_directory", value);
    }

    /// <summary>
    /// DirectoryFlatFile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryFlatFile block(s) allowed")]
    public AzurermHpcCacheDirectoryFlatFileBlock? DirectoryFlatFile
    {
        get => GetArgument<AzurermHpcCacheDirectoryFlatFileBlock>("directory_flat_file");
        set => SetArgument("directory_flat_file", value);
    }

    /// <summary>
    /// DirectoryLdap block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryLdap block(s) allowed")]
    public AzurermHpcCacheDirectoryLdapBlock? DirectoryLdap
    {
        get => GetArgument<AzurermHpcCacheDirectoryLdapBlock>("directory_ldap");
        set => SetArgument("directory_ldap", value);
    }

    /// <summary>
    /// Dns block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    public AzurermHpcCacheDnsBlock? Dns
    {
        get => GetArgument<AzurermHpcCacheDnsBlock>("dns");
        set => SetArgument("dns", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public AzurermHpcCacheIdentityBlock? Identity
    {
        get => GetArgument<AzurermHpcCacheIdentityBlock>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHpcCacheTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHpcCacheTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
