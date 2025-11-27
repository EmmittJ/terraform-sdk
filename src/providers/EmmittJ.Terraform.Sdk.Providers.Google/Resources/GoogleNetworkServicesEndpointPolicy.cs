using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint_matcher in GoogleNetworkServicesEndpointPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEndpointPolicyEndpointMatcherBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_matcher";

    /// <summary>
    /// MetadataLabelMatcher block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataLabelMatcher is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetadataLabelMatcher block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataLabelMatcher block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesEndpointPolicyEndpointMatcherBlockMetadataLabelMatcherBlock> MetadataLabelMatcher
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesEndpointPolicyEndpointMatcherBlockMetadataLabelMatcherBlock>>("metadata_label_matcher");
        set => SetArgument("metadata_label_matcher", value);
    }

}

/// <summary>
/// Block type for metadata_label_matcher in GoogleNetworkServicesEndpointPolicyEndpointMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEndpointPolicyEndpointMatcherBlockMetadataLabelMatcherBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_label_matcher";

    /// <summary>
    /// Specifies how matching should be done. Possible values: [&amp;quot;MATCH_ANY&amp;quot;, &amp;quot;MATCH_ALL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataLabelMatchCriteria is required")]
    public required TerraformValue<string> MetadataLabelMatchCriteria
    {
        get => new TerraformReference<string>(this, "metadata_label_match_criteria");
        set => SetArgument("metadata_label_match_criteria", value);
    }

    /// <summary>
    /// MetadataLabels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkServicesEndpointPolicyEndpointMatcherBlockMetadataLabelMatcherBlockMetadataLabelsBlock>? MetadataLabels
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEndpointPolicyEndpointMatcherBlockMetadataLabelMatcherBlockMetadataLabelsBlock>>("metadata_labels");
        set => SetArgument("metadata_labels", value);
    }

}

/// <summary>
/// Block type for metadata_labels in GoogleNetworkServicesEndpointPolicyEndpointMatcherBlockMetadataLabelMatcherBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEndpointPolicyEndpointMatcherBlockMetadataLabelMatcherBlockMetadataLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_labels";

    /// <summary>
    /// Required. Label name presented as key in xDS Node Metadata.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabelName is required")]
    public required TerraformValue<string> LabelName
    {
        get => new TerraformReference<string>(this, "label_name");
        set => SetArgument("label_name", value);
    }

    /// <summary>
    /// Required. Label value presented as value corresponding to the above key, in xDS Node Metadata.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabelValue is required")]
    public required TerraformValue<string> LabelValue
    {
        get => new TerraformReference<string>(this, "label_value");
        set => SetArgument("label_value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkServicesEndpointPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesEndpointPolicyTimeoutsBlock : TerraformBlock
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
/// Block type for traffic_port_selector in GoogleNetworkServicesEndpointPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEndpointPolicyTrafficPortSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_port_selector";

    /// <summary>
    /// List of ports. Can be port numbers or port range (example, [80-90] specifies all ports from 80 to 90, including 80 and 90) or named ports or * to specify all ports. If the list is empty, all ports are selected.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ports is required")]
    public TerraformList<string>? Ports
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ports").ResolveNodes(ctx));
        set => SetArgument("ports", value);
    }

}


/// <summary>
/// Represents a google_network_services_endpoint_policy Terraform resource.
/// Manages a google_network_services_endpoint_policy resource.
/// </summary>
public partial class GoogleNetworkServicesEndpointPolicy(string name) : TerraformResource("google_network_services_endpoint_policy", name)
{
    /// <summary>
    /// This field specifies the URL of AuthorizationPolicy resource that applies authorization policies to the inbound traffic at the matched endpoints.
    /// </summary>
    public TerraformValue<string>? AuthorizationPolicy
    {
        get => new TerraformReference<string>(this, "authorization_policy");
        set => SetArgument("authorization_policy", value);
    }

    /// <summary>
    /// A URL referring to a ClientTlsPolicy resource. ClientTlsPolicy can be set to specify the authentication for traffic from the proxy to the actual endpoints.
    /// </summary>
    public TerraformValue<string>? ClientTlsPolicy
    {
        get => new TerraformReference<string>(this, "client_tls_policy");
        set => SetArgument("client_tls_policy", value);
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
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
    /// Set of label tags associated with the TcpRoute resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Name of the EndpointPolicy resource.
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
    /// A URL referring to ServerTlsPolicy resource. ServerTlsPolicy is used to determine the authentication policy to be applied to terminate the inbound traffic at the identified backends.
    /// </summary>
    public TerraformValue<string>? ServerTlsPolicy
    {
        get => new TerraformReference<string>(this, "server_tls_policy");
        set => SetArgument("server_tls_policy", value);
    }

    /// <summary>
    /// The type of endpoint policy. This is primarily used to validate the configuration. Possible values: [&amp;quot;SIDECAR_PROXY&amp;quot;, &amp;quot;GRPC_SERVER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Time the TcpRoute was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Time the TcpRoute was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// EndpointMatcher block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointMatcher is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EndpointMatcher block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointMatcher block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesEndpointPolicyEndpointMatcherBlock> EndpointMatcher
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesEndpointPolicyEndpointMatcherBlock>>("endpoint_matcher");
        set => SetArgument("endpoint_matcher", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesEndpointPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesEndpointPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TrafficPortSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficPortSelector block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEndpointPolicyTrafficPortSelectorBlock>? TrafficPortSelector
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEndpointPolicyTrafficPortSelectorBlock>>("traffic_port_selector");
        set => SetArgument("traffic_port_selector", value);
    }

}
