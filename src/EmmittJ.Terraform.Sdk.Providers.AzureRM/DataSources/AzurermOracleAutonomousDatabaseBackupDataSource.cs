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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("automatic");
        this.DeclareOutput("autonomous_database_backup_ocid");
        this.DeclareOutput("autonomous_database_ocid");
        this.DeclareOutput("database_backup_size_in_tbs");
        this.DeclareOutput("database_version");
        this.DeclareOutput("display_name");
        this.DeclareOutput("id");
        this.DeclareOutput("lifecycle_details");
        this.DeclareOutput("lifecycle_state");
        this.DeclareOutput("location");
        this.DeclareOutput("provisioning_state");
        this.DeclareOutput("restorable");
        this.DeclareOutput("retention_period_in_days");
        this.DeclareOutput("time_available_til");
        this.DeclareOutput("time_ended");
        this.DeclareOutput("time_started");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    public required TerraformProperty<string> AutonomousDatabaseId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("autonomous_database_id");
        set => this.WithProperty("autonomous_database_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
