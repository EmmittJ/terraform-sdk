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
        this.DeclareOutput("disabled");
        this.DeclareOutput("name");
        this.DeclareOutput("parameter_data");
        this.DeclareOutput("rendered_parameter_data");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    public string? Parameter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter")?.Value;
        set => this.WithProperty("parameter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameter_version_id attribute.
    /// </summary>
    public string? ParameterVersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_version_id")?.Value;
        set => this.WithProperty("parameter_version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
