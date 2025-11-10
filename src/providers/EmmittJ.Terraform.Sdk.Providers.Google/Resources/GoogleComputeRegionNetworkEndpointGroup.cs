using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupAppEngineBlock : TerraformBlock
{
    /// <summary>
    /// Optional serving service.
    /// The service name must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;default&amp;quot;, &amp;quot;my-service&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        set => SetProperty("service", value);
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
    public TerraformProperty<string>? UrlMask
    {
        set => SetProperty("url_mask", value);
    }

    /// <summary>
    /// Optional serving version.
    /// The version must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;v1&amp;quot;, &amp;quot;v2&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for cloud_function in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupCloudFunctionBlock : TerraformBlock
{
    /// <summary>
    /// A user-defined name of the Cloud Function.
    /// The function name is case-sensitive and must be 1-63 characters long.
    /// Example value: &amp;quot;func1&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Function
    {
        set => SetProperty("function", value);
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
    public TerraformProperty<string>? UrlMask
    {
        set => SetProperty("url_mask", value);
    }

}

/// <summary>
/// Block type for cloud_run in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupCloudRunBlock : TerraformBlock
{
    /// <summary>
    /// Cloud Run service is the main resource of Cloud Run.
    /// The service must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;run-service&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        set => SetProperty("service", value);
    }

    /// <summary>
    /// Cloud Run tag represents the &amp;quot;named-revision&amp;quot; to provide
    /// additional fine-grained traffic routing information.
    /// The tag must be 1-63 characters long, and comply with RFC1035.
    /// Example value: &amp;quot;revision-0010&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        set => SetProperty("tag", value);
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
    public TerraformProperty<string>? UrlMask
    {
        set => SetProperty("url_mask", value);
    }

}

/// <summary>
/// Block type for psc_data in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupPscDataBlock : TerraformBlock
{
    /// <summary>
    /// The PSC producer port to use when consumer PSC NEG connects to a producer. If
    /// this flag isn&#39;t specified for a PSC NEG with endpoint type
    /// private-service-connect, then PSC NEG will be connected to a first port in the
    /// available PSC producer port range.
    /// </summary>
    public TerraformProperty<string>? ProducerPort
    {
        set => SetProperty("producer_port", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_compute_region_network_endpoint_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRegionNetworkEndpointGroup : TerraformResource
{
    public GoogleComputeRegionNetworkEndpointGroup(string name) : base("google_compute_region_network_endpoint_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("self_link");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("network");
        SetOutput("network_endpoint_type");
        SetOutput("project");
        SetOutput("psc_target_service");
        SetOutput("region");
        SetOutput("subnetwork");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The URL of the network to which all network endpoints in the NEG belong. Uses
    /// &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    public TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Defaults to SERVERLESS. Default value: &amp;quot;SERVERLESS&amp;quot; Possible values: [&amp;quot;SERVERLESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;, &amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;, &amp;quot;GCE_VM_IP_PORTMAP&amp;quot;]
    /// </summary>
    public TerraformProperty<string> NetworkEndpointType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_endpoint_type");
        set => SetProperty("network_endpoint_type", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The target service url used to set up private service connection to
    /// a Google API or a PSC Producer Service Attachment.
    /// </summary>
    public TerraformProperty<string> PscTargetService
    {
        get => GetRequiredOutput<TerraformProperty<string>>("psc_target_service");
        set => SetProperty("psc_target_service", value);
    }

    /// <summary>
    /// A reference to the region where the regional NEGs reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// 
    /// Optional URL of the subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    public TerraformProperty<string> Subnetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnetwork");
        set => SetProperty("subnetwork", value);
    }

    /// <summary>
    /// Block for app_engine.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngine block(s) allowed")]
    public List<GoogleComputeRegionNetworkEndpointGroupAppEngineBlock>? AppEngine
    {
        set => SetProperty("app_engine", value);
    }

    /// <summary>
    /// Block for cloud_function.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudFunction block(s) allowed")]
    public List<GoogleComputeRegionNetworkEndpointGroupCloudFunctionBlock>? CloudFunction
    {
        set => SetProperty("cloud_function", value);
    }

    /// <summary>
    /// Block for cloud_run.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudRun block(s) allowed")]
    public List<GoogleComputeRegionNetworkEndpointGroupCloudRunBlock>? CloudRun
    {
        set => SetProperty("cloud_run", value);
    }

    /// <summary>
    /// Block for psc_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscData block(s) allowed")]
    public List<GoogleComputeRegionNetworkEndpointGroupPscDataBlock>? PscData
    {
        set => SetProperty("psc_data", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRegionNetworkEndpointGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
