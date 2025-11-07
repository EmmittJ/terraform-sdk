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
    /// The nginx_deployment_id attribute.
    /// </summary>
    public TerraformProperty<string>? NginxDeploymentId
    {
        get => GetProperty<TerraformProperty<string>>("nginx_deployment_id");
        set => this.WithProperty("nginx_deployment_id", value);
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
