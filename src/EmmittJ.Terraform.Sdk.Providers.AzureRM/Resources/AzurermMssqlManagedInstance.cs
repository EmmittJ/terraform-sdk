using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_active_directory_administrator in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock : TerraformBlock
{
    /// <summary>
    /// The azuread_authentication_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AzureadAuthenticationOnlyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("azuread_authentication_only_enabled");
        set => WithProperty("azuread_authentication_only_enabled", value);
    }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    public required TerraformProperty<string> LoginUsername
    {
        get => GetProperty<TerraformProperty<string>>("login_username");
        set => WithProperty("login_username", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformProperty<string> ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => WithProperty("object_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    public required TerraformProperty<string> PrincipalType
    {
        get => GetProperty<TerraformProperty<string>>("principal_type");
        set => WithProperty("principal_type", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_managed_instance resource.
/// </summary>
public class AzurermMssqlManagedInstance : TerraformResource
{
    public AzurermMssqlManagedInstance(string name) : base("azurerm_mssql_managed_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dns_zone");
        this.DeclareOutput("fqdn");
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLogin
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login");
        set => this.WithProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLoginPassword
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login_password");
        set => this.WithProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformProperty<string>? Collation
    {
        get => GetProperty<TerraformProperty<string>>("collation");
        set => this.WithProperty("collation", value);
    }

    /// <summary>
    /// The database_format attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseFormat
    {
        get => GetProperty<TerraformProperty<string>>("database_format");
        set => this.WithProperty("database_format", value);
    }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    public TerraformProperty<string>? DnsZonePartnerId
    {
        get => GetProperty<TerraformProperty<string>>("dns_zone_partner_id");
        set => this.WithProperty("dns_zone_partner_id", value);
    }

    /// <summary>
    /// The hybrid_secondary_usage attribute.
    /// </summary>
    public TerraformProperty<string>? HybridSecondaryUsage
    {
        get => GetProperty<TerraformProperty<string>>("hybrid_secondary_usage");
        set => this.WithProperty("hybrid_secondary_usage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    public required TerraformProperty<string> LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_configuration_name");
        set => this.WithProperty("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("minimum_tls_version");
        set => this.WithProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    public TerraformProperty<string>? ProxyOverride
    {
        get => GetProperty<TerraformProperty<string>>("proxy_override");
        set => this.WithProperty("proxy_override", value);
    }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicDataEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_data_endpoint_enabled");
        set => this.WithProperty("public_data_endpoint_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_principal_type attribute.
    /// </summary>
    public TerraformProperty<string>? ServicePrincipalType
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_type");
        set => this.WithProperty("service_principal_type", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountType
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_type");
        set => this.WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSizeInGb is required")]
    public required TerraformProperty<double> StorageSizeInGb
    {
        get => GetProperty<TerraformProperty<double>>("storage_size_in_gb");
        set => this.WithProperty("storage_size_in_gb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public TerraformProperty<string>? TimezoneId
    {
        get => GetProperty<TerraformProperty<string>>("timezone_id");
        set => this.WithProperty("timezone_id", value);
    }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vcores is required")]
    public required TerraformProperty<double> Vcores
    {
        get => GetProperty<TerraformProperty<double>>("vcores");
        set => this.WithProperty("vcores", value);
    }

    /// <summary>
    /// The zone_redundant_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundantEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundant_enabled");
        set => this.WithProperty("zone_redundant_enabled", value);
    }

    /// <summary>
    /// Block for azure_active_directory_administrator.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryAdministrator block(s) allowed")]
    public List<AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock>? AzureActiveDirectoryAdministrator
    {
        get => GetProperty<List<AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock>>("azure_active_directory_administrator");
        set => this.WithProperty("azure_active_directory_administrator", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMssqlManagedInstanceIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermMssqlManagedInstanceIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlManagedInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlManagedInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    public TerraformExpression DnsZone => this["dns_zone"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
