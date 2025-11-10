using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for output_target in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlJobStepOutputTargetBlock : ITerraformBlock
{
    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    [TerraformPropertyName("job_credential_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? JobCredentialId { get; set; }

    /// <summary>
    /// The mssql_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MssqlDatabaseId is required")]
    [TerraformPropertyName("mssql_database_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MssqlDatabaseId { get; set; }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    [TerraformPropertyName("schema_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SchemaName { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformPropertyName("table_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlJobStepTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The initial_retry_interval_seconds attribute.
    /// </summary>
    [TerraformPropertyName("initial_retry_interval_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InitialRetryIntervalSeconds { get; set; }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    [TerraformPropertyName("job_credential_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? JobCredentialId { get; set; }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    [TerraformPropertyName("job_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> JobId { get; set; }

    /// <summary>
    /// The job_step_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobStepIndex is required")]
    [TerraformPropertyName("job_step_index")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> JobStepIndex { get; set; }

    /// <summary>
    /// The job_target_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobTargetGroupId is required")]
    [TerraformPropertyName("job_target_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> JobTargetGroupId { get; set; }

    /// <summary>
    /// The maximum_retry_interval_seconds attribute.
    /// </summary>
    [TerraformPropertyName("maximum_retry_interval_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumRetryIntervalSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The retry_attempts attribute.
    /// </summary>
    [TerraformPropertyName("retry_attempts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryAttempts { get; set; }

    /// <summary>
    /// The retry_interval_backoff_multiplier attribute.
    /// </summary>
    [TerraformPropertyName("retry_interval_backoff_multiplier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryIntervalBackoffMultiplier { get; set; }

    /// <summary>
    /// The sql_script attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlScript is required")]
    [TerraformPropertyName("sql_script")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SqlScript { get; set; }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TimeoutSeconds { get; set; }

    /// <summary>
    /// Block for output_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputTarget block(s) allowed")]
    [TerraformPropertyName("output_target")]
    public TerraformList<TerraformBlock<AzurermMssqlJobStepOutputTargetBlock>>? OutputTarget { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlJobStepTimeoutsBlock>? Timeouts { get; set; } = new();

}
