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
    public TerraformProperty<string>? Database
    {
        get => GetProperty<TerraformProperty<string>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// The delta_snapshot_query attribute.
    /// </summary>
    public TerraformProperty<string>? DeltaSnapshotQuery
    {
        get => GetProperty<TerraformProperty<string>>("delta_snapshot_query");
        set => this.WithProperty("delta_snapshot_query", value);
    }

    /// <summary>
    /// The full_snapshot_query attribute.
    /// </summary>
    public TerraformProperty<string>? FullSnapshotQuery
    {
        get => GetProperty<TerraformProperty<string>>("full_snapshot_query");
        set => this.WithProperty("full_snapshot_query", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The refresh_interval_duration attribute.
    /// </summary>
    public TerraformProperty<string>? RefreshIntervalDuration
    {
        get => GetProperty<TerraformProperty<string>>("refresh_interval_duration");
        set => this.WithProperty("refresh_interval_duration", value);
    }

    /// <summary>
    /// The refresh_type attribute.
    /// </summary>
    public TerraformProperty<string>? RefreshType
    {
        get => GetProperty<TerraformProperty<string>>("refresh_type");
        set => this.WithProperty("refresh_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    public TerraformProperty<string>? Server
    {
        get => GetProperty<TerraformProperty<string>>("server");
        set => this.WithProperty("server", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public TerraformProperty<string>? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    public TerraformProperty<string>? Table
    {
        get => GetProperty<TerraformProperty<string>>("table");
        set => this.WithProperty("table", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

}
