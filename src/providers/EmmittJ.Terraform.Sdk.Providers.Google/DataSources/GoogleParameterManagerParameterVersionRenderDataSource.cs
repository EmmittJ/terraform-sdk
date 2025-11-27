using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_parameter_manager_parameter_version_render Terraform data source.
/// Retrieves information about a google_parameter_manager_parameter_version_render.
/// </summary>
public partial class GoogleParameterManagerParameterVersionRenderDataSource(string name) : TerraformDataSource("google_parameter_manager_parameter_version_render", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    public required TerraformValue<string> Parameter
    {
        get => new TerraformReference<string>(this, "parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The parameter_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    public required TerraformValue<string> ParameterVersionId
    {
        get => new TerraformReference<string>(this, "parameter_version_id");
        set => SetArgument("parameter_version_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool> Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The parameter_data attribute.
    /// </summary>
    public TerraformValue<string> ParameterData
    {
        get => new TerraformReference<string>(this, "parameter_data");
    }

    /// <summary>
    /// The rendered_parameter_data attribute.
    /// </summary>
    public TerraformValue<string> RenderedParameterData
    {
        get => new TerraformReference<string>(this, "rendered_parameter_data");
    }

}
