using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_network Terraform data source.
/// Retrieves information about a google_compute_network.
/// </summary>
public partial class GoogleComputeNetworkDataSource(string name) : TerraformDataSource("google_compute_network", name)
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
    /// The network_profile attribute.
    /// </summary>
    public TerraformValue<string>? NetworkProfile
    {
        get => new TerraformReference<string>(this, "network_profile");
        set => SetArgument("network_profile", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The gateway_ipv4 attribute.
    /// </summary>
    public TerraformValue<string> GatewayIpv4
    {
        get => new TerraformReference<string>(this, "gateway_ipv4");
    }

    /// <summary>
    /// The internal_ipv6_range attribute.
    /// </summary>
    public TerraformValue<string> InternalIpv6Range
    {
        get => new TerraformReference<string>(this, "internal_ipv6_range");
    }

    /// <summary>
    /// The network_id attribute.
    /// </summary>
    public TerraformValue<double> NetworkId
    {
        get => new TerraformReference<double>(this, "network_id");
    }

    /// <summary>
    /// The numeric_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> NumericId
    {
        get => new TerraformReference<string>(this, "numeric_id");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The subnetworks_self_links attribute.
    /// </summary>
    public TerraformList<string> SubnetworksSelfLinks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subnetworks_self_links").ResolveNodes(ctx));
    }

}
