using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetSslProxyTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_target_ssl_proxy resource.
/// </summary>
public class GoogleComputeTargetSslProxy : TerraformResource
{
    public GoogleComputeTargetSslProxy(string name) : base("google_compute_target_ssl_proxy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_timestamp");
        SetOutput("proxy_id");
        SetOutput("self_link");
        SetOutput("backend_service");
        SetOutput("certificate_map");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("proxy_header");
        SetOutput("ssl_certificates");
        SetOutput("ssl_policy");
    }

    /// <summary>
    /// A reference to the BackendService resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendService is required")]
    public required TerraformProperty<string> BackendService
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backend_service");
        set => SetProperty("backend_service", value);
    }

    /// <summary>
    /// A reference to the CertificateMap resource uri that identifies a certificate map
    /// associated with the given target proxy. This field can only be set for global target proxies.
    /// Accepted format is &#39;//certificatemanager.googleapis.com/projects/{project}/locations/{location}/certificateMaps/{resourceName}&#39;.
    /// </summary>
    public TerraformProperty<string> CertificateMap
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_map");
        set => SetProperty("certificate_map", value);
    }

    /// <summary>
    /// An optional description of this resource.
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
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Specifies the type of proxy header to append before sending data to
    /// the backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformProperty<string> ProxyHeader
    {
        get => GetRequiredOutput<TerraformProperty<string>>("proxy_header");
        set => SetProperty("proxy_header", value);
    }

    /// <summary>
    /// A list of SslCertificate resources that are used to authenticate
    /// connections between users and the load balancer. At least one
    /// SSL certificate must be specified.
    /// </summary>
    public List<TerraformProperty<string>> SslCertificates
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("ssl_certificates");
        set => SetProperty("ssl_certificates", value);
    }

    /// <summary>
    /// A reference to the SslPolicy resource that will be associated with
    /// the TargetSslProxy resource. If not set, the TargetSslProxy
    /// resource will not have any SSL policy configured.
    /// </summary>
    public TerraformProperty<string> SslPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ssl_policy");
        set => SetProperty("ssl_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeTargetSslProxyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformExpression ProxyId => this["proxy_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
