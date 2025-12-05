using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for external_ip in GoogleVmwareengineNetworkPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineNetworkPolicyExternalIpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_ip";

    /// <summary>
    /// True if the service is enabled; false otherwise.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// State of the service. New values may be added to this enum when appropriate.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

}


/// <summary>
/// Block type for internet_access in GoogleVmwareengineNetworkPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineNetworkPolicyInternetAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "internet_access";

    /// <summary>
    /// True if the service is enabled; false otherwise.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// State of the service. New values may be added to this enum when appropriate.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

}


/// <summary>
/// Block type for timeouts in GoogleVmwareengineNetworkPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineNetworkPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_vmwareengine_network_policy Terraform resource.
/// Manages a google_vmwareengine_network_policy resource.
/// </summary>
public partial class GoogleVmwareengineNetworkPolicy(string name) : TerraformResource("google_vmwareengine_network_policy", name)
{
    /// <summary>
    /// User-provided description for this network policy.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// IP address range in CIDR notation used to create internet access and external IP access.
    /// An RFC 1918 CIDR block, with a &amp;quot;/26&amp;quot; prefix, is required. The range cannot overlap with any
    /// prefixes either in the consumer VPC network or in use by the private clouds attached to that VPC network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EdgeServicesCidr is required")]
    public required TerraformValue<string> EdgeServicesCidr
    {
        get => GetRequiredArgument<TerraformValue<string>>("edge_services_cidr");
        set => SetArgument("edge_services_cidr", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource name of the location (region) to create the new network policy in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the Network Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareEngineNetwork is required")]
    public required TerraformValue<string> VmwareEngineNetwork
    {
        get => GetRequiredArgument<TerraformValue<string>>("vmware_engine_network");
        set => SetArgument("vmware_engine_network", value);
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// The canonical name of the VMware Engine network in the form:
    /// projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    public TerraformValue<string> VmwareEngineNetworkCanonical
        => CreateReference("vmware_engine_network_canonical");

    /// <summary>
    /// ExternalIp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalIp block(s) allowed")]
    public TerraformList<GoogleVmwareengineNetworkPolicyExternalIpBlock>? ExternalIp
    {
        get => GetArgument<TerraformList<GoogleVmwareengineNetworkPolicyExternalIpBlock>>("external_ip");
        set => SetArgument("external_ip", value);
    }

    /// <summary>
    /// InternetAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InternetAccess block(s) allowed")]
    public TerraformList<GoogleVmwareengineNetworkPolicyInternetAccessBlock>? InternetAccess
    {
        get => GetArgument<TerraformList<GoogleVmwareengineNetworkPolicyInternetAccessBlock>>("internet_access");
        set => SetArgument("internet_access", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVmwareengineNetworkPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVmwareengineNetworkPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
