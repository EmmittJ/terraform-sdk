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
        set => SetProperty("azuread_authentication_only_enabled", value);
    }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    public required TerraformProperty<string> LoginUsername
    {
        set => SetProperty("login_username", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformProperty<string> ObjectId
    {
        set => SetProperty("object_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    public required TerraformProperty<string> PrincipalType
    {
        set => SetProperty("principal_type", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
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
public class AzurermMssqlManagedInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mssql_managed_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlManagedInstance : TerraformResource
{
    public AzurermMssqlManagedInstance(string name) : base("azurerm_mssql_managed_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dns_zone");
        SetOutput("fqdn");
        SetOutput("administrator_login");
        SetOutput("administrator_login_password");
        SetOutput("collation");
        SetOutput("database_format");
        SetOutput("dns_zone_partner_id");
        SetOutput("hybrid_secondary_usage");
        SetOutput("id");
        SetOutput("license_type");
        SetOutput("location");
        SetOutput("maintenance_configuration_name");
        SetOutput("minimum_tls_version");
        SetOutput("name");
        SetOutput("proxy_override");
        SetOutput("public_data_endpoint_enabled");
        SetOutput("resource_group_name");
        SetOutput("service_principal_type");
        SetOutput("sku_name");
        SetOutput("storage_account_type");
        SetOutput("storage_size_in_gb");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("timezone_id");
        SetOutput("vcores");
        SetOutput("zone_redundant_enabled");
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorLogin
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_login");
        set => SetProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorLoginPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_login_password");
        set => SetProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformProperty<string> Collation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collation");
        set => SetProperty("collation", value);
    }

    /// <summary>
    /// The database_format attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_format");
        set => SetProperty("database_format", value);
    }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    public TerraformProperty<string> DnsZonePartnerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_zone_partner_id");
        set => SetProperty("dns_zone_partner_id", value);
    }

    /// <summary>
    /// The hybrid_secondary_usage attribute.
    /// </summary>
    public TerraformProperty<string> HybridSecondaryUsage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hybrid_secondary_usage");
        set => SetProperty("hybrid_secondary_usage", value);
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
    /// The license_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    public required TerraformProperty<string> LicenseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_type");
        set => SetProperty("license_type", value);
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
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string> MaintenanceConfigurationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_configuration_name");
        set => SetProperty("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string> MinimumTlsVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("minimum_tls_version");
        set => SetProperty("minimum_tls_version", value);
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
    /// The proxy_override attribute.
    /// </summary>
    public TerraformProperty<string> ProxyOverride
    {
        get => GetRequiredOutput<TerraformProperty<string>>("proxy_override");
        set => SetProperty("proxy_override", value);
    }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicDataEndpointEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_data_endpoint_enabled");
        set => SetProperty("public_data_endpoint_enabled", value);
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
    /// The service_principal_type attribute.
    /// </summary>
    public TerraformProperty<string> ServicePrincipalType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_principal_type");
        set => SetProperty("service_principal_type", value);
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
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string> StorageAccountType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_type");
        set => SetProperty("storage_account_type", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSizeInGb is required")]
    public required TerraformProperty<double> StorageSizeInGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_size_in_gb");
        set => SetProperty("storage_size_in_gb", value);
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
    /// The timezone_id attribute.
    /// </summary>
    public TerraformProperty<string> TimezoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timezone_id");
        set => SetProperty("timezone_id", value);
    }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vcores is required")]
    public required TerraformProperty<double> Vcores
    {
        get => GetRequiredOutput<TerraformProperty<double>>("vcores");
        set => SetProperty("vcores", value);
    }

    /// <summary>
    /// The zone_redundant_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneRedundantEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_redundant_enabled");
        set => SetProperty("zone_redundant_enabled", value);
    }

    /// <summary>
    /// Block for azure_active_directory_administrator.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryAdministrator block(s) allowed")]
    public List<AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock>? AzureActiveDirectoryAdministrator
    {
        set => SetProperty("azure_active_directory_administrator", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMssqlManagedInstanceIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlManagedInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
