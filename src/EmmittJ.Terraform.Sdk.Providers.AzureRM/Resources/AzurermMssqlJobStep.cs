using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for output_target in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlJobStepOutputTargetBlock : TerraformBlock
{
    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    public TerraformProperty<string>? JobCredentialId
    {
        get => GetProperty<TerraformProperty<string>>("job_credential_id");
        set => WithProperty("job_credential_id", value);
    }

    /// <summary>
    /// The mssql_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MssqlDatabaseId is required")]
    public required TerraformProperty<string> MssqlDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("mssql_database_id");
        set => WithProperty("mssql_database_id", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    public TerraformProperty<string>? SchemaName
    {
        get => GetProperty<TerraformProperty<string>>("schema_name");
        set => WithProperty("schema_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => WithProperty("table_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlJobStepTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_job_step resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlJobStep : TerraformResource
{
    public AzurermMssqlJobStep(string name) : base("azurerm_mssql_job_step", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The initial_retry_interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? InitialRetryIntervalSeconds
    {
        get => GetProperty<TerraformProperty<double>>("initial_retry_interval_seconds");
        set => this.WithProperty("initial_retry_interval_seconds", value);
    }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    public TerraformProperty<string>? JobCredentialId
    {
        get => GetProperty<TerraformProperty<string>>("job_credential_id");
        set => this.WithProperty("job_credential_id", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    public required TerraformProperty<string> JobId
    {
        get => GetProperty<TerraformProperty<string>>("job_id");
        set => this.WithProperty("job_id", value);
    }

    /// <summary>
    /// The job_step_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobStepIndex is required")]
    public required TerraformProperty<double> JobStepIndex
    {
        get => GetProperty<TerraformProperty<double>>("job_step_index");
        set => this.WithProperty("job_step_index", value);
    }

    /// <summary>
    /// The job_target_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobTargetGroupId is required")]
    public required TerraformProperty<string> JobTargetGroupId
    {
        get => GetProperty<TerraformProperty<string>>("job_target_group_id");
        set => this.WithProperty("job_target_group_id", value);
    }

    /// <summary>
    /// The maximum_retry_interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumRetryIntervalSeconds
    {
        get => GetProperty<TerraformProperty<double>>("maximum_retry_interval_seconds");
        set => this.WithProperty("maximum_retry_interval_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The retry_attempts attribute.
    /// </summary>
    public TerraformProperty<double>? RetryAttempts
    {
        get => GetProperty<TerraformProperty<double>>("retry_attempts");
        set => this.WithProperty("retry_attempts", value);
    }

    /// <summary>
    /// The retry_interval_backoff_multiplier attribute.
    /// </summary>
    public TerraformProperty<double>? RetryIntervalBackoffMultiplier
    {
        get => GetProperty<TerraformProperty<double>>("retry_interval_backoff_multiplier");
        set => this.WithProperty("retry_interval_backoff_multiplier", value);
    }

    /// <summary>
    /// The sql_script attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlScript is required")]
    public required TerraformProperty<string> SqlScript
    {
        get => GetProperty<TerraformProperty<string>>("sql_script");
        set => this.WithProperty("sql_script", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_seconds");
        set => this.WithProperty("timeout_seconds", value);
    }

    /// <summary>
    /// Block for output_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputTarget block(s) allowed")]
    public List<AzurermMssqlJobStepOutputTargetBlock>? OutputTarget
    {
        get => GetProperty<List<AzurermMssqlJobStepOutputTargetBlock>>("output_target");
        set => this.WithProperty("output_target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlJobStepTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlJobStepTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
