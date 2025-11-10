using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_parameter_version.
/// </summary>
public class GoogleParameterManagerParameterVersionDataSource : TerraformDataSource
{
    public GoogleParameterManagerParameterVersionDataSource(string name) : base("google_parameter_manager_parameter_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("disabled");
        this.DeclareOutput("kms_key_version");
        this.DeclareOutput("name");
        this.DeclareOutput("parameter_data");
        this.DeclareOutput("update_time");
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
        get => GetProperty<TerraformProperty<string>>("parameter");
        set => this.WithProperty("parameter", value);
    }

    /// <summary>
    /// The parameter_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    public required TerraformProperty<string> ParameterVersionId
    {
        get => GetProperty<TerraformProperty<string>>("parameter_version_id");
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
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformExpression Disabled => this["disabled"];

    /// <summary>
    /// The kms_key_version attribute.
    /// </summary>
    public TerraformExpression KmsKeyVersion => this["kms_key_version"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The parameter_data attribute.
    /// </summary>
    public TerraformExpression ParameterData => this["parameter_data"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
