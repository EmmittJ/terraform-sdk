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
    public TerraformProperty<string>? EndDateTime
    {
        get => GetProperty<TerraformProperty<string>>("end_date_time");
        set => this.WithProperty("end_date_time", value);
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
    /// The secret_text attribute.
    /// </summary>
    public TerraformProperty<string>? SecretText
    {
        get => GetProperty<TerraformProperty<string>>("secret_text");
        set => this.WithProperty("secret_text", value);
    }

    /// <summary>
    /// The hint attribute.
    /// </summary>
    public TerraformExpression Hint => this["hint"];

}
