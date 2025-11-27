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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The query_path attribute.
    /// </summary>
    public TerraformValue<string>? QueryPath
    {
        get => new TerraformReference<string>(this, "query_path");
        set => SetArgument("query_path", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The variable_key attribute.
    /// </summary>
    public TerraformValue<string>? VariableKey
    {
        get => new TerraformReference<string>(this, "variable_key");
        set => SetArgument("variable_key", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The query_value attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> QueryValue
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "query_value").ResolveNodes(ctx));
    }

    /// <summary>
    /// The variable_value attribute.
    /// </summary>
    public TerraformValue<string> VariableValue
    {
        get => new TerraformReference<string>(this, "variable_value");
    }

}
