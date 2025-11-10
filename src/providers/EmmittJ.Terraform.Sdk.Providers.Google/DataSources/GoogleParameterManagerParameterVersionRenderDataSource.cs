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
        this.WithOutput("disabled");
        this.WithOutput("name");
        this.WithOutput("parameter_data");
        this.WithOutput("rendered_parameter_data");
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
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    public required TerraformProperty<string> Parameter
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parameter");
        set => this.WithProperty("parameter", value);
    }

    /// <summary>
    /// The parameter_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    public required TerraformProperty<string> ParameterVersionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parameter_version_id");
        set => this.WithProperty("parameter_version_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
