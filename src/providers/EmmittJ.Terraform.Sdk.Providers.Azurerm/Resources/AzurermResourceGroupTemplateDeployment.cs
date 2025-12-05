using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermResourceGroupTemplateDeployment.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("debug_level");
        set => SetArgument("debug_level", value);
    }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentMode is required")]
    public required TerraformValue<string> DeploymentMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("deployment_mode");
        set => SetArgument("deployment_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters_content attribute.
    /// </summary>
    public TerraformValue<string> ParametersContent
    {
        get => GetArgument<TerraformValue<string>>("parameters_content") ?? CreateReference("parameters_content");
        set => SetArgument("parameters_content", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The template_content attribute.
    /// </summary>
    public TerraformValue<string> TemplateContent
    {
        get => GetArgument<TerraformValue<string>>("template_content") ?? CreateReference("template_content");
        set => SetArgument("template_content", value);
    }

    /// <summary>
    /// The template_spec_version_id attribute.
    /// </summary>
    public TerraformValue<string>? TemplateSpecVersionId
    {
        get => GetArgument<TerraformValue<string>>("template_spec_version_id");
        set => SetArgument("template_spec_version_id", value);
    }

    /// <summary>
    /// The output_content attribute.
    /// </summary>
    public TerraformValue<string> OutputContent
        => CreateReference("output_content");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermResourceGroupTemplateDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermResourceGroupTemplateDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
