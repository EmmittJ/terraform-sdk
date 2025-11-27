using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_machine_types Terraform data source.
/// Retrieves information about a google_compute_machine_types.
/// </summary>
public partial class GoogleComputeMachineTypesDataSource(string name) : TerraformDataSource("google_compute_machine_types", name)
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Project ID for this request.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the zone for this request.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The list of machine types
    /// </summary>
    public TerraformList<TerraformMap<object>> MachineTypes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "machine_types").ResolveNodes(ctx));
    }

}
