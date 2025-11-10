using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetGrpcProxyTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_target_grpc_proxy resource.
/// </summary>
public class GoogleComputeTargetGrpcProxy : TerraformResource
{
    public GoogleComputeTargetGrpcProxy(string name) : base("google_compute_target_grpc_proxy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_timestamp");
        SetOutput("fingerprint");
        SetOutput("self_link");
        SetOutput("self_link_with_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("url_map");
        SetOutput("validate_for_proxyless");
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
    /// Name of the resource. Provided by the client when the resource
    /// is created. The name must be 1-63 characters long, and comply
    /// with RFC1035. Specifically, the name must be 1-63 characters long
    /// and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which
    /// means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
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
    /// URL to the UrlMap resource that defines the mapping from URL to
    /// the BackendService. The protocol field in the BackendService
    /// must be set to GRPC.
    /// </summary>
    public TerraformProperty<string> UrlMap
    {
        get => GetRequiredOutput<TerraformProperty<string>>("url_map");
        set => SetProperty("url_map", value);
    }

    /// <summary>
    /// If true, indicates that the BackendServices referenced by
    /// the urlMap may be accessed by gRPC applications without using
    /// a sidecar proxy. This will enable configuration checks on urlMap
    /// and its referenced BackendServices to not allow unsupported features.
    /// A gRPC application must use &amp;quot;xds:///&amp;quot; scheme in the target URI
    /// of the service it is connecting to. If false, indicates that the
    /// BackendServices referenced by the urlMap will be accessed by gRPC
    /// applications via a sidecar proxy. In this case, a gRPC application
    /// must not use &amp;quot;xds:///&amp;quot; scheme in the target URI of the service
    /// it is connecting to
    /// </summary>
    public TerraformProperty<bool> ValidateForProxyless
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("validate_for_proxyless");
        set => SetProperty("validate_for_proxyless", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeTargetGrpcProxyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in
    /// this object. This field is used in optimistic locking. This field
    /// will be ignored when inserting a TargetGrpcProxy. An up-to-date
    /// fingerprint must be provided in order to patch/update the
    /// TargetGrpcProxy; otherwise, the request will fail with error
    /// 412 conditionNotMet. To see the latest fingerprint, make a get()
    /// request to retrieve the TargetGrpcProxy. A base64-encoded string.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Server-defined URL with id for the resource.
    /// </summary>
    public TerraformExpression SelfLinkWithId => this["self_link_with_id"];

}
