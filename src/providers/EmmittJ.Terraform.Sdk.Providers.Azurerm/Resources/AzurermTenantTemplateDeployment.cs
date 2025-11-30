using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermTenantTemplateDeployment.
/// Nesting mode: single
/// </summary>
public class AzurermTenantTemplateDeploymentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_tenant_template_deployment Terraform resource.
/// Manages a azurerm_tenant_template_deployment resource.
/// </summary>
public partial class AzurermTenantTemplateDeployment(string name) : TerraformResource("azurerm_tenant_template_deployment", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The output_content attribute.
    /// </summary>
    public TerraformValue<string> OutputContent
    {
        get => new TerraformReference<string>(this, "output_content");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermTenantTemplateDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermTenantTemplateDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
