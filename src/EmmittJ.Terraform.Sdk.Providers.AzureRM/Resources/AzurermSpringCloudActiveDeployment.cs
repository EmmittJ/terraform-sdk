using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_active_deployment resource.
/// </summary>
public class AzurermSpringCloudActiveDeployment : TerraformResource
{
    public AzurermSpringCloudActiveDeployment(string name) : base("azurerm_spring_cloud_active_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The deployment_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeploymentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_name");
        set => this.WithProperty("deployment_name", value);
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
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpringCloudAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

}
