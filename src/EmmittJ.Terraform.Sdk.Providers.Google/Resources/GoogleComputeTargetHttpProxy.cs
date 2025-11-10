using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetHttpProxyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_target_http_proxy resource.
/// </summary>
public class GoogleComputeTargetHttpProxy : TerraformResource
{
    public GoogleComputeTargetHttpProxy(string name) : base("google_compute_target_http_proxy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("proxy_id");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    public TerraformProperty<double>? HttpKeepAliveTimeoutSec
    {
        get => GetProperty<TerraformProperty<double>>("http_keep_alive_timeout_sec");
        set => this.WithProperty("http_keep_alive_timeout_sec", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// This field only applies when the forwarding rule that references
    /// this target proxy has a loadBalancingScheme set to INTERNAL_SELF_MANAGED.
    /// </summary>
    public TerraformProperty<bool>? ProxyBind
    {
        get => GetProperty<TerraformProperty<bool>>("proxy_bind");
        set => this.WithProperty("proxy_bind", value);
    }

    /// <summary>
    /// A reference to the UrlMap resource that defines the mapping from URL
    /// to the BackendService.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlMap is required")]
    public required TerraformProperty<string> UrlMap
    {
        get => GetProperty<TerraformProperty<string>>("url_map");
        set => this.WithProperty("url_map", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeTargetHttpProxyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeTargetHttpProxyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.
    /// This field will be ignored when inserting a TargetHttpProxy. An up-to-date fingerprint must be provided in order to
    /// patch/update the TargetHttpProxy; otherwise, the request will fail with error 412 conditionNotMet.
    /// To see the latest fingerprint, make a get() request to retrieve the TargetHttpProxy.
    /// A base64-encoded string.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformExpression ProxyId => this["proxy_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
