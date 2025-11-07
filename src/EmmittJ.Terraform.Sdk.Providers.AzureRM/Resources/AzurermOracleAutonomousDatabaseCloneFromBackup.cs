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
    public TerraformLiteralProperty<string>? AdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_password");
        set => this.WithProperty("admin_password", value);
    }

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AllowedIpAddresses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_ip_addresses");
        set => this.WithProperty("allowed_ip_addresses", value);
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoScalingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_scaling_enabled");
        set => this.WithProperty("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoScalingForStorageEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_scaling_for_storage_enabled");
        set => this.WithProperty("auto_scaling_for_storage_enabled", value);
    }

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BackupRetentionPeriodInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("backup_retention_period_in_days");
        set => this.WithProperty("backup_retention_period_in_days", value);
    }

    /// <summary>
    /// The backup_timestamp attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BackupTimestamp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_timestamp");
        set => this.WithProperty("backup_timestamp", value);
    }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CharacterSet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("character_set");
        set => this.WithProperty("character_set", value);
    }

    /// <summary>
    /// The clone_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CloneType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("clone_type");
        set => this.WithProperty("clone_type", value);
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ComputeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("compute_count");
        set => this.WithProperty("compute_count", value);
    }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ComputeModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_model");
        set => this.WithProperty("compute_model", value);
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? CustomerContacts
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("customer_contacts");
        set => this.WithProperty("customer_contacts", value);
    }

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DataStorageSizeInTb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("data_storage_size_in_tb");
        set => this.WithProperty("data_storage_size_in_tb", value);
    }

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_version");
        set => this.WithProperty("database_version", value);
    }

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseWorkload
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_workload");
        set => this.WithProperty("database_workload", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The license_model attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LicenseModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_model");
        set => this.WithProperty("license_model", value);
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
    /// The mtls_connection_required attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MtlsConnectionRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("mtls_connection_required");
        set => this.WithProperty("mtls_connection_required", value);
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
    /// The national_character_set attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NationalCharacterSet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("national_character_set");
        set => this.WithProperty("national_character_set", value);
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
    /// The source_autonomous_database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceAutonomousDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_autonomous_database_id");
        set => this.WithProperty("source_autonomous_database_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
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
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
    }

}
