using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_reference_input_mssql resource.
/// </summary>
public class AzurermStreamAnalyticsReferenceInputMssql : TerraformResource
{
    public AzurermStreamAnalyticsReferenceInputMssql(string name) : base("azurerm_stream_analytics_reference_input_mssql", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public string? Database
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database")?.Value;
        set => this.WithProperty("database", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delta_snapshot_query attribute.
    /// </summary>
    public string? DeltaSnapshotQuery
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delta_snapshot_query")?.Value;
        set => this.WithProperty("delta_snapshot_query", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The full_snapshot_query attribute.
    /// </summary>
    public string? FullSnapshotQuery
    {
        get => GetProperty<TerraformLiteralProperty<string>>("full_snapshot_query")?.Value;
        set => this.WithProperty("full_snapshot_query", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The refresh_interval_duration attribute.
    /// </summary>
    public string? RefreshIntervalDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("refresh_interval_duration")?.Value;
        set => this.WithProperty("refresh_interval_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The refresh_type attribute.
    /// </summary>
    public string? RefreshType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("refresh_type")?.Value;
        set => this.WithProperty("refresh_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    public string? Server
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server")?.Value;
        set => this.WithProperty("server", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public string? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_name")?.Value;
        set => this.WithProperty("stream_analytics_job_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    public string? Table
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table")?.Value;
        set => this.WithProperty("table", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
