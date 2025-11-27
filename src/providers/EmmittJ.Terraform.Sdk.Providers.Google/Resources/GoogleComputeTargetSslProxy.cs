using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeTargetSslProxy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetSslProxyTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_target_ssl_proxy Terraform resource.
/// Manages a google_compute_target_ssl_proxy resource.
/// </summary>
public partial class GoogleComputeTargetSslProxy(string name) : TerraformResource("google_compute_target_ssl_proxy", name)
{
    /// <summary>
    /// A reference to the BackendService resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    public required TerraformValue<string> BackendService
    {
        get => new TerraformReference<string>(this, "backend_service");
        set => SetArgument("backend_service", value);
    }

    /// <summary>
    /// A reference to the CertificateMap resource uri that identifies a certificate map
    /// associated with the given target proxy. This field can only be set for global target proxies.
    /// Accepted format is &#39;//certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificateMaps/{resourceName}&#39;.
    /// </summary>
    public TerraformValue<string>? CertificateMap
    {
        get => new TerraformReference<string>(this, "certificate_map");
        set => SetArgument("certificate_map", value);
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// Name of the resource. Provided by the client when the resource is
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
    /// Specifies the type of proxy header to append before sending data to
    /// the backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => new TerraformReference<string>(this, "proxy_header");
        set => SetArgument("proxy_header", value);
    }

    /// <summary>
    /// A list of SslCertificate resources that are used to authenticate
    /// connections between users and the load balancer. At least one
    /// SSL certificate must be specified.
    /// </summary>
    public TerraformList<string>? SslCertificates
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ssl_certificates").ResolveNodes(ctx));
        set => SetArgument("ssl_certificates", value);
    }

    /// <summary>
    /// A reference to the SslPolicy resource that will be associated with
    /// the TargetSslProxy resource. If not set, the TargetSslProxy
    /// resource will not have any SSL policy configured.
    /// </summary>
    public TerraformValue<string>? SslPolicy
    {
        get => new TerraformReference<string>(this, "ssl_policy");
        set => SetArgument("ssl_policy", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformValue<double> ProxyId
    {
        get => new TerraformReference<double>(this, "proxy_id");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeTargetSslProxyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeTargetSslProxyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
