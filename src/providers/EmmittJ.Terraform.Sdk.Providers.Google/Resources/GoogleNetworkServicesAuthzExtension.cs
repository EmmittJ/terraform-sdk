using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesAuthzExtensionTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_services_authz_extension resource.
/// </summary>
public class GoogleNetworkServicesAuthzExtension : TerraformResource
{
    public GoogleNetworkServicesAuthzExtension(string name) : base("google_network_services_authz_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("authority");
        SetOutput("description");
        SetOutput("fail_open");
        SetOutput("forward_headers");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("load_balancing_scheme");
        SetOutput("location");
        SetOutput("metadata");
        SetOutput("name");
        SetOutput("project");
        SetOutput("service");
        SetOutput("timeout");
        SetOutput("wire_format");
    }

    /// <summary>
    /// The :authority header in the gRPC request sent from Envoy to the extension service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authority is required")]
    public required TerraformProperty<string> Authority
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authority");
        set => SetProperty("authority", value);
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Determines how the proxy behaves if the call to the extension fails or times out.
    /// When set to TRUE, request or response processing continues without error. Any subsequent extensions in the extension chain are also executed. When set to FALSE or the default setting of FALSE is used, one of the following happens:
    /// * If response headers have not been delivered to the downstream client, a generic 500 error is returned to the client. The error response can be tailored by configuring a custom error response in the load balancer.
    /// * If response headers have been delivered, then the HTTP stream to the downstream client is reset.
    /// </summary>
    public TerraformProperty<bool> FailOpen
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fail_open");
        set => SetProperty("fail_open", value);
    }

    /// <summary>
    /// List of the HTTP headers to forward to the extension (from the client). If omitted, all headers are sent. Each element is a string indicating the header name.
    /// </summary>
    public List<TerraformProperty<string>> ForwardHeaders
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("forward_headers");
        set => SetProperty("forward_headers", value);
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
    /// Set of labels associated with the AuthzExtension resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// All backend services and forwarding rules referenced by this extension must share the same load balancing scheme.
    /// For more information, refer to [Backend services overview](https://cloud.google.com/load-balancing/docs/backend-service). Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingScheme is required")]
    public required TerraformProperty<string> LoadBalancingScheme
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancing_scheme");
        set => SetProperty("load_balancing_scheme", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The metadata provided here is included as part of the metadata_context (of type google.protobuf.Struct) in the ProcessingRequest message sent to the extension server. The metadata is available under the namespace com.google.authz_extension.&amp;lt;resourceName&amp;gt;. The following variables are supported in the metadata Struct:
    /// 
    /// {forwarding_rule_id} - substituted with the forwarding rule&#39;s fully qualified resource name.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Metadata
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// Identifier. Name of the AuthzExtension resource.
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
    /// The reference to the service that runs the extension.
    /// To configure a callout extension, service must be a fully-qualified reference to a [backend service](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices) in the format:
    /// https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/backendServices/{backendService} or https://www.googleapis.com/compute/v1/projects/{project}/global/backendServices/{backendService}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// Specifies the timeout for each individual message on the stream. The timeout must be between 10-10000 milliseconds.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformProperty<string> Timeout
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timeout");
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// The format of communication supported by the callout extension. Will be set to EXT_PROC_GRPC by the backend if no value is set. Possible values: [&amp;quot;WIRE_FORMAT_UNSPECIFIED&amp;quot;, &amp;quot;EXT_PROC_GRPC&amp;quot;]
    /// </summary>
    public TerraformProperty<string> WireFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("wire_format");
        set => SetProperty("wire_format", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesAuthzExtensionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
