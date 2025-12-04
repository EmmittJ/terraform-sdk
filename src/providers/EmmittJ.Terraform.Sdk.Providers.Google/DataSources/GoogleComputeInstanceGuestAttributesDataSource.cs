using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_instance_guest_attributes Terraform data source.
/// Retrieves information about a google_compute_instance_guest_attributes.
/// </summary>
public partial class GoogleComputeInstanceGuestAttributesDataSource(string name) : TerraformDataSource("google_compute_instance_guest_attributes", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The query_path attribute.
    /// </summary>
    public TerraformValue<string>? QueryPath
    {
        get => GetArgument<TerraformValue<string>>("query_path");
        set => SetArgument("query_path", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The variable_key attribute.
    /// </summary>
    public TerraformValue<string>? VariableKey
    {
        get => GetArgument<TerraformValue<string>>("variable_key");
        set => SetArgument("variable_key", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The query_value attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> QueryValue
        => AsReference("query_value");

    /// <summary>
    /// The variable_value attribute.
    /// </summary>
    public TerraformValue<string> VariableValue
        => AsReference("variable_value");

}
