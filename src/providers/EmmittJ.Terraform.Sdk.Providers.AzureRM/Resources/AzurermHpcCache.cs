using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for default_access_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDefaultAccessPolicyBlock
{
}

/// <summary>
/// Block type for directory_active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDirectoryActiveDirectoryBlock
{
    /// <summary>
    /// The cache_netbios_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheNetbiosName is required")]
    [TerraformPropertyName("cache_netbios_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CacheNetbiosName { get; set; }

    /// <summary>
    /// The dns_primary_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsPrimaryIp is required")]
    [TerraformPropertyName("dns_primary_ip")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DnsPrimaryIp { get; set; }

    /// <summary>
    /// The dns_secondary_ip attribute.
    /// </summary>
    [TerraformPropertyName("dns_secondary_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsSecondaryIp { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The domain_netbios_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNetbiosName is required")]
    [TerraformPropertyName("domain_netbios_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainNetbiosName { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for directory_flat_file in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDirectoryFlatFileBlock
{
    /// <summary>
    /// The group_file_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupFileUri is required")]
    [TerraformPropertyName("group_file_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GroupFileUri { get; set; }

    /// <summary>
    /// The password_file_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordFileUri is required")]
    [TerraformPropertyName("password_file_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PasswordFileUri { get; set; }

}

/// <summary>
/// Block type for directory_ldap in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDirectoryLdapBlock
{
    /// <summary>
    /// The base_dn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseDn is required")]
    [TerraformPropertyName("base_dn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BaseDn { get; set; }

    /// <summary>
    /// The certificate_validation_uri attribute.
    /// </summary>
    [TerraformPropertyName("certificate_validation_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateValidationUri { get; set; }

    /// <summary>
    /// The download_certificate_automatically attribute.
    /// </summary>
    [TerraformPropertyName("download_certificate_automatically")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DownloadCertificateAutomatically { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Encrypted { get; set; }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformPropertyName("server")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Server { get; set; }

}

/// <summary>
/// Block type for dns in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDnsBlock
{
    /// <summary>
    /// The search_domain attribute.
    /// </summary>
    [TerraformPropertyName("search_domain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SearchDomain { get; set; }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Servers is required")]
    [TerraformPropertyName("servers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Servers { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHpcCacheTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("automatically_rotate_key_to_latest_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutomaticallyRotateKeyToLatestEnabled { get; set; }

    /// <summary>
    /// The cache_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheSizeInGb is required")]
    [TerraformPropertyName("cache_size_in_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> CacheSizeInGb { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    [TerraformPropertyName("mtu")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Mtu { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ntp_server attribute.
    /// </summary>
    [TerraformPropertyName("ntp_server")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NtpServer { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformPropertyName("sku_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for default_access_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAccessPolicy block(s) allowed")]
    [TerraformPropertyName("default_access_policy")]
    public TerraformList<TerraformBlock<AzurermHpcCacheDefaultAccessPolicyBlock>>? DefaultAccessPolicy { get; set; }

    /// <summary>
    /// Block for directory_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryActiveDirectory block(s) allowed")]
    [TerraformPropertyName("directory_active_directory")]
    public TerraformList<TerraformBlock<AzurermHpcCacheDirectoryActiveDirectoryBlock>>? DirectoryActiveDirectory { get; set; }

    /// <summary>
    /// Block for directory_flat_file.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryFlatFile block(s) allowed")]
    [TerraformPropertyName("directory_flat_file")]
    public TerraformList<TerraformBlock<AzurermHpcCacheDirectoryFlatFileBlock>>? DirectoryFlatFile { get; set; }

    /// <summary>
    /// Block for directory_ldap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryLdap block(s) allowed")]
    [TerraformPropertyName("directory_ldap")]
    public TerraformList<TerraformBlock<AzurermHpcCacheDirectoryLdapBlock>>? DirectoryLdap { get; set; }

    /// <summary>
    /// Block for dns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    [TerraformPropertyName("dns")]
    public TerraformList<TerraformBlock<AzurermHpcCacheDnsBlock>>? Dns { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermHpcCacheIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermHpcCacheTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The mount_addresses attribute.
    /// </summary>
    [TerraformPropertyName("mount_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> MountAddresses => new TerraformReference(this, "mount_addresses");

}
