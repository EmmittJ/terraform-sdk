using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_parameter_manager_regional_parameter_version_render Terraform data source.
/// Retrieves information about a google_parameter_manager_regional_parameter_version_render.
/// </summary>
public partial class GoogleParameterManagerRegionalParameterVersionRenderDataSource(string name) : TerraformDataSource("google_parameter_manager_regional_parameter_version_render", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location") ?? AsReference("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    public required TerraformValue<string> Parameter
    {
        get => GetRequiredArgument<TerraformValue<string>>("parameter");
        set => SetArgument("parameter", value);
    }

    /// <summary>
    /// The parameter_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    public required TerraformValue<string> ParameterVersionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("parameter_version_id");
        set => SetArgument("parameter_version_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool> Disabled
        => AsReference("disabled");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The parameter_data attribute.
    /// </summary>
    public TerraformValue<string> ParameterData
        => AsReference("parameter_data");

    /// <summary>
    /// The rendered_parameter_data attribute.
    /// </summary>
    public TerraformValue<string> RenderedParameterData
        => AsReference("rendered_parameter_data");

}
