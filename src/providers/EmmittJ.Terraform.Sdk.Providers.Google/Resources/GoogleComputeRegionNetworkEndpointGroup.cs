using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionNetworkEndpointGroupAppEngineBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional serving service.
    /// The service name must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;default&amp;quot;, &amp;quot;my-service&amp;quot;.
    /// </summary>
    [TerraformProperty("service")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Service { get; set; }

    /// <summary>
    /// A template to parse service and version fields from a request URL.
    /// URL mask allows for routing to multiple App Engine services without
    /// having to create multiple Network Endpoint Groups and backend services.
    /// 
    /// For example, the request URLs &amp;quot;foo1-dot-appname.appspot.com/v1&amp;quot; and
    /// &amp;quot;foo1-dot-appname.appspot.com/v2&amp;quot; can be backed by the same Serverless NEG with
    /// URL mask &amp;quot;-dot-appname.appspot.com/&amp;quot;. The URL mask will parse
    /// them to { service = &amp;quot;foo1&amp;quot;, version = &amp;quot;v1&amp;quot; } and { service = &amp;quot;foo1&amp;quot;, version = &amp;quot;v2&amp;quot; } respectively.
    /// </summary>
    [TerraformProperty("url_mask")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UrlMask { get; set; }

    /// <summary>
    /// Optional serving version.
    /// The version must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;v1&amp;quot;, &amp;quot;v2&amp;quot;.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for cloud_function in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionNetworkEndpointGroupCloudFunctionBlock : TerraformBlockBase
{
    /// <summary>
    /// A user-defined name of the Cloud Function.
    /// The function name is case-sensitive and must be 1-63 characters long.
    /// Example value: &amp;quot;func1&amp;quot;.
    /// </summary>
    [TerraformProperty("function")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Function { get; set; }

    /// <summary>
    /// A template to parse function field from a request URL. URL mask allows
    /// for routing to multiple Cloud Functions without having to create
    /// multiple Network Endpoint Groups and backend services.
    /// 
    /// For example, request URLs &amp;quot;mydomain.com/function1&amp;quot; and &amp;quot;mydomain.com/function2&amp;quot;
    /// can be backed by the same Serverless NEG with URL mask &amp;quot;/&amp;quot;. The URL mask
    /// will parse them to { function = &amp;quot;function1&amp;quot; } and { function = &amp;quot;function2&amp;quot; } respectively.
    /// </summary>
    [TerraformProperty("url_mask")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UrlMask { get; set; }

}

/// <summary>
/// Block type for cloud_run in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionNetworkEndpointGroupCloudRunBlock : TerraformBlockBase
{
    /// <summary>
    /// Cloud Run service is the main resource of Cloud Run.
    /// The service must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;run-service&amp;quot;.
    /// </summary>
    [TerraformProperty("service")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Service { get; set; }

    /// <summary>
    /// Cloud Run tag represents the &amp;quot;named-revision&amp;quot; to provide
    /// additional fine-grained traffic routing information.
    /// The tag must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;revision-0010&amp;quot;.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Tag { get; set; }

    /// <summary>
    /// A template to parse service and tag fields from a request URL.
    /// URL mask allows for routing to multiple Run services without having
    /// to create multiple network endpoint groups and backend services.
    /// 
    /// For example, request URLs &amp;quot;foo1.domain.com/bar1&amp;quot; and &amp;quot;foo1.domain.com/bar2&amp;quot;
    /// an be backed by the same Serverless Network Endpoint Group (NEG) with
    /// URL mask &amp;quot;.domain.com/&amp;quot;. The URL mask will parse them to { service=&amp;quot;bar1&amp;quot;, tag=&amp;quot;foo1&amp;quot; }
    /// and { service=&amp;quot;bar2&amp;quot;, tag=&amp;quot;foo2&amp;quot; } respectively.
    /// </summary>
    [TerraformProperty("url_mask")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UrlMask { get; set; }

}

/// <summary>
/// Block type for psc_data in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionNetworkEndpointGroupPscDataBlock : TerraformBlockBase
{
    /// <summary>
    /// The PSC producer port to use when consumer PSC NEG connects to a producer. If
    /// this flag isn&#39;t specified for a PSC NEG with endpoint type
    /// private-service-connect, then PSC NEG will be connected to a first port in the
    /// available PSC producer port range.
    /// </summary>
    [TerraformProperty("producer_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProducerPort { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRegionNetworkEndpointGroupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_region_network_endpoint_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeRegionNetworkEndpointGroup : TerraformResource
{
    public GoogleComputeRegionNetworkEndpointGroup(string name) : base("google_compute_region_network_endpoint_group", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The URL of the network to which all network endpoints in the NEG belong. Uses
    /// &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    [TerraformProperty("network")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Network { get; set; }

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Defaults to SERVERLESS. Default value: &amp;quot;SERVERLESS&amp;quot; Possible values: [&amp;quot;SERVERLESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;, &amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;, &amp;quot;GCE_VM_IP_PORTMAP&amp;quot;]
    /// </summary>
    [TerraformProperty("network_endpoint_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkEndpointType { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The target service url used to set up private service connection to
    /// a Google API or a PSC Producer Service Attachment.
    /// </summary>
    [TerraformProperty("psc_target_service")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PscTargetService { get; set; }

    /// <summary>
    /// A reference to the region where the regional NEGs reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Region { get; set; }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// 
    /// Optional URL of the subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Subnetwork { get; set; }

    /// <summary>
    /// Block for app_engine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngine block(s) allowed")]
    [TerraformProperty("app_engine")]
    public TerraformList<TerraformBlock<GoogleComputeRegionNetworkEndpointGroupAppEngineBlock>>? AppEngine { get; set; }

    /// <summary>
    /// Block for cloud_function.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudFunction block(s) allowed")]
    [TerraformProperty("cloud_function")]
    public TerraformList<TerraformBlock<GoogleComputeRegionNetworkEndpointGroupCloudFunctionBlock>>? CloudFunction { get; set; }

    /// <summary>
    /// Block for cloud_run.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudRun block(s) allowed")]
    [TerraformProperty("cloud_run")]
    public TerraformList<TerraformBlock<GoogleComputeRegionNetworkEndpointGroupCloudRunBlock>>? CloudRun { get; set; }

    /// <summary>
    /// Block for psc_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscData block(s) allowed")]
    [TerraformProperty("psc_data")]
    public TerraformList<TerraformBlock<GoogleComputeRegionNetworkEndpointGroupPscDataBlock>>? PscData { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeRegionNetworkEndpointGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

}
