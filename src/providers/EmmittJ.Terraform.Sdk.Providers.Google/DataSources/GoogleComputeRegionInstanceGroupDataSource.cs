using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_region_instance_group Terraform data source.
/// Retrieves information about a google_compute_region_instance_group.
/// </summary>
public partial class GoogleComputeRegionInstanceGroupDataSource(string name) : TerraformDataSource("google_compute_region_instance_group", name)
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
    public TerraformValue<string> Name
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
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
        set => SetArgument("self_link", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Instances
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "instances").ResolveNodes(ctx));
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
    }

}
