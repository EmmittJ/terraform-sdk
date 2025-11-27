using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeTargetHttpProxy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetHttpProxyTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_target_http_proxy Terraform resource.
/// Manages a google_compute_target_http_proxy resource.
/// </summary>
public partial class GoogleComputeTargetHttpProxy(string name) : TerraformResource("google_compute_target_http_proxy", name)
{
    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Specifies how long to keep a connection open, after completing a response,
    /// while there is no matching traffic (in seconds). If an HTTP keepalive is
    /// not specified, a default value will be used. For Global
    /// external HTTP(S) load balancer, the default value is 610 seconds, the
    /// minimum allowed value is 5 seconds and the maximum allowed value is 1200
    /// seconds. For cross-region internal HTTP(S) load balancer, the default
    /// value is 600 seconds, the minimum allowed value is 5 seconds, and the
    /// maximum allowed value is 600 seconds. For Global external HTTP(S) load
    /// balancer (classic), this option is not available publicly.
    /// </summary>
    public TerraformValue<double>? HttpKeepAliveTimeoutSec
    {
        get => new TerraformReference<double>(this, "http_keep_alive_timeout_sec");
        set => SetArgument("http_keep_alive_timeout_sec", value);
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
    /// This field only applies when the forwarding rule that references
    /// this target proxy has a loadBalancingScheme set to INTERNAL_SELF_MANAGED.
    /// </summary>
    public TerraformValue<bool> ProxyBind
    {
        get => new TerraformReference<bool>(this, "proxy_bind");
        set => SetArgument("proxy_bind", value);
    }

    /// <summary>
    /// A reference to the UrlMap resource that defines the mapping from URL
    /// to the BackendService.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlMap is required")]
    public required TerraformValue<string> UrlMap
    {
        get => new TerraformReference<string>(this, "url_map");
        set => SetArgument("url_map", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.
    /// This field will be ignored when inserting a TargetHttpProxy. An up-to-date fingerprint must be provided in order to
    /// patch/update the TargetHttpProxy; otherwise, the request will fail with error 412 conditionNotMet.
    /// To see the latest fingerprint, make a get() request to retrieve the TargetHttpProxy.
    /// A base64-encoded string.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
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
    public GoogleComputeTargetHttpProxyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeTargetHttpProxyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
