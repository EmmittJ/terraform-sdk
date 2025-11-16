using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<bool>? AzureadAuthenticationOnlyEnabled
    {
        get => new TerraformReference<bool>(this, "azuread_authentication_only_enabled");
        set => SetArgument("azuread_authentication_only_enabled", value);
    }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    public required TerraformValue<string> LoginUsername
    {
        get => new TerraformReference<string>(this, "login_username");
        set => SetArgument("login_username", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalType is required")]
    public required TerraformValue<string> PrincipalType
    {
        get => new TerraformReference<string>(this, "principal_type");
        set => SetArgument("principal_type", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
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
public class AzurermMssqlManagedInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mssql_managed_instance Terraform resource.
/// Manages a azurerm_mssql_managed_instance resource.
/// </summary>
public partial class AzurermMssqlManagedInstance(string name) : TerraformResource("azurerm_mssql_managed_instance", name)
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorLoginPassword
    {
        get => new TerraformReference<string>(this, "administrator_login_password");
        set => SetArgument("administrator_login_password", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string>? Collation
    {
        get => new TerraformReference<string>(this, "collation");
        set => SetArgument("collation", value);
    }

    /// <summary>
    /// The database_format attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseFormat
    {
        get => new TerraformReference<string>(this, "database_format");
        set => SetArgument("database_format", value);
    }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    public TerraformValue<string>? DnsZonePartnerId
    {
        get => new TerraformReference<string>(this, "dns_zone_partner_id");
        set => SetArgument("dns_zone_partner_id", value);
    }

    /// <summary>
    /// The hybrid_secondary_usage attribute.
    /// </summary>
    public TerraformValue<string>? HybridSecondaryUsage
    {
        get => new TerraformReference<string>(this, "hybrid_secondary_usage");
        set => SetArgument("hybrid_secondary_usage", value);
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
    /// The license_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    public required TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
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
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformValue<string>? MaintenanceConfigurationName
    {
        get => new TerraformReference<string>(this, "maintenance_configuration_name");
        set => SetArgument("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
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
    /// The proxy_override attribute.
    /// </summary>
    public TerraformValue<string>? ProxyOverride
    {
        get => new TerraformReference<string>(this, "proxy_override");
        set => SetArgument("proxy_override", value);
    }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicDataEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "public_data_endpoint_enabled");
        set => SetArgument("public_data_endpoint_enabled", value);
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
    /// The service_principal_type attribute.
    /// </summary>
    public TerraformValue<string>? ServicePrincipalType
    {
        get => new TerraformReference<string>(this, "service_principal_type");
        set => SetArgument("service_principal_type", value);
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
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSizeInGb is required")]
    public required TerraformValue<double> StorageSizeInGb
    {
        get => new TerraformReference<double>(this, "storage_size_in_gb");
        set => SetArgument("storage_size_in_gb", value);
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
    /// The timezone_id attribute.
    /// </summary>
    public TerraformValue<string>? TimezoneId
    {
        get => new TerraformReference<string>(this, "timezone_id");
        set => SetArgument("timezone_id", value);
    }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vcores is required")]
    public required TerraformValue<double> Vcores
    {
        get => new TerraformReference<double>(this, "vcores");
        set => SetArgument("vcores", value);
    }

    /// <summary>
    /// The zone_redundant_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundantEnabled
    {
        get => new TerraformReference<bool>(this, "zone_redundant_enabled");
        set => SetArgument("zone_redundant_enabled", value);
    }

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    public TerraformValue<string> DnsZone
    {
        get => new TerraformReference<string>(this, "dns_zone");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// AzureActiveDirectoryAdministrator block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureActiveDirectoryAdministrator block(s) allowed")]
    public TerraformList<AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock>? AzureActiveDirectoryAdministrator
    {
        get => GetArgument<TerraformList<AzurermMssqlManagedInstanceAzureActiveDirectoryAdministratorBlock>>("azure_active_directory_administrator");
        set => SetArgument("azure_active_directory_administrator", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermMssqlManagedInstanceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermMssqlManagedInstanceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlManagedInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlManagedInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
