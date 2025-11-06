using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_nginx_api_key.
/// </summary>
public class AzurermNginxApiKeyDataSource : TerraformDataSource
{
    public AzurermNginxApiKeyDataSource(string name) : base("azurerm_nginx_api_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("end_date_time");
        this.DeclareOutput("hint");
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
    /// The end_date_time attribute.
    /// </summary>
    public TerraformExpression EndDateTime => this["end_date_time"];

    /// <summary>
    /// The hint attribute.
    /// </summary>
    public TerraformExpression Hint => this["hint"];

}
