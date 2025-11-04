using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_nginx_api_key resource.
/// </summary>
public class AzurermNginxApiKey : TerraformResource
{
    public AzurermNginxApiKey(string name) : base("azurerm_nginx_api_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("hint");
    }

    /// <summary>
    /// The end_date_time attribute.
    /// </summary>
    public string? EndDateTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_date_time")?.Value;
        set => this.WithProperty("end_date_time", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The nginx_deployment_id attribute.
    /// </summary>
    public string? NginxDeploymentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nginx_deployment_id")?.Value;
        set => this.WithProperty("nginx_deployment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret_text attribute.
    /// </summary>
    public string? SecretText
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_text")?.Value;
        set => this.WithProperty("secret_text", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hint attribute.
    /// </summary>
    public TerraformExpression Hint => this["hint"];

}
