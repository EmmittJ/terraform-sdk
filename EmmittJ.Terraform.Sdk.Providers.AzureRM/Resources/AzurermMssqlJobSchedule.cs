using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_job_schedule resource.
/// </summary>
public class AzurermMssqlJobSchedule : TerraformResource
{
    public AzurermMssqlJobSchedule(string name) : base("azurerm_mssql_job_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public string? EndTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_time")?.Value;
        set => this.WithProperty("end_time", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The interval attribute.
    /// </summary>
    public string? Interval
    {
        get => GetProperty<TerraformLiteralProperty<string>>("interval")?.Value;
        set => this.WithProperty("interval", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The start_time attribute.
    /// </summary>
    public string? StartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_time")?.Value;
        set => this.WithProperty("start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
