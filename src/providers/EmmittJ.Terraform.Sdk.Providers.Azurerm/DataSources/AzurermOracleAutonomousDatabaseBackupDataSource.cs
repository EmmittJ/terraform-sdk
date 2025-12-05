using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleAutonomousDatabaseBackupDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_oracle_autonomous_database_backup Terraform data source.
/// Retrieves information about a azurerm_oracle_autonomous_database_backup.
/// </summary>
public partial class AzurermOracleAutonomousDatabaseBackupDataSource(string name) : TerraformDataSource("azurerm_oracle_autonomous_database_backup", name)
{
    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    public required TerraformValue<string> AutonomousDatabaseId
    {
        get => GetRequiredArgument<TerraformValue<string>>("autonomous_database_id");
        set => SetArgument("autonomous_database_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    public TerraformValue<bool> Automatic
        => CreateReference("automatic");

    /// <summary>
    /// The autonomous_database_backup_ocid attribute.
    /// </summary>
    public TerraformValue<string> AutonomousDatabaseBackupOcid
        => CreateReference("autonomous_database_backup_ocid");

    /// <summary>
    /// The autonomous_database_ocid attribute.
    /// </summary>
    public TerraformValue<string> AutonomousDatabaseOcid
        => CreateReference("autonomous_database_ocid");

    /// <summary>
    /// The database_backup_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> DatabaseBackupSizeInTbs
        => CreateReference("database_backup_size_in_tbs");

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    public TerraformValue<string> DatabaseVersion
        => CreateReference("database_version");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
        => CreateReference("lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
        => CreateReference("lifecycle_state");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The provisioning_state attribute.
    /// </summary>
    public TerraformValue<string> ProvisioningState
        => CreateReference("provisioning_state");

    /// <summary>
    /// The restorable attribute.
    /// </summary>
    public TerraformValue<bool> Restorable
        => CreateReference("restorable");

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    public TerraformValue<double> RetentionPeriodInDays
        => CreateReference("retention_period_in_days");

    /// <summary>
    /// The time_available_til attribute.
    /// </summary>
    public TerraformValue<string> TimeAvailableTil
        => CreateReference("time_available_til");

    /// <summary>
    /// The time_ended attribute.
    /// </summary>
    public TerraformValue<string> TimeEnded
        => CreateReference("time_ended");

    /// <summary>
    /// The time_started attribute.
    /// </summary>
    public TerraformValue<string> TimeStarted
        => CreateReference("time_started");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
