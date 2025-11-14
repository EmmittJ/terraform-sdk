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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromDatabaseTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_oracle_autonomous_database_clone_from_database resource.
/// </summary>
public class AzurermOracleAutonomousDatabaseCloneFromDatabase : TerraformResource
{
    public AzurermOracleAutonomousDatabaseCloneFromDatabase(string name) : base("azurerm_oracle_autonomous_database_clone_from_database", name)
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    [TerraformArgument("admin_password")]
    public required TerraformValue<string> AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The allowed_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("allowed_ip_addresses")]
    public TerraformSet<string>? AllowedIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("allowed_ip_addresses", value);
    }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingEnabled is required")]
    [TerraformArgument("auto_scaling_enabled")]
    public required TerraformValue<bool> AutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_enabled");
        set => SetArgument("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingForStorageEnabled is required")]
    [TerraformArgument("auto_scaling_for_storage_enabled")]
    public required TerraformValue<bool> AutoScalingForStorageEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_for_storage_enabled");
        set => SetArgument("auto_scaling_for_storage_enabled", value);
    }

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRetentionPeriodInDays is required")]
    [TerraformArgument("backup_retention_period_in_days")]
    public required TerraformValue<double> BackupRetentionPeriodInDays
    {
        get => new TerraformReference<double>(this, "backup_retention_period_in_days");
        set => SetArgument("backup_retention_period_in_days", value);
    }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CharacterSet is required")]
    [TerraformArgument("character_set")]
    public required TerraformValue<string> CharacterSet
    {
        get => new TerraformReference<string>(this, "character_set");
        set => SetArgument("character_set", value);
    }

    /// <summary>
    /// The clone_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloneType is required")]
    [TerraformArgument("clone_type")]
    public required TerraformValue<string> CloneType
    {
        get => new TerraformReference<string>(this, "clone_type");
        set => SetArgument("clone_type", value);
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    [TerraformArgument("compute_count")]
    public required TerraformValue<double> ComputeCount
    {
        get => new TerraformReference<double>(this, "compute_count");
        set => SetArgument("compute_count", value);
    }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeModel is required")]
    [TerraformArgument("compute_model")]
    public required TerraformValue<string> ComputeModel
    {
        get => new TerraformReference<string>(this, "compute_model");
        set => SetArgument("compute_model", value);
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformArgument("customer_contacts")]
    public TerraformList<string>? CustomerContacts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "customer_contacts").ResolveNodes(ctx));
        set => SetArgument("customer_contacts", value);
    }

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStorageSizeInTb is required")]
    [TerraformArgument("data_storage_size_in_tb")]
    public required TerraformValue<double> DataStorageSizeInTb
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tb");
        set => SetArgument("data_storage_size_in_tb", value);
    }

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseVersion is required")]
    [TerraformArgument("database_version")]
    public required TerraformValue<string> DatabaseVersion
    {
        get => new TerraformReference<string>(this, "database_version");
        set => SetArgument("database_version", value);
    }

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseWorkload is required")]
    [TerraformArgument("database_workload")]
    public required TerraformValue<string> DatabaseWorkload
    {
        get => new TerraformReference<string>(this, "database_workload");
        set => SetArgument("database_workload", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    [TerraformArgument("license_model")]
    public required TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
        set => SetArgument("license_model", value);
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
    /// The mtls_connection_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MtlsConnectionRequired is required")]
    [TerraformArgument("mtls_connection_required")]
    public required TerraformValue<bool> MtlsConnectionRequired
    {
        get => new TerraformReference<bool>(this, "mtls_connection_required");
        set => SetArgument("mtls_connection_required", value);
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
    /// The national_character_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NationalCharacterSet is required")]
    [TerraformArgument("national_character_set")]
    public required TerraformValue<string> NationalCharacterSet
    {
        get => new TerraformReference<string>(this, "national_character_set");
        set => SetArgument("national_character_set", value);
    }

    /// <summary>
    /// The refreshable_model attribute.
    /// </summary>
    [TerraformArgument("refreshable_model")]
    public TerraformValue<string>? RefreshableModel
    {
        get => new TerraformReference<string>(this, "refreshable_model");
        set => SetArgument("refreshable_model", value);
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
    /// The source_autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceAutonomousDatabaseId is required")]
    [TerraformArgument("source_autonomous_database_id")]
    public required TerraformValue<string> SourceAutonomousDatabaseId
    {
        get => new TerraformReference<string>(this, "source_autonomous_database_id");
        set => SetArgument("source_autonomous_database_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string>? SubnetId
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
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformArgument("virtual_network_id")]
    public TerraformValue<string>? VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOracleAutonomousDatabaseCloneFromDatabaseTimeoutsBlock Timeouts { get; set; } = new();

}
