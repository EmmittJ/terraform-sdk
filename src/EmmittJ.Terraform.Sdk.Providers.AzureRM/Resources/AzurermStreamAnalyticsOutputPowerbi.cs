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
    public TerraformLiteralProperty<string>? Dataset
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataset");
        set => this.WithProperty("dataset", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_name");
        set => this.WithProperty("group_name", value);
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
    /// The stream_analytics_job_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamAnalyticsJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_id");
        set => this.WithProperty("stream_analytics_job_id", value);
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
    /// The token_user_display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TokenUserDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_user_display_name");
        set => this.WithProperty("token_user_display_name", value);
    }

    /// <summary>
    /// The token_user_principal_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TokenUserPrincipalName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_user_principal_name");
        set => this.WithProperty("token_user_principal_name", value);
    }

}
