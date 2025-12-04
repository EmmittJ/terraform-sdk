using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for default_access_policy in AzurermHpcCache.
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDefaultAccessPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_access_policy";

    /// <summary>
    /// AccessRule block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 AccessRule block(s) allowed")]
    public required TerraformSet<AzurermHpcCacheDefaultAccessPolicyBlockAccessRuleBlock> AccessRule
    {
        get => GetRequiredArgument<TerraformSet<AzurermHpcCacheDefaultAccessPolicyBlockAccessRuleBlock>>("access_rule");
        set => SetArgument("access_rule", value);
    }

}

/// <summary>
/// Block type for access_rule in AzurermHpcCacheDefaultAccessPolicyBlock.
/// Nesting mode: set
/// </summary>
public class AzurermHpcCacheDefaultAccessPolicyBlockAccessRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_rule";

    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    public required TerraformValue<string> Access
    {
        get => GetArgument<TerraformValue<string>>("access");
        set => SetArgument("access", value);
    }

    /// <summary>
    /// The anonymous_gid attribute.
    /// </summary>
    public TerraformValue<double>? AnonymousGid
    {
        get => GetArgument<TerraformValue<double>>("anonymous_gid");
        set => SetArgument("anonymous_gid", value);
    }

    /// <summary>
    /// The anonymous_uid attribute.
    /// </summary>
    public TerraformValue<double>? AnonymousUid
    {
        get => GetArgument<TerraformValue<double>>("anonymous_uid");
        set => SetArgument("anonymous_uid", value);
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The root_squash_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RootSquashEnabled
    {
        get => GetArgument<TerraformValue<bool>>("root_squash_enabled");
        set => SetArgument("root_squash_enabled", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The submount_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SubmountAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("submount_access_enabled");
        set => SetArgument("submount_access_enabled", value);
    }

    /// <summary>
    /// The suid_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SuidEnabled
    {
        get => GetArgument<TerraformValue<bool>>("suid_enabled");
        set => SetArgument("suid_enabled", value);
    }

}


/// <summary>
/// Block type for directory_active_directory in AzurermHpcCache.
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
        get => GetArgument<TerraformValue<string>>("cache_netbios_name");
        set => SetArgument("cache_netbios_name", value);
    }

    /// <summary>
    /// The dns_primary_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsPrimaryIp is required")]
    public required TerraformValue<string> DnsPrimaryIp
    {
        get => GetArgument<TerraformValue<string>>("dns_primary_ip");
        set => SetArgument("dns_primary_ip", value);
    }

    /// <summary>
    /// The dns_secondary_ip attribute.
    /// </summary>
    public TerraformValue<string>? DnsSecondaryIp
    {
        get => GetArgument<TerraformValue<string>>("dns_secondary_ip");
        set => SetArgument("dns_secondary_ip", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_netbios_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNetbiosName is required")]
    public required TerraformValue<string> DomainNetbiosName
    {
        get => GetArgument<TerraformValue<string>>("domain_netbios_name");
        set => SetArgument("domain_netbios_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for directory_flat_file in AzurermHpcCache.
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
        get => GetArgument<TerraformValue<string>>("group_file_uri");
        set => SetArgument("group_file_uri", value);
    }

    /// <summary>
    /// The password_file_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordFileUri is required")]
    public required TerraformValue<string> PasswordFileUri
    {
        get => GetArgument<TerraformValue<string>>("password_file_uri");
        set => SetArgument("password_file_uri", value);
    }

}


/// <summary>
/// Block type for directory_ldap in AzurermHpcCache.
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
        get => GetArgument<TerraformValue<string>>("base_dn");
        set => SetArgument("base_dn", value);
    }

    /// <summary>
    /// The certificate_validation_uri attribute.
    /// </summary>
    public TerraformValue<string>? CertificateValidationUri
    {
        get => GetArgument<TerraformValue<string>>("certificate_validation_uri");
        set => SetArgument("certificate_validation_uri", value);
    }

    /// <summary>
    /// The download_certificate_automatically attribute.
    /// </summary>
    public TerraformValue<bool>? DownloadCertificateAutomatically
    {
        get => GetArgument<TerraformValue<bool>>("download_certificate_automatically");
        set => SetArgument("download_certificate_automatically", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? Encrypted
    {
        get => GetArgument<TerraformValue<bool>>("encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => GetArgument<TerraformValue<string>>("server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// Bind block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bind block(s) allowed")]
    public TerraformList<AzurermHpcCacheDirectoryLdapBlockBindBlock>? Bind
    {
        get => GetArgument<TerraformList<AzurermHpcCacheDirectoryLdapBlockBindBlock>>("bind");
        set => SetArgument("bind", value);
    }

}

/// <summary>
/// Block type for bind in AzurermHpcCacheDirectoryLdapBlock.
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDirectoryLdapBlockBindBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bind";

    /// <summary>
    /// The dn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dn is required")]
    public required TerraformValue<string> Dn
    {
        get => GetArgument<TerraformValue<string>>("dn");
        set => SetArgument("dn", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

}


/// <summary>
/// Block type for dns in AzurermHpcCache.
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
        get => GetArgument<TerraformValue<string>>("search_domain");
        set => SetArgument("search_domain", value);
    }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Servers is required")]
    public TerraformList<string>? Servers
    {
        get => GetArgument<TerraformList<string>>("servers");
        set => SetArgument("servers", value);
    }

}


/// <summary>
/// Block type for identity in AzurermHpcCache.
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermHpcCache.
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
        get => GetArgument<TerraformValue<bool>>("automatically_rotate_key_to_latest_enabled");
        set => SetArgument("automatically_rotate_key_to_latest_enabled", value);
    }

    /// <summary>
    /// The cache_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheSizeInGb is required")]
    public required TerraformValue<double> CacheSizeInGb
    {
        get => GetArgument<TerraformValue<double>>("cache_size_in_gb");
        set => SetArgument("cache_size_in_gb", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    public TerraformValue<double>? Mtu
    {
        get => GetArgument<TerraformValue<double>>("mtu");
        set => SetArgument("mtu", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ntp_server attribute.
    /// </summary>
    public TerraformValue<string>? NtpServer
    {
        get => GetArgument<TerraformValue<string>>("ntp_server");
        set => SetArgument("ntp_server", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => GetArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The mount_addresses attribute.
    /// </summary>
    public TerraformList<string> MountAddresses
        => AsReference("mount_addresses");

    /// <summary>
    /// DefaultAccessPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAccessPolicy block(s) allowed")]
    public TerraformList<AzurermHpcCacheDefaultAccessPolicyBlock>? DefaultAccessPolicy
    {
        get => GetArgument<TerraformList<AzurermHpcCacheDefaultAccessPolicyBlock>>("default_access_policy");
        set => SetArgument("default_access_policy", value);
    }

    /// <summary>
    /// DirectoryActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryActiveDirectory block(s) allowed")]
    public TerraformList<AzurermHpcCacheDirectoryActiveDirectoryBlock>? DirectoryActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermHpcCacheDirectoryActiveDirectoryBlock>>("directory_active_directory");
        set => SetArgument("directory_active_directory", value);
    }

    /// <summary>
    /// DirectoryFlatFile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryFlatFile block(s) allowed")]
    public TerraformList<AzurermHpcCacheDirectoryFlatFileBlock>? DirectoryFlatFile
    {
        get => GetArgument<TerraformList<AzurermHpcCacheDirectoryFlatFileBlock>>("directory_flat_file");
        set => SetArgument("directory_flat_file", value);
    }

    /// <summary>
    /// DirectoryLdap block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryLdap block(s) allowed")]
    public TerraformList<AzurermHpcCacheDirectoryLdapBlock>? DirectoryLdap
    {
        get => GetArgument<TerraformList<AzurermHpcCacheDirectoryLdapBlock>>("directory_ldap");
        set => SetArgument("directory_ldap", value);
    }

    /// <summary>
    /// Dns block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    public TerraformList<AzurermHpcCacheDnsBlock>? Dns
    {
        get => GetArgument<TerraformList<AzurermHpcCacheDnsBlock>>("dns");
        set => SetArgument("dns", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermHpcCacheIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermHpcCacheIdentityBlock>>("identity");
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
