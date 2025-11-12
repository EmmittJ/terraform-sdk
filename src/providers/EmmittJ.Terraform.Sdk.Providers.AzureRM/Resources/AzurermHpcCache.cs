using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for default_access_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHpcCacheDefaultAccessPolicyBlock() : TerraformBlock("default_access_policy")
{
}

/// <summary>
/// Block type for directory_active_directory in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHpcCacheDirectoryActiveDirectoryBlock() : TerraformBlock("directory_active_directory")
{
    /// <summary>
    /// The cache_netbios_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheNetbiosName is required")]
    [TerraformProperty("cache_netbios_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CacheNetbiosName { get; set; }

    /// <summary>
    /// The dns_primary_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsPrimaryIp is required")]
    [TerraformProperty("dns_primary_ip")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DnsPrimaryIp { get; set; }

    /// <summary>
    /// The dns_secondary_ip attribute.
    /// </summary>
    [TerraformProperty("dns_secondary_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsSecondaryIp { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The domain_netbios_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNetbiosName is required")]
    [TerraformProperty("domain_netbios_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainNetbiosName { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for directory_flat_file in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHpcCacheDirectoryFlatFileBlock() : TerraformBlock("directory_flat_file")
{
    /// <summary>
    /// The group_file_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupFileUri is required")]
    [TerraformProperty("group_file_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GroupFileUri { get; set; }

    /// <summary>
    /// The password_file_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordFileUri is required")]
    [TerraformProperty("password_file_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PasswordFileUri { get; set; }

}

/// <summary>
/// Block type for directory_ldap in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHpcCacheDirectoryLdapBlock() : TerraformBlock("directory_ldap")
{
    /// <summary>
    /// The base_dn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseDn is required")]
    [TerraformProperty("base_dn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BaseDn { get; set; }

    /// <summary>
    /// The certificate_validation_uri attribute.
    /// </summary>
    [TerraformProperty("certificate_validation_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateValidationUri { get; set; }

    /// <summary>
    /// The download_certificate_automatically attribute.
    /// </summary>
    [TerraformProperty("download_certificate_automatically")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DownloadCertificateAutomatically { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Encrypted { get; set; }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformProperty("server")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Server { get; set; }

}

/// <summary>
/// Block type for dns in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHpcCacheDnsBlock() : TerraformBlock("dns")
{
    /// <summary>
    /// The search_domain attribute.
    /// </summary>
    [TerraformProperty("search_domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SearchDomain { get; set; }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Servers is required")]
    [TerraformProperty("servers")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Servers { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermHpcCacheIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHpcCacheTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_hpc_cache resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermHpcCache : TerraformResource
{
    public AzurermHpcCache(string name) : base("azurerm_hpc_cache", name)
    {
    }

    /// <summary>
    /// The automatically_rotate_key_to_latest_enabled attribute.
    /// </summary>
    [TerraformProperty("automatically_rotate_key_to_latest_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutomaticallyRotateKeyToLatestEnabled { get; set; }

    /// <summary>
    /// The cache_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheSizeInGb is required")]
    [TerraformProperty("cache_size_in_gb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> CacheSizeInGb { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    [TerraformProperty("mtu")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Mtu { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ntp_server attribute.
    /// </summary>
    [TerraformProperty("ntp_server")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NtpServer { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for default_access_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAccessPolicy block(s) allowed")]
    [TerraformProperty("default_access_policy")]
    public TerraformList<AzurermHpcCacheDefaultAccessPolicyBlock> DefaultAccessPolicy { get; set; } = new();

    /// <summary>
    /// Block for directory_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryActiveDirectory block(s) allowed")]
    [TerraformProperty("directory_active_directory")]
    public TerraformList<AzurermHpcCacheDirectoryActiveDirectoryBlock> DirectoryActiveDirectory { get; set; } = new();

    /// <summary>
    /// Block for directory_flat_file.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryFlatFile block(s) allowed")]
    [TerraformProperty("directory_flat_file")]
    public TerraformList<AzurermHpcCacheDirectoryFlatFileBlock> DirectoryFlatFile { get; set; } = new();

    /// <summary>
    /// Block for directory_ldap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryLdap block(s) allowed")]
    [TerraformProperty("directory_ldap")]
    public TerraformList<AzurermHpcCacheDirectoryLdapBlock> DirectoryLdap { get; set; } = new();

    /// <summary>
    /// Block for dns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    [TerraformProperty("dns")]
    public TerraformList<AzurermHpcCacheDnsBlock> Dns { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermHpcCacheIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermHpcCacheTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The mount_addresses attribute.
    /// </summary>
    [TerraformProperty("mount_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> MountAddresses { get; }

}
