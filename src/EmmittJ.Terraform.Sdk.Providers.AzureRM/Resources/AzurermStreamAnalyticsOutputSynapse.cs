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
    public TerraformLiteralProperty<string>? Database
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Server
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server");
        set => this.WithProperty("server", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Table
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table");
        set => this.WithProperty("table", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? User
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user");
        set => this.WithProperty("user", value);
    }

}
