using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_job_step resource.
/// </summary>
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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The initial_retry_interval_seconds attribute.
    /// </summary>
    public double? InitialRetryIntervalSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("initial_retry_interval_seconds")?.Value;
        set => this.WithProperty("initial_retry_interval_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    public string? JobCredentialId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_credential_id")?.Value;
        set => this.WithProperty("job_credential_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public string? JobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_id")?.Value;
        set => this.WithProperty("job_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The job_step_index attribute.
    /// </summary>
    public double? JobStepIndex
    {
        get => GetProperty<TerraformLiteralProperty<double>>("job_step_index")?.Value;
        set => this.WithProperty("job_step_index", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The job_target_group_id attribute.
    /// </summary>
    public string? JobTargetGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_target_group_id")?.Value;
        set => this.WithProperty("job_target_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maximum_retry_interval_seconds attribute.
    /// </summary>
    public double? MaximumRetryIntervalSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_retry_interval_seconds")?.Value;
        set => this.WithProperty("maximum_retry_interval_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retry_attempts attribute.
    /// </summary>
    public double? RetryAttempts
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retry_attempts")?.Value;
        set => this.WithProperty("retry_attempts", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The retry_interval_backoff_multiplier attribute.
    /// </summary>
    public double? RetryIntervalBackoffMultiplier
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retry_interval_backoff_multiplier")?.Value;
        set => this.WithProperty("retry_interval_backoff_multiplier", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sql_script attribute.
    /// </summary>
    public string? SqlScript
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_script")?.Value;
        set => this.WithProperty("sql_script", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public double? TimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout_seconds")?.Value;
        set => this.WithProperty("timeout_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
