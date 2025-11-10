using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database_backup.
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseBackupDataSource(string name) : base("azurerm_oracle_autonomous_database_backup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("automatic");
        SetOutput("autonomous_database_backup_ocid");
        SetOutput("autonomous_database_ocid");
        SetOutput("database_backup_size_in_tbs");
        SetOutput("database_version");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("lifecycle_details");
        SetOutput("lifecycle_state");
        SetOutput("location");
        SetOutput("provisioning_state");
        SetOutput("restorable");
        SetOutput("retention_period_in_days");
        SetOutput("time_available_til");
        SetOutput("time_ended");
        SetOutput("time_started");
        SetOutput("type");
        SetOutput("autonomous_database_id");
        SetOutput("name");
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    public required TerraformProperty<string> AutonomousDatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("autonomous_database_id");
        set => SetProperty("autonomous_database_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    public TerraformExpression Automatic => this["automatic"];

    /// <summary>
    /// The autonomous_database_backup_ocid attribute.
    /// </summary>
    public TerraformExpression AutonomousDatabaseBackupOcid => this["autonomous_database_backup_ocid"];

    /// <summary>
    /// The autonomous_database_ocid attribute.
    /// </summary>
    public TerraformExpression AutonomousDatabaseOcid => this["autonomous_database_ocid"];

    /// <summary>
    /// The database_backup_size_in_tbs attribute.
    /// </summary>
    public TerraformExpression DatabaseBackupSizeInTbs => this["database_backup_size_in_tbs"];

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    public TerraformExpression DatabaseVersion => this["database_version"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformExpression LifecycleDetails => this["lifecycle_details"];

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The provisioning_state attribute.
    /// </summary>
    public TerraformExpression ProvisioningState => this["provisioning_state"];

    /// <summary>
    /// The restorable attribute.
    /// </summary>
    public TerraformExpression Restorable => this["restorable"];

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    public TerraformExpression RetentionPeriodInDays => this["retention_period_in_days"];

    /// <summary>
    /// The time_available_til attribute.
    /// </summary>
    public TerraformExpression TimeAvailableTil => this["time_available_til"];

    /// <summary>
    /// The time_ended attribute.
    /// </summary>
    public TerraformExpression TimeEnded => this["time_ended"];

    /// <summary>
    /// The time_started attribute.
    /// </summary>
    public TerraformExpression TimeStarted => this["time_started"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
