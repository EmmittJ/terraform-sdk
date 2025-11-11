using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory_administrator in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock
{
    /// <summary>
    /// The azuread_authentication_only_enabled attribute.
    /// </summary>
    [TerraformPropertyName("azuread_authentication_only_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AzureadAuthenticationOnlyEnabled { get; set; }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    [TerraformPropertyName("login_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LoginUsername { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [TerraformPropertyName("object_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    [TerraformPropertyName("principal_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrincipalType { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TenantId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceIdentityBlock
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
public class AzurermMssqlManagedInstanceTimeoutsBlock
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
/// Manages a azurerm_mssql_managed_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlManagedInstance : TerraformResource
{
    public AzurermMssqlManagedInstance(string name) : base("azurerm_mssql_managed_instance", name)
    {
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AdministratorLogin { get; set; } = default!;

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [TerraformPropertyName("administrator_login_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformPropertyName("collation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Collation { get; set; }

    /// <summary>
    /// The database_format attribute.
    /// </summary>
    [TerraformPropertyName("database_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DatabaseFormat { get; set; }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    [TerraformPropertyName("dns_zone_partner_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsZonePartnerId { get; set; }

    /// <summary>
    /// The hybrid_secondary_usage attribute.
    /// </summary>
    [TerraformPropertyName("hybrid_secondary_usage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HybridSecondaryUsage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    [TerraformPropertyName("license_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_configuration_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaintenanceConfigurationName { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    [TerraformPropertyName("proxy_override")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProxyOverride { get; set; }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_data_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicDataEndpointEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_principal_type attribute.
    /// </summary>
    [TerraformPropertyName("service_principal_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServicePrincipalType { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformPropertyName("sku_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountType { get; set; }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSizeInGb is required")]
    [TerraformPropertyName("storage_size_in_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> StorageSizeInGb { get; set; }

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
    /// The timezone_id attribute.
    /// </summary>
    [TerraformPropertyName("timezone_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TimezoneId { get; set; }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vcores is required")]
    [TerraformPropertyName("vcores")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Vcores { get; set; }

    /// <summary>
    /// The zone_redundant_enabled attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ZoneRedundantEnabled { get; set; }

    /// <summary>
    /// Block for azure_active_directory_administrator.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryAdministrator block(s) allowed")]
    [TerraformPropertyName("azure_active_directory_administrator")]
    public TerraformList<TerraformBlock<AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock>>? AzureActiveDirectoryAdministrator { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermMssqlManagedInstanceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlManagedInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    [TerraformPropertyName("dns_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsZone => new TerraformReference(this, "dns_zone");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

}
