using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermResourceGroupTemplateDeploymentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_resource_group_template_deployment Terraform resource.
/// Manages a azurerm_resource_group_template_deployment resource.
/// </summary>
public partial class AzurermResourceGroupTemplateDeployment(string name) : TerraformResource("azurerm_resource_group_template_deployment", name)
{
    /// <summary>
    /// The debug_level attribute.
    /// </summary>
    public TerraformValue<string>? DebugLevel
    {
        get => new TerraformReference<string>(this, "debug_level");
        set => SetArgument("debug_level", value);
    }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentMode is required")]
    public required TerraformValue<string> DeploymentMode
    {
        get => new TerraformReference<string>(this, "deployment_mode");
        set => SetArgument("deployment_mode", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters_content attribute.
    /// </summary>
    public TerraformValue<string> ParametersContent
    {
        get => new TerraformReference<string>(this, "parameters_content");
        set => SetArgument("parameters_content", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The template_content attribute.
    /// </summary>
    public TerraformValue<string> TemplateContent
    {
        get => new TerraformReference<string>(this, "template_content");
        set => SetArgument("template_content", value);
    }

    /// <summary>
    /// The template_spec_version_id attribute.
    /// </summary>
    public TerraformValue<string>? TemplateSpecVersionId
    {
        get => new TerraformReference<string>(this, "template_spec_version_id");
        set => SetArgument("template_spec_version_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermResourceGroupTemplateDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermResourceGroupTemplateDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
