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
/// Block type for output_target in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlJobStepOutputTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_target";

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    [TerraformArgument("job_credential_id")]
    public TerraformValue<string>? JobCredentialId
    {
        get => new TerraformReference<string>(this, "job_credential_id");
        set => SetArgument("job_credential_id", value);
    }

    /// <summary>
    /// The mssql_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MssqlDatabaseId is required")]
    [TerraformArgument("mssql_database_id")]
    public required TerraformValue<string> MssqlDatabaseId
    {
        get => new TerraformReference<string>(this, "mssql_database_id");
        set => SetArgument("mssql_database_id", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    [TerraformArgument("schema_name")]
    public TerraformValue<string>? SchemaName
    {
        get => new TerraformReference<string>(this, "schema_name");
        set => SetArgument("schema_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformArgument("table_name")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlJobStepTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    /// The initial_retry_interval_seconds attribute.
    /// </summary>
    [TerraformArgument("initial_retry_interval_seconds")]
    public TerraformValue<double>? InitialRetryIntervalSeconds
    {
        get => new TerraformReference<double>(this, "initial_retry_interval_seconds");
        set => SetArgument("initial_retry_interval_seconds", value);
    }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    [TerraformArgument("job_credential_id")]
    public TerraformValue<string>? JobCredentialId
    {
        get => new TerraformReference<string>(this, "job_credential_id");
        set => SetArgument("job_credential_id", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    [TerraformArgument("job_id")]
    public required TerraformValue<string> JobId
    {
        get => new TerraformReference<string>(this, "job_id");
        set => SetArgument("job_id", value);
    }

    /// <summary>
    /// The job_step_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobStepIndex is required")]
    [TerraformArgument("job_step_index")]
    public required TerraformValue<double> JobStepIndex
    {
        get => new TerraformReference<double>(this, "job_step_index");
        set => SetArgument("job_step_index", value);
    }

    /// <summary>
    /// The job_target_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobTargetGroupId is required")]
    [TerraformArgument("job_target_group_id")]
    public required TerraformValue<string> JobTargetGroupId
    {
        get => new TerraformReference<string>(this, "job_target_group_id");
        set => SetArgument("job_target_group_id", value);
    }

    /// <summary>
    /// The maximum_retry_interval_seconds attribute.
    /// </summary>
    [TerraformArgument("maximum_retry_interval_seconds")]
    public TerraformValue<double>? MaximumRetryIntervalSeconds
    {
        get => new TerraformReference<double>(this, "maximum_retry_interval_seconds");
        set => SetArgument("maximum_retry_interval_seconds", value);
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
    /// The retry_attempts attribute.
    /// </summary>
    [TerraformArgument("retry_attempts")]
    public TerraformValue<double>? RetryAttempts
    {
        get => new TerraformReference<double>(this, "retry_attempts");
        set => SetArgument("retry_attempts", value);
    }

    /// <summary>
    /// The retry_interval_backoff_multiplier attribute.
    /// </summary>
    [TerraformArgument("retry_interval_backoff_multiplier")]
    public TerraformValue<double>? RetryIntervalBackoffMultiplier
    {
        get => new TerraformReference<double>(this, "retry_interval_backoff_multiplier");
        set => SetArgument("retry_interval_backoff_multiplier", value);
    }

    /// <summary>
    /// The sql_script attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlScript is required")]
    [TerraformArgument("sql_script")]
    public required TerraformValue<string> SqlScript
    {
        get => new TerraformReference<string>(this, "sql_script");
        set => SetArgument("sql_script", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    [TerraformArgument("timeout_seconds")]
    public TerraformValue<double>? TimeoutSeconds
    {
        get => new TerraformReference<double>(this, "timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// Block for output_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputTarget block(s) allowed")]
    [TerraformArgument("output_target")]
    public TerraformList<AzurermMssqlJobStepOutputTargetBlock> OutputTarget { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlJobStepTimeoutsBlock Timeouts { get; set; } = new();

}
