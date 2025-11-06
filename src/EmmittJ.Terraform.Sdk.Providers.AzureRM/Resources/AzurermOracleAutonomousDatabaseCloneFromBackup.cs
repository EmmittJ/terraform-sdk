using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_oracle_autonomous_database_clone_from_backup resource.
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromBackup : TerraformResource
{
    public AzurermOracleAutonomousDatabaseCloneFromBackup(string name) : base("azurerm_oracle_autonomous_database_clone_from_backup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public string? AdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_password")?.Value;
        set => this.WithProperty("admin_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    public HashSet<string>? AllowedIpAddresses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_ip_addresses")?.Value;
        set => this.WithProperty("allowed_ip_addresses", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public bool? AutoScalingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_scaling_enabled")?.Value;
        set => this.WithProperty("auto_scaling_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    public bool? AutoScalingForStorageEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_scaling_for_storage_enabled")?.Value;
        set => this.WithProperty("auto_scaling_for_storage_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    public double? BackupRetentionPeriodInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("backup_retention_period_in_days")?.Value;
        set => this.WithProperty("backup_retention_period_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The backup_timestamp attribute.
    /// </summary>
    public string? BackupTimestamp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_timestamp")?.Value;
        set => this.WithProperty("backup_timestamp", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    public string? CharacterSet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("character_set")?.Value;
        set => this.WithProperty("character_set", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The clone_type attribute.
    /// </summary>
    public string? CloneType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("clone_type")?.Value;
        set => this.WithProperty("clone_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public double? ComputeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("compute_count")?.Value;
        set => this.WithProperty("compute_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public string? ComputeModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_model")?.Value;
        set => this.WithProperty("compute_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public List<string>? CustomerContacts
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("customer_contacts")?.Value;
        set => this.WithProperty("customer_contacts", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    public double? DataStorageSizeInTb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("data_storage_size_in_tb")?.Value;
        set => this.WithProperty("data_storage_size_in_tb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    public string? DatabaseVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_version")?.Value;
        set => this.WithProperty("database_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    public string? DatabaseWorkload
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_workload")?.Value;
        set => this.WithProperty("database_workload", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public string? LicenseModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_model")?.Value;
        set => this.WithProperty("license_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    public bool? MtlsConnectionRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("mtls_connection_required")?.Value;
        set => this.WithProperty("mtls_connection_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    public string? NationalCharacterSet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("national_character_set")?.Value;
        set => this.WithProperty("national_character_set", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_autonomous_database_id attribute.
    /// </summary>
    public string? SourceAutonomousDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_autonomous_database_id")?.Value;
        set => this.WithProperty("source_autonomous_database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public string? VirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_id")?.Value;
        set => this.WithProperty("virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
