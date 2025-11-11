using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory_administrator in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock : TerraformBlockBase
{
    /// <summary>
    /// The azuread_authentication_only_enabled attribute.
    /// </summary>
    [TerraformProperty("azuread_authentication_only_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AzureadAuthenticationOnlyEnabled { get; set; }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    [TerraformProperty("login_username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LoginUsername { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [TerraformProperty("object_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    [TerraformProperty("principal_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrincipalType { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TenantId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlManagedInstanceIdentityBlock : TerraformBlockBase
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
public partial class AzurermMssqlManagedInstanceTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_mssql_managed_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlManagedInstance : TerraformResource
{
    public AzurermMssqlManagedInstance(string name) : base("azurerm_mssql_managed_instance", name)
    {
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformProperty("administrator_login")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AdministratorLogin { get; set; }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [TerraformProperty("administrator_login_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformProperty("collation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Collation { get; set; }

    /// <summary>
    /// The database_format attribute.
    /// </summary>
    [TerraformProperty("database_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatabaseFormat { get; set; }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    [TerraformProperty("dns_zone_partner_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsZonePartnerId { get; set; }

    /// <summary>
    /// The hybrid_secondary_usage attribute.
    /// </summary>
    [TerraformProperty("hybrid_secondary_usage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HybridSecondaryUsage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    [TerraformProperty("license_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    [TerraformProperty("maintenance_configuration_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaintenanceConfigurationName { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformProperty("minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    [TerraformProperty("proxy_override")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProxyOverride { get; set; }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    [TerraformProperty("public_data_endpoint_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicDataEndpointEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_principal_type attribute.
    /// </summary>
    [TerraformProperty("service_principal_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServicePrincipalType { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformProperty("storage_account_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountType { get; set; }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSizeInGb is required")]
    [TerraformProperty("storage_size_in_gb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> StorageSizeInGb { get; set; }

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
    /// The timezone_id attribute.
    /// </summary>
    [TerraformProperty("timezone_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimezoneId { get; set; }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vcores is required")]
    [TerraformProperty("vcores")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Vcores { get; set; }

    /// <summary>
    /// The zone_redundant_enabled attribute.
    /// </summary>
    [TerraformProperty("zone_redundant_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZoneRedundantEnabled { get; set; }

    /// <summary>
    /// Block for azure_active_directory_administrator.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryAdministrator block(s) allowed")]
    [TerraformProperty("azure_active_directory_administrator")]
    public partial TerraformList<TerraformBlock<AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock>>? AzureActiveDirectoryAdministrator { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermMssqlManagedInstanceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMssqlManagedInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    [TerraformProperty("dns_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsZone { get; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

}
