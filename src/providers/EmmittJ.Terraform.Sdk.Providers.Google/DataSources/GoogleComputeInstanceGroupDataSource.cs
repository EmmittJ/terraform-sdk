using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_instance_group Terraform data source.
/// Retrieves information about a google_compute_instance_group.
/// </summary>
public partial class GoogleComputeInstanceGroupDataSource(string name) : TerraformDataSource("google_compute_instance_group", name)
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
    public TerraformValue<string>? Name
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
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string>? SelfLink
    {
        get => GetArgument<TerraformValue<string>>("self_link");
        set => SetArgument("self_link", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformSet<string> Instances
        => AsReference("instances");

    /// <summary>
    /// The named_port attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NamedPort
        => AsReference("named_port");

    /// <summary>
    /// The network attribute.
    /// </summary>
    public TerraformValue<string> Network
        => AsReference("network");

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<double> Size
        => AsReference("size");

}
