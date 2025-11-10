using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_regional_parameter_version.
/// </summary>
public class GoogleParameterManagerRegionalParameterVersionDataSource : TerraformDataSource
{
    public GoogleParameterManagerRegionalParameterVersionDataSource(string name) : base("google_parameter_manager_regional_parameter_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("disabled");
        SetOutput("kms_key_version");
        SetOutput("name");
        SetOutput("parameter_data");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("location");
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
