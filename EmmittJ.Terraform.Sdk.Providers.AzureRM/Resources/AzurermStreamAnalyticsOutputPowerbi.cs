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
    public string? Dataset
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataset")?.Value;
        set => this.WithProperty("dataset", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public string? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id")?.Value;
        set => this.WithProperty("group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public string? GroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_name")?.Value;
        set => this.WithProperty("group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The stream_analytics_job_id attribute.
    /// </summary>
    public string? StreamAnalyticsJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_id")?.Value;
        set => this.WithProperty("stream_analytics_job_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The token_user_display_name attribute.
    /// </summary>
    public string? TokenUserDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_user_display_name")?.Value;
        set => this.WithProperty("token_user_display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The token_user_principal_name attribute.
    /// </summary>
    public string? TokenUserPrincipalName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_user_principal_name")?.Value;
        set => this.WithProperty("token_user_principal_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
