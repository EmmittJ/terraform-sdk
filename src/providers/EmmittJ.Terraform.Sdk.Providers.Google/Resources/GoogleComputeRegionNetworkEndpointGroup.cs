using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine in GoogleComputeRegionNetworkEndpointGroup.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupAppEngineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_engine";

    /// <summary>
    /// Optional serving service.
    /// The service name must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;default&amp;quot;, &amp;quot;my-service&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

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
    public TerraformValue<string>? UrlMask
    {
        get => GetArgument<TerraformValue<string>>("url_mask");
        set => SetArgument("url_mask", value);
    }

    /// <summary>
    /// Optional serving version.
    /// The version must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;v1&amp;quot;, &amp;quot;v2&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for cloud_function in GoogleComputeRegionNetworkEndpointGroup.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupCloudFunctionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_function";

    /// <summary>
    /// A user-defined name of the Cloud Function.
    /// The function name is case-sensitive and must be 1-63 characters long.
    /// Example value: &amp;quot;func1&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Function
    {
        get => GetArgument<TerraformValue<string>>("function");
        set => SetArgument("function", value);
    }

    /// <summary>
    /// A template to parse function field from a request URL. URL mask allows
    /// for routing to multiple Cloud Functions without having to create
    /// multiple Network Endpoint Groups and backend services.
    /// 
    /// For example, request URLs &amp;quot;mydomain.com/function1&amp;quot; and &amp;quot;mydomain.com/function2&amp;quot;
    /// can be backed by the same Serverless NEG with URL mask &amp;quot;/&amp;quot;. The URL mask
    /// will parse them to { function = &amp;quot;function1&amp;quot; } and { function = &amp;quot;function2&amp;quot; } respectively.
    /// </summary>
    public TerraformValue<string>? UrlMask
    {
        get => GetArgument<TerraformValue<string>>("url_mask");
        set => SetArgument("url_mask", value);
    }

}


/// <summary>
/// Block type for cloud_run in GoogleComputeRegionNetworkEndpointGroup.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupCloudRunBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_run";

    /// <summary>
    /// Cloud Run service is the main resource of Cloud Run.
    /// The service must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;run-service&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Cloud Run tag represents the &amp;quot;named-revision&amp;quot; to provide
    /// additional fine-grained traffic routing information.
    /// The tag must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;revision-0010&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

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
    public TerraformValue<string>? UrlMask
    {
        get => GetArgument<TerraformValue<string>>("url_mask");
        set => SetArgument("url_mask", value);
    }

}


/// <summary>
/// Block type for psc_data in GoogleComputeRegionNetworkEndpointGroup.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupPscDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_data";

    /// <summary>
    /// The PSC producer port to use when consumer PSC NEG connects to a producer. If
    /// this flag isn&#39;t specified for a PSC NEG with endpoint type
    /// private-service-connect, then PSC NEG will be connected to a first port in the
    /// available PSC producer port range.
    /// </summary>
    public TerraformValue<string>? ProducerPort
    {
        get => GetArgument<TerraformValue<string>>("producer_port");
        set => SetArgument("producer_port", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRegionNetworkEndpointGroup.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_region_network_endpoint_group Terraform resource.
/// Manages a google_compute_region_network_endpoint_group resource.
/// </summary>
public partial class GoogleComputeRegionNetworkEndpointGroup(string name) : TerraformResource("google_compute_region_network_endpoint_group", name)
{
    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
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
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The URL of the network to which all network endpoints in the NEG belong. Uses
    /// &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network") ?? CreateReference("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Defaults to SERVERLESS. Default value: &amp;quot;SERVERLESS&amp;quot; Possible values: [&amp;quot;SERVERLESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;, &amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;, &amp;quot;GCE_VM_IP_PORTMAP&amp;quot;]
    /// </summary>
    public TerraformValue<string>? NetworkEndpointType
    {
        get => GetArgument<TerraformValue<string>>("network_endpoint_type");
        set => SetArgument("network_endpoint_type", value);
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
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The target service url used to set up private service connection to
    /// a Google API or a PSC Producer Service Attachment.
    /// </summary>
    public TerraformValue<string>? PscTargetService
    {
        get => GetArgument<TerraformValue<string>>("psc_target_service");
        set => SetArgument("psc_target_service", value);
    }

    /// <summary>
    /// A reference to the region where the regional NEGs reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => GetRequiredArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// 
    /// Optional URL of the subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// AppEngine block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngine block(s) allowed")]
    public TerraformList<GoogleComputeRegionNetworkEndpointGroupAppEngineBlock>? AppEngine
    {
        get => GetArgument<TerraformList<GoogleComputeRegionNetworkEndpointGroupAppEngineBlock>>("app_engine");
        set => SetArgument("app_engine", value);
    }

    /// <summary>
    /// CloudFunction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudFunction block(s) allowed")]
    public TerraformList<GoogleComputeRegionNetworkEndpointGroupCloudFunctionBlock>? CloudFunction
    {
        get => GetArgument<TerraformList<GoogleComputeRegionNetworkEndpointGroupCloudFunctionBlock>>("cloud_function");
        set => SetArgument("cloud_function", value);
    }

    /// <summary>
    /// CloudRun block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudRun block(s) allowed")]
    public TerraformList<GoogleComputeRegionNetworkEndpointGroupCloudRunBlock>? CloudRun
    {
        get => GetArgument<TerraformList<GoogleComputeRegionNetworkEndpointGroupCloudRunBlock>>("cloud_run");
        set => SetArgument("cloud_run", value);
    }

    /// <summary>
    /// PscData block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscData block(s) allowed")]
    public TerraformList<GoogleComputeRegionNetworkEndpointGroupPscDataBlock>? PscData
    {
        get => GetArgument<TerraformList<GoogleComputeRegionNetworkEndpointGroupPscDataBlock>>("psc_data");
        set => SetArgument("psc_data", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionNetworkEndpointGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionNetworkEndpointGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
