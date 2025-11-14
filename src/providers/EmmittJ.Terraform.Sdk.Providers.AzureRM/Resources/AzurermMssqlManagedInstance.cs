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
/// Block type for azure_active_directory_administrator in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_active_directory_administrator";

    /// <summary>
    /// The azuread_authentication_only_enabled attribute.
    /// </summary>
    [TerraformArgument("azuread_authentication_only_enabled")]
    public TerraformValue<bool>? AzureadAuthenticationOnlyEnabled
    {
        get => new TerraformReference<bool>(this, "azuread_authentication_only_enabled");
        set => SetArgument("azuread_authentication_only_enabled", value);
    }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    [TerraformArgument("login_username")]
    public required TerraformValue<string> LoginUsername
    {
        get => new TerraformReference<string>(this, "login_username");
        set => SetArgument("login_username", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [TerraformArgument("object_id")]
    public required TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    [TerraformArgument("principal_type")]
    public required TerraformValue<string> PrincipalType
    {
        get => new TerraformReference<string>(this, "principal_type");
        set => SetArgument("principal_type", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string>? TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceIdentityBlock : TerraformBlock
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
public class AzurermMssqlManagedInstanceTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("administrator_login")]
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [TerraformArgument("administrator_login_password")]
    public TerraformValue<string>? AdministratorLoginPassword
    {
        get => new TerraformReference<string>(this, "administrator_login_password");
        set => SetArgument("administrator_login_password", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformArgument("collation")]
    public TerraformValue<string>? Collation
    {
        get => new TerraformReference<string>(this, "collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// The database_format attribute.
    /// </summary>
    [TerraformArgument("database_format")]
    public TerraformValue<string>? DatabaseFormat
    {
        get => new TerraformReference<string>(this, "database_format");
        set => SetArgument("database_format", value);
    }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    [TerraformArgument("dns_zone_partner_id")]
    public TerraformValue<string>? DnsZonePartnerId
    {
        get => new TerraformReference<string>(this, "dns_zone_partner_id");
        set => SetArgument("dns_zone_partner_id", value);
    }

    /// <summary>
    /// The hybrid_secondary_usage attribute.
    /// </summary>
    [TerraformArgument("hybrid_secondary_usage")]
    public TerraformValue<string>? HybridSecondaryUsage
    {
        get => new TerraformReference<string>(this, "hybrid_secondary_usage");
        set => SetArgument("hybrid_secondary_usage", value);
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
    /// The license_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    [TerraformArgument("license_type")]
    public required TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
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
    /// The maintenance_configuration_name attribute.
    /// </summary>
    [TerraformArgument("maintenance_configuration_name")]
    public TerraformValue<string>? MaintenanceConfigurationName
    {
        get => new TerraformReference<string>(this, "maintenance_configuration_name");
        set => SetArgument("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformArgument("minimum_tls_version")]
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
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
    /// The proxy_override attribute.
    /// </summary>
    [TerraformArgument("proxy_override")]
    public TerraformValue<string>? ProxyOverride
    {
        get => new TerraformReference<string>(this, "proxy_override");
        set => SetArgument("proxy_override", value);
    }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    [TerraformArgument("public_data_endpoint_enabled")]
    public TerraformValue<bool>? PublicDataEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "public_data_endpoint_enabled");
        set => SetArgument("public_data_endpoint_enabled", value);
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
    /// The service_principal_type attribute.
    /// </summary>
    [TerraformArgument("service_principal_type")]
    public TerraformValue<string>? ServicePrincipalType
    {
        get => new TerraformReference<string>(this, "service_principal_type");
        set => SetArgument("service_principal_type", value);
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
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformArgument("storage_account_type")]
    public TerraformValue<string>? StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSizeInGb is required")]
    [TerraformArgument("storage_size_in_gb")]
    public required TerraformValue<double> StorageSizeInGb
    {
        get => new TerraformReference<double>(this, "storage_size_in_gb");
        set => SetArgument("storage_size_in_gb", value);
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
    /// The timezone_id attribute.
    /// </summary>
    [TerraformArgument("timezone_id")]
    public TerraformValue<string>? TimezoneId
    {
        get => new TerraformReference<string>(this, "timezone_id");
        set => SetArgument("timezone_id", value);
    }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vcores is required")]
    [TerraformArgument("vcores")]
    public required TerraformValue<double> Vcores
    {
        get => new TerraformReference<double>(this, "vcores");
        set => SetArgument("vcores", value);
    }

    /// <summary>
    /// The zone_redundant_enabled attribute.
    /// </summary>
    [TerraformArgument("zone_redundant_enabled")]
    public TerraformValue<bool>? ZoneRedundantEnabled
    {
        get => new TerraformReference<bool>(this, "zone_redundant_enabled");
        set => SetArgument("zone_redundant_enabled", value);
    }

    /// <summary>
    /// Block for azure_active_directory_administrator.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryAdministrator block(s) allowed")]
    [TerraformArgument("azure_active_directory_administrator")]
    public TerraformList<AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock> AzureActiveDirectoryAdministrator { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermMssqlManagedInstanceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlManagedInstanceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    [TerraformArgument("dns_zone")]
    public TerraformValue<string> DnsZone
    {
        get => new TerraformReference<string>(this, "dns_zone");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

}
