using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudActiveDeployment.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudActiveDeploymentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_spring_cloud_active_deployment Terraform resource.
/// Manages a azurerm_spring_cloud_active_deployment resource.
/// </summary>
public partial class AzurermSpringCloudActiveDeployment(string name) : TerraformResource("azurerm_spring_cloud_active_deployment", name)
{
    /// <summary>
    /// The deployment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentName is required")]
    public required TerraformValue<string> DeploymentName
    {
        get => new TerraformReference<string>(this, "deployment_name");
        set => SetArgument("deployment_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformValue<string> SpringCloudAppId
    {
        get => new TerraformReference<string>(this, "spring_cloud_app_id");
        set => SetArgument("spring_cloud_app_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudActiveDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudActiveDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
