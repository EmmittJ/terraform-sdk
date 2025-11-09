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
    public TerraformProperty<string>? AdminPassword
    {
        get => GetProperty<TerraformProperty<string>>("admin_password");
        set => this.WithProperty("admin_password", value);
    }

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AllowedIpAddresses
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("allowed_ip_addresses");
        set => this.WithProperty("allowed_ip_addresses", value);
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoScalingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_scaling_enabled");
        set => this.WithProperty("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoScalingForStorageEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_scaling_for_storage_enabled");
        set => this.WithProperty("auto_scaling_for_storage_enabled", value);
    }

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? BackupRetentionPeriodInDays
    {
        get => GetProperty<TerraformProperty<double>>("backup_retention_period_in_days");
        set => this.WithProperty("backup_retention_period_in_days", value);
    }

    /// <summary>
    /// The backup_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? BackupTimestamp
    {
        get => GetProperty<TerraformProperty<string>>("backup_timestamp");
        set => this.WithProperty("backup_timestamp", value);
    }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    public TerraformProperty<string>? CharacterSet
    {
        get => GetProperty<TerraformProperty<string>>("character_set");
        set => this.WithProperty("character_set", value);
    }

    /// <summary>
    /// The clone_type attribute.
    /// </summary>
    public TerraformProperty<string>? CloneType
    {
        get => GetProperty<TerraformProperty<string>>("clone_type");
        set => this.WithProperty("clone_type", value);
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformProperty<double>? ComputeCount
    {
        get => GetProperty<TerraformProperty<double>>("compute_count");
        set => this.WithProperty("compute_count", value);
    }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformProperty<string>? ComputeModel
    {
        get => GetProperty<TerraformProperty<string>>("compute_model");
        set => this.WithProperty("compute_model", value);
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformProperty<List<string>>? CustomerContacts
    {
        get => GetProperty<TerraformProperty<List<string>>>("customer_contacts");
        set => this.WithProperty("customer_contacts", value);
    }

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeInTb
    {
        get => GetProperty<TerraformProperty<double>>("data_storage_size_in_tb");
        set => this.WithProperty("data_storage_size_in_tb", value);
    }

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseVersion
    {
        get => GetProperty<TerraformProperty<string>>("database_version");
        set => this.WithProperty("database_version", value);
    }

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseWorkload
    {
        get => GetProperty<TerraformProperty<string>>("database_workload");
        set => this.WithProperty("database_workload", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The license_model attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseModel
    {
        get => GetProperty<TerraformProperty<string>>("license_model");
        set => this.WithProperty("license_model", value);
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
    /// The mtls_connection_required attribute.
    /// </summary>
    public TerraformProperty<bool>? MtlsConnectionRequired
    {
        get => GetProperty<TerraformProperty<bool>>("mtls_connection_required");
        set => this.WithProperty("mtls_connection_required", value);
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
    /// The national_character_set attribute.
    /// </summary>
    public TerraformProperty<string>? NationalCharacterSet
    {
        get => GetProperty<TerraformProperty<string>>("national_character_set");
        set => this.WithProperty("national_character_set", value);
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
    /// The source_autonomous_database_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceAutonomousDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("source_autonomous_database_id");
        set => this.WithProperty("source_autonomous_database_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
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
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
    }

}
