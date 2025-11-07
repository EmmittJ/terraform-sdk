using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_output_powerbi resource.
/// </summary>
public class AzurermStreamAnalyticsOutputPowerbi : TerraformResource
{
    public AzurermStreamAnalyticsOutputPowerbi(string name) : base("azurerm_stream_analytics_output_powerbi", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dataset attribute.
    /// </summary>
    public TerraformProperty<string>? Dataset
    {
        get => GetProperty<TerraformProperty<string>>("dataset");
        set => this.WithProperty("dataset", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformProperty<string>? GroupId
    {
        get => GetProperty<TerraformProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformProperty<string>? GroupName
    {
        get => GetProperty<TerraformProperty<string>>("group_name");
        set => this.WithProperty("group_name", value);
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
    /// The stream_analytics_job_id attribute.
    /// </summary>
    public TerraformProperty<string>? StreamAnalyticsJobId
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_id");
        set => this.WithProperty("stream_analytics_job_id", value);
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
    /// The token_user_display_name attribute.
    /// </summary>
    public TerraformProperty<string>? TokenUserDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("token_user_display_name");
        set => this.WithProperty("token_user_display_name", value);
    }

    /// <summary>
    /// The token_user_principal_name attribute.
    /// </summary>
    public TerraformProperty<string>? TokenUserPrincipalName
    {
        get => GetProperty<TerraformProperty<string>>("token_user_principal_name");
        set => this.WithProperty("token_user_principal_name", value);
    }

}
