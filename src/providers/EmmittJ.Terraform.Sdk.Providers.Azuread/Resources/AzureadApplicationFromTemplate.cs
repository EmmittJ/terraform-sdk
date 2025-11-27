using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationFromTemplate.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationFromTemplateTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_application_from_template Terraform resource.
/// Manages a azuread_application_from_template resource.
/// </summary>
public partial class AzureadApplicationFromTemplate(string name) : TerraformResource("azuread_application_from_template", name)
{
    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The UUID of the template to instantiate for this application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    public required TerraformValue<string> TemplateId
    {
        get => new TerraformReference<string>(this, "template_id");
        set => SetArgument("template_id", value);
    }

    /// <summary>
    /// The resource ID for this application
    /// </summary>
    public TerraformValue<string> ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
    }

    /// <summary>
    /// The object ID for this application
    /// </summary>
    public TerraformValue<string> ApplicationObjectId
    {
        get => new TerraformReference<string>(this, "application_object_id");
    }

    /// <summary>
    /// The resource ID for this service principal
    /// </summary>
    public TerraformValue<string> ServicePrincipalId
    {
        get => new TerraformReference<string>(this, "service_principal_id");
    }

    /// <summary>
    /// The object ID for this service principal
    /// </summary>
    public TerraformValue<string> ServicePrincipalObjectId
    {
        get => new TerraformReference<string>(this, "service_principal_object_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationFromTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationFromTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
