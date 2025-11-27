using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_parameter_manager_parameter_version Terraform data source.
/// Retrieves information about a google_parameter_manager_parameter_version.
/// </summary>
public partial class GoogleParameterManagerParameterVersionDataSource(string name) : TerraformDataSource("google_parameter_manager_parameter_version", name)
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
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool> Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
    }

    /// <summary>
    /// The kms_key_version attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyVersion
    {
        get => new TerraformReference<string>(this, "kms_key_version");
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
    /// The update_time attribute.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

}
