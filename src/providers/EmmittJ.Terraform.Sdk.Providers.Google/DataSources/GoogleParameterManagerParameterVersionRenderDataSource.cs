using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_parameter_version_render.
/// </summary>
public class GoogleParameterManagerParameterVersionRenderDataSource : TerraformDataSource
{
    public GoogleParameterManagerParameterVersionRenderDataSource(string name) : base("google_parameter_manager_parameter_version_render", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("disabled");
        SetOutput("name");
        SetOutput("parameter_data");
        SetOutput("rendered_parameter_data");
        SetOutput("id");
        SetOutput("parameter");
        SetOutput("parameter_version_id");
        SetOutput("project");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    public required TerraformProperty<string> Parameter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter");
        set => SetProperty("parameter", value);
    }

    /// <summary>
    /// The parameter_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    public required TerraformProperty<string> ParameterVersionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_version_id");
        set => SetProperty("parameter_version_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformExpression Disabled => this["disabled"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The parameter_data attribute.
    /// </summary>
    public TerraformExpression ParameterData => this["parameter_data"];

    /// <summary>
    /// The rendered_parameter_data attribute.
    /// </summary>
    public TerraformExpression RenderedParameterData => this["rendered_parameter_data"];

}
