using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkConnectivityRegionalEndpoint.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityRegionalEndpointTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_connectivity_regional_endpoint Terraform resource.
/// Manages a google_network_connectivity_regional_endpoint resource.
/// </summary>
public partial class GoogleNetworkConnectivityRegionalEndpoint(string name) : TerraformResource("google_network_connectivity_regional_endpoint", name)
{
    /// <summary>
    /// The access type of this regional endpoint. This field is reflected in the PSC Forwarding Rule configuration to enable global access. Possible values: [&amp;quot;GLOBAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessType is required")]
    public required TerraformValue<string> AccessType
    {
        get => GetRequiredArgument<TerraformValue<string>>("access_type");
        set => SetArgument("access_type", value);
    }

    /// <summary>
    /// The IP Address of the Regional Endpoint. When no address is provided, an IP from the subnetwork is allocated. Use one of the following formats: * IPv4 address as in &#39;10.0.0.1&#39; * Address resource URI as in &#39;projects/{project}/regions/{region}/addresses/{address_name}&#39;
    /// 
    /// ~&amp;gt; **Note:** This field accepts both a reference to a Compute Address resource, which is the resource name of which format is given in the description, and IP literal value. If the user chooses to input a reserved address value; they need to make sure that the reserved address is in IPv4 version, its purpose is GCE_ENDPOINT, its type is INTERNAL and its status is RESERVED. If the user chooses to input an IP literal, they need to make sure that it&#39;s a valid IPv4 address (x.x.x.x) within the subnetwork.
    /// </summary>
    public TerraformValue<string> Address
    {
        get => GetArgument<TerraformValue<string>>("address") ?? CreateReference("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// A description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the RegionalEndpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the RegionalEndpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of the VPC network for this private regional endpoint. Format: &#39;projects/{project}/global/networks/{network}&#39;
    /// </summary>
    public TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network") ?? CreateReference("network");
        set => SetArgument("network", value);
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
    /// The name of the subnetwork from which the IP address will be allocated. Format: &#39;projects/{project}/regions/{region}/subnetworks/{subnetwork}&#39;
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork") ?? CreateReference("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The service endpoint this private regional endpoint connects to. Format: &#39;{apiname}.{region}.rep.googleapis.com&#39; Example: \&amp;quot;cloudkms.us-central1.rep.googleapis.com\&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGoogleApi is required")]
    public required TerraformValue<string> TargetGoogleApi
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_google_api");
        set => SetArgument("target_google_api", value);
    }

    /// <summary>
    /// Time when the RegionalEndpoint was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The resource reference of the PSC Forwarding Rule created on behalf of the customer. Format: &#39;//compute.googleapis.com/projects/{project}/regions/{region}/forwardingRules/{forwarding_rule_name}&#39;
    /// </summary>
    public TerraformValue<string> PscForwardingRule
        => CreateReference("psc_forwarding_rule");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Time when the RegionalEndpoint was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkConnectivityRegionalEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkConnectivityRegionalEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
