using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudActiveDeploymentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentName is required")]
    public required TerraformProperty<string> DeploymentName
    {
        get => GetProperty<TerraformProperty<string>>("deployment_name");
        set => this.WithProperty("deployment_name", value);
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
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformProperty<string> SpringCloudAppId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudActiveDeploymentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudActiveDeploymentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
