using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromBackupTimeoutsBlock : TerraformBlock
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

}

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
        SetOutput("admin_password");
        SetOutput("allowed_ip_addresses");
        SetOutput("auto_scaling_enabled");
        SetOutput("auto_scaling_for_storage_enabled");
        SetOutput("backup_retention_period_in_days");
        SetOutput("backup_timestamp");
        SetOutput("character_set");
        SetOutput("clone_type");
        SetOutput("compute_count");
        SetOutput("compute_model");
        SetOutput("customer_contacts");
        SetOutput("data_storage_size_in_tb");
        SetOutput("database_version");
        SetOutput("database_workload");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("license_model");
        SetOutput("location");
        SetOutput("mtls_connection_required");
        SetOutput("name");
        SetOutput("national_character_set");
        SetOutput("resource_group_name");
        SetOutput("source_autonomous_database_id");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("virtual_network_id");
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    public required TerraformProperty<string> AdminPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_password");
        set => SetProperty("admin_password", value);
    }

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AllowedIpAddresses
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("allowed_ip_addresses");
        set => SetProperty("allowed_ip_addresses", value);
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingEnabled is required")]
    public required TerraformProperty<bool> AutoScalingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_scaling_enabled");
        set => SetProperty("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingForStorageEnabled is required")]
    public required TerraformProperty<bool> AutoScalingForStorageEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_scaling_for_storage_enabled");
        set => SetProperty("auto_scaling_for_storage_enabled", value);
    }

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRetentionPeriodInDays is required")]
    public required TerraformProperty<double> BackupRetentionPeriodInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("backup_retention_period_in_days");
        set => SetProperty("backup_retention_period_in_days", value);
    }

    /// <summary>
    /// The backup_timestamp attribute.
    /// </summary>
    public TerraformProperty<string> BackupTimestamp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_timestamp");
        set => SetProperty("backup_timestamp", value);
    }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CharacterSet is required")]
    public required TerraformProperty<string> CharacterSet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("character_set");
        set => SetProperty("character_set", value);
    }

    /// <summary>
    /// The clone_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloneType is required")]
    public required TerraformProperty<string> CloneType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("clone_type");
        set => SetProperty("clone_type", value);
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    public required TerraformProperty<double> ComputeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("compute_count");
        set => SetProperty("compute_count", value);
    }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeModel is required")]
    public required TerraformProperty<string> ComputeModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compute_model");
        set => SetProperty("compute_model", value);
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public List<TerraformProperty<string>> CustomerContacts
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("customer_contacts");
        set => SetProperty("customer_contacts", value);
    }

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStorageSizeInTb is required")]
    public required TerraformProperty<double> DataStorageSizeInTb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("data_storage_size_in_tb");
        set => SetProperty("data_storage_size_in_tb", value);
    }

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseVersion is required")]
    public required TerraformProperty<string> DatabaseVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_version");
        set => SetProperty("database_version", value);
    }

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseWorkload is required")]
    public required TerraformProperty<string> DatabaseWorkload
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_workload");
        set => SetProperty("database_workload", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    public required TerraformProperty<string> LicenseModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_model");
        set => SetProperty("license_model", value);
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
    /// The mtls_connection_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MtlsConnectionRequired is required")]
    public required TerraformProperty<bool> MtlsConnectionRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("mtls_connection_required");
        set => SetProperty("mtls_connection_required", value);
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
    /// The national_character_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NationalCharacterSet is required")]
    public required TerraformProperty<string> NationalCharacterSet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("national_character_set");
        set => SetProperty("national_character_set", value);
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
    /// The source_autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceAutonomousDatabaseId is required")]
    public required TerraformProperty<string> SourceAutonomousDatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_autonomous_database_id");
        set => SetProperty("source_autonomous_database_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> SubnetId
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
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string> VirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_id");
        set => SetProperty("virtual_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleAutonomousDatabaseCloneFromBackupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
