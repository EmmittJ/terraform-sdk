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
        set => SetProperty("job_credential_id", value);
    }

    /// <summary>
    /// The mssql_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MssqlDatabaseId is required")]
    public required TerraformProperty<string> MssqlDatabaseId
    {
        set => SetProperty("mssql_database_id", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    public TerraformProperty<string>? SchemaName
    {
        set => SetProperty("schema_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        set => SetProperty("table_name", value);
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("id");
        SetOutput("initial_retry_interval_seconds");
        SetOutput("job_credential_id");
        SetOutput("job_id");
        SetOutput("job_step_index");
        SetOutput("job_target_group_id");
        SetOutput("maximum_retry_interval_seconds");
        SetOutput("name");
        SetOutput("retry_attempts");
        SetOutput("retry_interval_backoff_multiplier");
        SetOutput("sql_script");
        SetOutput("timeout_seconds");
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
    /// The initial_retry_interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double> InitialRetryIntervalSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("initial_retry_interval_seconds");
        set => SetProperty("initial_retry_interval_seconds", value);
    }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    public TerraformProperty<string> JobCredentialId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_credential_id");
        set => SetProperty("job_credential_id", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    public required TerraformProperty<string> JobId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_id");
        set => SetProperty("job_id", value);
    }

    /// <summary>
    /// The job_step_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobStepIndex is required")]
    public required TerraformProperty<double> JobStepIndex
    {
        get => GetRequiredOutput<TerraformProperty<double>>("job_step_index");
        set => SetProperty("job_step_index", value);
    }

    /// <summary>
    /// The job_target_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobTargetGroupId is required")]
    public required TerraformProperty<string> JobTargetGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_target_group_id");
        set => SetProperty("job_target_group_id", value);
    }

    /// <summary>
    /// The maximum_retry_interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double> MaximumRetryIntervalSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_retry_interval_seconds");
        set => SetProperty("maximum_retry_interval_seconds", value);
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
    /// The retry_attempts attribute.
    /// </summary>
    public TerraformProperty<double> RetryAttempts
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retry_attempts");
        set => SetProperty("retry_attempts", value);
    }

    /// <summary>
    /// The retry_interval_backoff_multiplier attribute.
    /// </summary>
    public TerraformProperty<double> RetryIntervalBackoffMultiplier
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retry_interval_backoff_multiplier");
        set => SetProperty("retry_interval_backoff_multiplier", value);
    }

    /// <summary>
    /// The sql_script attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlScript is required")]
    public required TerraformProperty<string> SqlScript
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_script");
        set => SetProperty("sql_script", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double> TimeoutSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("timeout_seconds");
        set => SetProperty("timeout_seconds", value);
    }

    /// <summary>
    /// Block for output_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputTarget block(s) allowed")]
    public List<AzurermMssqlJobStepOutputTargetBlock>? OutputTarget
    {
        set => SetProperty("output_target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlJobStepTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
