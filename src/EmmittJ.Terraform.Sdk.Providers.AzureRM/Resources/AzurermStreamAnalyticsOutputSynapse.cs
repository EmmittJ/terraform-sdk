using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_output_synapse resource.
/// </summary>
public class AzurermStreamAnalyticsOutputSynapse : TerraformResource
{
    public AzurermStreamAnalyticsOutputSynapse(string name) : base("azurerm_stream_analytics_output_synapse", name)
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
    /// The user attribute.
    /// </summary>
    public TerraformProperty<string>? User
    {
        get => GetProperty<TerraformProperty<string>>("user");
        set => this.WithProperty("user", value);
    }

}
