using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSubscriptionTemplateDeployment.
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionTemplateDeploymentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_subscription_template_deployment Terraform resource.
/// Manages a azurerm_subscription_template_deployment resource.
/// </summary>
public partial class AzurermSubscriptionTemplateDeployment(string name) : TerraformResource("azurerm_subscription_template_deployment", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters_content attribute.
    /// </summary>
    public TerraformValue<string>? ParametersContent
    {
        get => GetArgument<TerraformValue<string>>("parameters_content");
        set => SetArgument("parameters_content", value);
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
    public TerraformValue<string>? TemplateContent
    {
        get => GetArgument<TerraformValue<string>>("template_content");
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
        => AsReference("output_content");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubscriptionTemplateDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubscriptionTemplateDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
