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
    public TerraformLiteralProperty<string>? AdministratorLogin
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login");
        set => this.WithProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdministratorLoginPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login_password");
        set => this.WithProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The administrator_login_password_wo attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdministratorLoginPasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login_password_wo");
        set => this.WithProperty("administrator_login_password_wo", value);
    }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AdministratorLoginPasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("administrator_login_password_wo_version");
        set => this.WithProperty("administrator_login_password_wo_version", value);
    }

    /// <summary>
    /// The auto_grow_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoGrowEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_grow_enabled");
        set => this.WithProperty("auto_grow_enabled", value);
    }

    /// <summary>
    /// The backup_retention_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BackupRetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("backup_retention_days");
        set => this.WithProperty("backup_retention_days", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_mode");
        set => this.WithProperty("create_mode", value);
    }

    /// <summary>
    /// The creation_source_server_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreationSourceServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("creation_source_server_id");
        set => this.WithProperty("creation_source_server_id", value);
    }

    /// <summary>
    /// The geo_redundant_backup_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? GeoRedundantBackupEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("geo_redundant_backup_enabled");
        set => this.WithProperty("geo_redundant_backup_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? InfrastructureEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("infrastructure_encryption_enabled");
        set => this.WithProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The restore_point_in_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestorePointInTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_point_in_time");
        set => this.WithProperty("restore_point_in_time", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The ssl_enforcement_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SslEnforcementEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ssl_enforcement_enabled");
        set => this.WithProperty("ssl_enforcement_enabled", value);
    }

    /// <summary>
    /// The ssl_minimal_tls_version_enforced attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SslMinimalTlsVersionEnforced
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssl_minimal_tls_version_enforced");
        set => this.WithProperty("ssl_minimal_tls_version_enforced", value);
    }

    /// <summary>
    /// The storage_mb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StorageMb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_mb");
        set => this.WithProperty("storage_mb", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
