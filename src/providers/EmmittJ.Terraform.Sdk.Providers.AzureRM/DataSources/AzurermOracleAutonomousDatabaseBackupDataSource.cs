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
public class AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Retrieves information about a azurerm_oracle_autonomous_database_backup.
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseBackupDataSource(string name) : base("azurerm_oracle_autonomous_database_backup", name)
    {
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    [TerraformArgument("autonomous_database_id")]
    public required TerraformValue<string> AutonomousDatabaseId
    {
        get => new TerraformReference<string>(this, "autonomous_database_id");
        set => SetArgument("autonomous_database_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    [TerraformArgument("automatic")]
    public TerraformValue<bool> Automatic
    {
        get => new TerraformReference<bool>(this, "automatic");
    }

    /// <summary>
    /// The autonomous_database_backup_ocid attribute.
    /// </summary>
    [TerraformArgument("autonomous_database_backup_ocid")]
    public TerraformValue<string> AutonomousDatabaseBackupOcid
    {
        get => new TerraformReference<string>(this, "autonomous_database_backup_ocid");
    }

    /// <summary>
    /// The autonomous_database_ocid attribute.
    /// </summary>
    [TerraformArgument("autonomous_database_ocid")]
    public TerraformValue<string> AutonomousDatabaseOcid
    {
        get => new TerraformReference<string>(this, "autonomous_database_ocid");
    }

    /// <summary>
    /// The database_backup_size_in_tbs attribute.
    /// </summary>
    [TerraformArgument("database_backup_size_in_tbs")]
    public TerraformValue<double> DatabaseBackupSizeInTbs
    {
        get => new TerraformReference<double>(this, "database_backup_size_in_tbs");
    }

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    [TerraformArgument("database_version")]
    public TerraformValue<string> DatabaseVersion
    {
        get => new TerraformReference<string>(this, "database_version");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformArgument("lifecycle_details")]
    public TerraformValue<string> LifecycleDetails
    {
        get => new TerraformReference<string>(this, "lifecycle_details");
    }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformArgument("lifecycle_state")]
    public TerraformValue<string> LifecycleState
    {
        get => new TerraformReference<string>(this, "lifecycle_state");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The provisioning_state attribute.
    /// </summary>
    [TerraformArgument("provisioning_state")]
    public TerraformValue<string> ProvisioningState
    {
        get => new TerraformReference<string>(this, "provisioning_state");
    }

    /// <summary>
    /// The restorable attribute.
    /// </summary>
    [TerraformArgument("restorable")]
    public TerraformValue<bool> Restorable
    {
        get => new TerraformReference<bool>(this, "restorable");
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [TerraformArgument("retention_period_in_days")]
    public TerraformValue<double> RetentionPeriodInDays
    {
        get => new TerraformReference<double>(this, "retention_period_in_days");
    }

    /// <summary>
    /// The time_available_til attribute.
    /// </summary>
    [TerraformArgument("time_available_til")]
    public TerraformValue<string> TimeAvailableTil
    {
        get => new TerraformReference<string>(this, "time_available_til");
    }

    /// <summary>
    /// The time_ended attribute.
    /// </summary>
    [TerraformArgument("time_ended")]
    public TerraformValue<string> TimeEnded
    {
        get => new TerraformReference<string>(this, "time_ended");
    }

    /// <summary>
    /// The time_started attribute.
    /// </summary>
    [TerraformArgument("time_started")]
    public TerraformValue<string> TimeStarted
    {
        get => new TerraformReference<string>(this, "time_started");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}
