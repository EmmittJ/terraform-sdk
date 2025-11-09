using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_postgresql_server resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermPostgresqlServer : TerraformResource
{
    public AzurermPostgresqlServer(string name) : base("azurerm_postgresql_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The administrator_login_password_wo attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLoginPasswordWo
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login_password_wo");
        set => this.WithProperty("administrator_login_password_wo", value);
    }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? AdministratorLoginPasswordWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("administrator_login_password_wo_version");
        set => this.WithProperty("administrator_login_password_wo_version", value);
    }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoGrowEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_grow_enabled");
        set => this.WithProperty("auto_grow_enabled", value);
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? BackupRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("backup_retention_days");
        set => this.WithProperty("backup_retention_days", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformProperty<string>? CreateMode
    {
        get => GetProperty<TerraformProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The creation_source_server_id attribute.
    /// </summary>
    public TerraformProperty<string>? CreationSourceServerId
    {
        get => GetProperty<TerraformProperty<string>>("creation_source_server_id");
        set => this.WithProperty("creation_source_server_id", value);
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GeoRedundantBackupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("geo_redundant_backup_enabled");
        set => this.WithProperty("geo_redundant_backup_enabled", value);
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
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InfrastructureEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("infrastructure_encryption_enabled");
        set => this.WithProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    public TerraformProperty<string>? RestorePointInTime
    {
        get => GetProperty<TerraformProperty<string>>("restore_point_in_time");
        set => this.WithProperty("restore_point_in_time", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The ssl_enforcement_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SslEnforcementEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ssl_enforcement_enabled");
        set => this.WithProperty("ssl_enforcement_enabled", value);
    }

    /// <summary>
    /// The ssl_minimal_tls_version_enforced attribute.
    /// </summary>
    public TerraformProperty<string>? SslMinimalTlsVersionEnforced
    {
        get => GetProperty<TerraformProperty<string>>("ssl_minimal_tls_version_enforced");
        set => this.WithProperty("ssl_minimal_tls_version_enforced", value);
    }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    public TerraformProperty<double>? StorageMb
    {
        get => GetProperty<TerraformProperty<double>>("storage_mb");
        set => this.WithProperty("storage_mb", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
