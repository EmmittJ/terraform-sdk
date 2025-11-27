using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleCloudIdsEndpoint.
/// Nesting mode: single
/// </summary>
public class GoogleCloudIdsEndpointTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_cloud_ids_endpoint Terraform resource.
/// Manages a google_cloud_ids_endpoint resource.
/// </summary>
public partial class GoogleCloudIdsEndpoint(string name) : TerraformResource("google_cloud_ids_endpoint", name)
{
    /// <summary>
    /// An optional description of the endpoint.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The location for the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the endpoint in the format projects/{project_id}/locations/{locationId}/endpoints/{endpointId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Name of the VPC network that is connected to the IDS endpoint. This can either contain the VPC network name itself (like &amp;quot;src-net&amp;quot;) or the full URL to the network (like &amp;quot;projects/{project_id}/global/networks/src-net&amp;quot;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
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
    /// The minimum alert severity level that is reported by the endpoint. Possible values: [&amp;quot;INFORMATIONAL&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;CRITICAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformValue<string> Severity
    {
        get => new TerraformReference<string>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// Configuration for threat IDs excluded from generating alerts. Limit: 99 IDs.
    /// </summary>
    public TerraformList<string>? ThreatExceptions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "threat_exceptions").ResolveNodes(ctx));
        set => SetArgument("threat_exceptions", value);
    }

    /// <summary>
    /// Creation timestamp in RFC 3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// URL of the endpoint&#39;s network address to which traffic is to be sent by Packet Mirroring.
    /// </summary>
    public TerraformValue<string> EndpointForwardingRule
    {
        get => new TerraformReference<string>(this, "endpoint_forwarding_rule");
    }

    /// <summary>
    /// Internal IP address of the endpoint&#39;s network entry point.
    /// </summary>
    public TerraformValue<string> EndpointIp
    {
        get => new TerraformReference<string>(this, "endpoint_ip");
    }

    /// <summary>
    /// Last update timestamp in RFC 3339 text format.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudIdsEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudIdsEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
