using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for default_access_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDefaultAccessPolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for directory_active_directory in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDirectoryActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// The cache_netbios_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheNetbiosName is required")]
    public required TerraformProperty<string> CacheNetbiosName
    {
        set => SetProperty("cache_netbios_name", value);
    }

    /// <summary>
    /// The dns_primary_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsPrimaryIp is required")]
    public required TerraformProperty<string> DnsPrimaryIp
    {
        set => SetProperty("dns_primary_ip", value);
    }

    /// <summary>
    /// The dns_secondary_ip attribute.
    /// </summary>
    public TerraformProperty<string>? DnsSecondaryIp
    {
        set => SetProperty("dns_secondary_ip", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The domain_netbios_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNetbiosName is required")]
    public required TerraformProperty<string> DomainNetbiosName
    {
        set => SetProperty("domain_netbios_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for directory_flat_file in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDirectoryFlatFileBlock : TerraformBlock
{
    /// <summary>
    /// The group_file_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupFileUri is required")]
    public required TerraformProperty<string> GroupFileUri
    {
        set => SetProperty("group_file_uri", value);
    }

    /// <summary>
    /// The password_file_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordFileUri is required")]
    public required TerraformProperty<string> PasswordFileUri
    {
        set => SetProperty("password_file_uri", value);
    }

}

/// <summary>
/// Block type for directory_ldap in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDirectoryLdapBlock : TerraformBlock
{
    /// <summary>
    /// The base_dn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseDn is required")]
    public required TerraformProperty<string> BaseDn
    {
        set => SetProperty("base_dn", value);
    }

    /// <summary>
    /// The certificate_validation_uri attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateValidationUri
    {
        set => SetProperty("certificate_validation_uri", value);
    }

    /// <summary>
    /// The download_certificate_automatically attribute.
    /// </summary>
    public TerraformProperty<bool>? DownloadCertificateAutomatically
    {
        set => SetProperty("download_certificate_automatically", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        set => SetProperty("encrypted", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        set => SetProperty("server", value);
    }

}

/// <summary>
/// Block type for dns in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheDnsBlock : TerraformBlock
{
    /// <summary>
    /// The search_domain attribute.
    /// </summary>
    public TerraformProperty<string>? SearchDomain
    {
        set => SetProperty("search_domain", value);
    }

    /// <summary>
    /// The servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Servers is required")]
    public List<TerraformProperty<string>>? Servers
    {
        set => SetProperty("servers", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermHpcCacheIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHpcCacheTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("mount_addresses");
        SetOutput("automatically_rotate_key_to_latest_enabled");
        SetOutput("cache_size_in_gb");
        SetOutput("id");
        SetOutput("key_vault_key_id");
        SetOutput("location");
        SetOutput("mtu");
        SetOutput("name");
        SetOutput("ntp_server");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("subnet_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The automatically_rotate_key_to_latest_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutomaticallyRotateKeyToLatestEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatically_rotate_key_to_latest_enabled");
        set => SetProperty("automatically_rotate_key_to_latest_enabled", value);
    }

    /// <summary>
    /// The cache_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheSizeInGb is required")]
    public required TerraformProperty<double> CacheSizeInGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cache_size_in_gb");
        set => SetProperty("cache_size_in_gb", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_key_id");
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    public TerraformProperty<double> Mtu
    {
        get => GetRequiredOutput<TerraformProperty<double>>("mtu");
        set => SetProperty("mtu", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ntp_server attribute.
    /// </summary>
    public TerraformProperty<string> NtpServer
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ntp_server");
        set => SetProperty("ntp_server", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for default_access_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAccessPolicy block(s) allowed")]
    public List<AzurermHpcCacheDefaultAccessPolicyBlock>? DefaultAccessPolicy
    {
        set => SetProperty("default_access_policy", value);
    }

    /// <summary>
    /// Block for directory_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryActiveDirectory block(s) allowed")]
    public List<AzurermHpcCacheDirectoryActiveDirectoryBlock>? DirectoryActiveDirectory
    {
        set => SetProperty("directory_active_directory", value);
    }

    /// <summary>
    /// Block for directory_flat_file.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryFlatFile block(s) allowed")]
    public List<AzurermHpcCacheDirectoryFlatFileBlock>? DirectoryFlatFile
    {
        set => SetProperty("directory_flat_file", value);
    }

    /// <summary>
    /// Block for directory_ldap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DirectoryLdap block(s) allowed")]
    public List<AzurermHpcCacheDirectoryLdapBlock>? DirectoryLdap
    {
        set => SetProperty("directory_ldap", value);
    }

    /// <summary>
    /// Block for dns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    public List<AzurermHpcCacheDnsBlock>? Dns
    {
        set => SetProperty("dns", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermHpcCacheIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHpcCacheTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The mount_addresses attribute.
    /// </summary>
    public TerraformExpression MountAddresses => this["mount_addresses"];

}
