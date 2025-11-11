using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for grpc_health_check in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionHealthCheckGrpcHealthCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    /// 
    /// * Empty serviceName means the overall status of all services at the backend.
    /// * Non-empty serviceName means the health of that gRPC service, as defined by the owner of the service.
    /// 
    /// The grpcServiceName can only be ASCII.
    /// </summary>
    [TerraformProperty("grpc_service_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GrpcServiceName { get; set; }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if portName and portSpecification are not set
    /// or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformProperty("port_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// 
    ///   * &#39;USE_FIXED_PORT&#39;: The port number in &#39;port&#39; is used for health checking.
    /// 
    ///   * &#39;USE_NAMED_PORT&#39;: The &#39;portName&#39; is used for health checking.
    /// 
    ///   * &#39;USE_SERVING_PORT&#39;: For NetworkEndpointGroup, the port specified for each
    ///   network endpoint is used for health checking. For other backends, the
    ///   port or named port specified in the Backend Service is used for health
    ///   checking.
    /// 
    /// If not specified, gRPC health check follows behavior specified in &#39;port&#39; and
    /// &#39;portName&#39; fields. Possible values: [&amp;quot;USE_FIXED_PORT&amp;quot;, &amp;quot;USE_NAMED_PORT&amp;quot;, &amp;quot;USE_SERVING_PORT&amp;quot;]
    /// </summary>
    [TerraformProperty("port_specification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortSpecification { get; set; }

}

/// <summary>
/// Block type for grpc_tls_health_check in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionHealthCheckGrpcTlsHealthCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    /// 
    /// * Empty serviceName means the overall status of all services at the backend.
    /// * Non-empty serviceName means the health of that gRPC service, as defined by the owner of the service.
    /// 
    /// The grpcServiceName can only be ASCII.
    /// </summary>
    [TerraformProperty("grpc_service_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GrpcServiceName { get; set; }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// 
    ///   * &#39;USE_FIXED_PORT&#39;: The port number in &#39;port&#39; is used for health checking.
    /// 
    ///   * &#39;USE_NAMED_PORT&#39;: Not supported for GRPC with TLS health checking.
    /// 
    ///   * &#39;USE_SERVING_PORT&#39;: For NetworkEndpointGroup, the port specified for each
    ///   network endpoint is used for health checking. For other backends, the
    ///   port or named port specified in the Backend Service is used for health
    ///   checking.
    /// 
    /// If not specified, gRPC health check follows behavior specified in the &#39;port&#39; field. Possible values: [&amp;quot;USE_FIXED_PORT&amp;quot;, &amp;quot;USE_NAMED_PORT&amp;quot;, &amp;quot;USE_SERVING_PORT&amp;quot;]
    /// </summary>
    [TerraformProperty("port_specification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortSpecification { get; set; }

}

/// <summary>
/// Block type for http2_health_check in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionHealthCheckHttp2HealthCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// The value of the host header in the HTTP2 health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [TerraformProperty("host")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTP2 health check request.
    /// The default value is 443.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformProperty("port_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// 
    ///   * &#39;USE_FIXED_PORT&#39;: The port number in &#39;port&#39; is used for health checking.
    /// 
    ///   * &#39;USE_NAMED_PORT&#39;: The &#39;portName&#39; is used for health checking.
    /// 
    ///   * &#39;USE_SERVING_PORT&#39;: For NetworkEndpointGroup, the port specified for each
    ///   network endpoint is used for health checking. For other backends, the
    ///   port or named port specified in the Backend Service is used for health
    ///   checking.
    /// 
    /// If not specified, HTTP2 health check follows behavior specified in &#39;port&#39; and
    /// &#39;portName&#39; fields. Possible values: [&amp;quot;USE_FIXED_PORT&amp;quot;, &amp;quot;USE_NAMED_PORT&amp;quot;, &amp;quot;USE_SERVING_PORT&amp;quot;]
    /// </summary>
    [TerraformProperty("port_specification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformProperty("proxy_header")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTP2 health check request.
    /// The default value is /.
    /// </summary>
    [TerraformProperty("request_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [TerraformProperty("response")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Response { get; set; }

}

/// <summary>
/// Block type for http_health_check in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionHealthCheckHttpHealthCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// The value of the host header in the HTTP health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [TerraformProperty("host")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTP health check request.
    /// The default value is 80.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformProperty("port_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// 
    ///   * &#39;USE_FIXED_PORT&#39;: The port number in &#39;port&#39; is used for health checking.
    /// 
    ///   * &#39;USE_NAMED_PORT&#39;: The &#39;portName&#39; is used for health checking.
    /// 
    ///   * &#39;USE_SERVING_PORT&#39;: For NetworkEndpointGroup, the port specified for each
    ///   network endpoint is used for health checking. For other backends, the
    ///   port or named port specified in the Backend Service is used for health
    ///   checking.
    /// 
    /// If not specified, HTTP health check follows behavior specified in &#39;port&#39; and
    /// &#39;portName&#39; fields. Possible values: [&amp;quot;USE_FIXED_PORT&amp;quot;, &amp;quot;USE_NAMED_PORT&amp;quot;, &amp;quot;USE_SERVING_PORT&amp;quot;]
    /// </summary>
    [TerraformProperty("port_specification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformProperty("proxy_header")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTP health check request.
    /// The default value is /.
    /// </summary>
    [TerraformProperty("request_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [TerraformProperty("response")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Response { get; set; }

}

/// <summary>
/// Block type for https_health_check in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionHealthCheckHttpsHealthCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// The value of the host header in the HTTPS health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [TerraformProperty("host")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTPS health check request.
    /// The default value is 443.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformProperty("port_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// 
    ///   * &#39;USE_FIXED_PORT&#39;: The port number in &#39;port&#39; is used for health checking.
    /// 
    ///   * &#39;USE_NAMED_PORT&#39;: The &#39;portName&#39; is used for health checking.
    /// 
    ///   * &#39;USE_SERVING_PORT&#39;: For NetworkEndpointGroup, the port specified for each
    ///   network endpoint is used for health checking. For other backends, the
    ///   port or named port specified in the Backend Service is used for health
    ///   checking.
    /// 
    /// If not specified, HTTPS health check follows behavior specified in &#39;port&#39; and
    /// &#39;portName&#39; fields. Possible values: [&amp;quot;USE_FIXED_PORT&amp;quot;, &amp;quot;USE_NAMED_PORT&amp;quot;, &amp;quot;USE_SERVING_PORT&amp;quot;]
    /// </summary>
    [TerraformProperty("port_specification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformProperty("proxy_header")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTPS health check request.
    /// The default value is /.
    /// </summary>
    [TerraformProperty("request_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [TerraformProperty("response")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Response { get; set; }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionHealthCheckLogConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Indicates whether or not to export logs. This is false by default,
    /// which means no health check logging will be done.
    /// </summary>
    [TerraformProperty("enable")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enable { get; set; }

}

/// <summary>
/// Block type for ssl_health_check in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionHealthCheckSslHealthCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// The TCP port number for the SSL health check request.
    /// The default value is 443.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformProperty("port_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// 
    ///   * &#39;USE_FIXED_PORT&#39;: The port number in &#39;port&#39; is used for health checking.
    /// 
    ///   * &#39;USE_NAMED_PORT&#39;: The &#39;portName&#39; is used for health checking.
    /// 
    ///   * &#39;USE_SERVING_PORT&#39;: For NetworkEndpointGroup, the port specified for each
    ///   network endpoint is used for health checking. For other backends, the
    ///   port or named port specified in the Backend Service is used for health
    ///   checking.
    /// 
    /// If not specified, SSL health check follows behavior specified in &#39;port&#39; and
    /// &#39;portName&#39; fields. Possible values: [&amp;quot;USE_FIXED_PORT&amp;quot;, &amp;quot;USE_NAMED_PORT&amp;quot;, &amp;quot;USE_SERVING_PORT&amp;quot;]
    /// </summary>
    [TerraformProperty("port_specification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformProperty("proxy_header")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProxyHeader { get; set; }

    /// <summary>
    /// The application data to send once the SSL connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    [TerraformProperty("request")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Request { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [TerraformProperty("response")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Response { get; set; }

}

/// <summary>
/// Block type for tcp_health_check in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionHealthCheckTcpHealthCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// The TCP port number for the TCP health check request.
    /// The default value is 80.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformProperty("port_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortName { get; set; }

    /// <summary>
    /// Specifies how port is selected for health checking, can be one of the
    /// following values:
    /// 
    ///   * &#39;USE_FIXED_PORT&#39;: The port number in &#39;port&#39; is used for health checking.
    /// 
    ///   * &#39;USE_NAMED_PORT&#39;: The &#39;portName&#39; is used for health checking.
    /// 
    ///   * &#39;USE_SERVING_PORT&#39;: For NetworkEndpointGroup, the port specified for each
    ///   network endpoint is used for health checking. For other backends, the
    ///   port or named port specified in the Backend Service is used for health
    ///   checking.
    /// 
    /// If not specified, TCP health check follows behavior specified in &#39;port&#39; and
    /// &#39;portName&#39; fields. Possible values: [&amp;quot;USE_FIXED_PORT&amp;quot;, &amp;quot;USE_NAMED_PORT&amp;quot;, &amp;quot;USE_SERVING_PORT&amp;quot;]
    /// </summary>
    [TerraformProperty("port_specification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformProperty("proxy_header")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProxyHeader { get; set; }

    /// <summary>
    /// The application data to send once the TCP connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    [TerraformProperty("request")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Request { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [TerraformProperty("response")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Response { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRegionHealthCheckTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_region_health_check resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeRegionHealthCheck : TerraformResource
{
    public GoogleComputeRegionHealthCheck(string name) : base("google_compute_region_health_check", name)
    {
    }

    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    [TerraformProperty("check_interval_sec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? CheckIntervalSec { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    [TerraformProperty("healthy_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? HealthyThreshold { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The Region in which the created health check should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    [TerraformProperty("timeout_sec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TimeoutSec { get; set; }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    [TerraformProperty("unhealthy_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? UnhealthyThreshold { get; set; }

    /// <summary>
    /// Block for grpc_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcHealthCheck block(s) allowed")]
    [TerraformProperty("grpc_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeRegionHealthCheckGrpcHealthCheckBlock>>? GrpcHealthCheck { get; set; }

    /// <summary>
    /// Block for grpc_tls_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcTlsHealthCheck block(s) allowed")]
    [TerraformProperty("grpc_tls_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeRegionHealthCheckGrpcTlsHealthCheckBlock>>? GrpcTlsHealthCheck { get; set; }

    /// <summary>
    /// Block for http2_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http2HealthCheck block(s) allowed")]
    [TerraformProperty("http2_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeRegionHealthCheckHttp2HealthCheckBlock>>? Http2HealthCheck { get; set; }

    /// <summary>
    /// Block for http_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpHealthCheck block(s) allowed")]
    [TerraformProperty("http_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeRegionHealthCheckHttpHealthCheckBlock>>? HttpHealthCheck { get; set; }

    /// <summary>
    /// Block for https_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpsHealthCheck block(s) allowed")]
    [TerraformProperty("https_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeRegionHealthCheckHttpsHealthCheckBlock>>? HttpsHealthCheck { get; set; }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformProperty("log_config")]
    public TerraformList<TerraformBlock<GoogleComputeRegionHealthCheckLogConfigBlock>>? LogConfig { get; set; }

    /// <summary>
    /// Block for ssl_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslHealthCheck block(s) allowed")]
    [TerraformProperty("ssl_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeRegionHealthCheckSslHealthCheckBlock>>? SslHealthCheck { get; set; }

    /// <summary>
    /// Block for tcp_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpHealthCheck block(s) allowed")]
    [TerraformProperty("tcp_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeRegionHealthCheckTcpHealthCheckBlock>>? TcpHealthCheck { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeRegionHealthCheckTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("health_check_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> HealthCheckId { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The type of the health check. One of HTTP, HTTP2, HTTPS, TCP, or SSL.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}
