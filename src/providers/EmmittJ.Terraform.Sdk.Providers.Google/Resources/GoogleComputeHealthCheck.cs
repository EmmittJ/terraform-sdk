using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for grpc_health_check in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckGrpcHealthCheckBlock : ITerraformBlock
{
    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    ///   - Empty serviceName means the overall status of all services at the backend.
    ///   - Non-empty serviceName means the health of that gRPC service, as defined by the owner of the service.
    /// The grpcServiceName can only be ASCII.
    /// </summary>
    [TerraformPropertyName("grpc_service_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GrpcServiceName { get; set; }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if portName and portSpecification are not set
    /// or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformPropertyName("port_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortName { get; set; }

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
    [TerraformPropertyName("port_specification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortSpecification { get; set; }

}

/// <summary>
/// Block type for grpc_tls_health_check in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckGrpcTlsHealthCheckBlock : ITerraformBlock
{
    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    ///   - Empty serviceName means the overall status of all services at the backend.
    ///   - Non-empty serviceName means the health of that gRPC service, as defined by the owner of the service.
    /// The grpcServiceName can only be ASCII.
    /// </summary>
    [TerraformPropertyName("grpc_service_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GrpcServiceName { get; set; }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

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
    /// If not specified, gRPC with TLS health check follows behavior specified in the &#39;port&#39; field. Possible values: [&amp;quot;USE_FIXED_PORT&amp;quot;, &amp;quot;USE_NAMED_PORT&amp;quot;, &amp;quot;USE_SERVING_PORT&amp;quot;]
    /// </summary>
    [TerraformPropertyName("port_specification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortSpecification { get; set; }

}

/// <summary>
/// Block type for http2_health_check in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckHttp2HealthCheckBlock : ITerraformBlock
{
    /// <summary>
    /// The value of the host header in the HTTP2 health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [TerraformPropertyName("host")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTP2 health check request.
    /// The default value is 443.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformPropertyName("port_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortName { get; set; }

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
    [TerraformPropertyName("port_specification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformPropertyName("proxy_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTP2 health check request.
    /// The default value is /.
    /// </summary>
    [TerraformPropertyName("request_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [TerraformPropertyName("response")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Response { get; set; }

}

/// <summary>
/// Block type for http_health_check in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckHttpHealthCheckBlock : ITerraformBlock
{
    /// <summary>
    /// The value of the host header in the HTTP health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [TerraformPropertyName("host")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTP health check request.
    /// The default value is 80.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformPropertyName("port_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortName { get; set; }

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
    [TerraformPropertyName("port_specification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformPropertyName("proxy_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTP health check request.
    /// The default value is /.
    /// </summary>
    [TerraformPropertyName("request_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [TerraformPropertyName("response")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Response { get; set; }

}

/// <summary>
/// Block type for https_health_check in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckHttpsHealthCheckBlock : ITerraformBlock
{
    /// <summary>
    /// The value of the host header in the HTTPS health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    [TerraformPropertyName("host")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Host { get; set; }

    /// <summary>
    /// The TCP port number for the HTTPS health check request.
    /// The default value is 443.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformPropertyName("port_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortName { get; set; }

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
    [TerraformPropertyName("port_specification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformPropertyName("proxy_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProxyHeader { get; set; }

    /// <summary>
    /// The request path of the HTTPS health check request.
    /// The default value is /.
    /// </summary>
    [TerraformPropertyName("request_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequestPath { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [TerraformPropertyName("response")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Response { get; set; }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckLogConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Indicates whether or not to export logs. This is false by default,
    /// which means no health check logging will be done.
    /// </summary>
    [TerraformPropertyName("enable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enable { get; set; }

}

/// <summary>
/// Block type for ssl_health_check in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckSslHealthCheckBlock : ITerraformBlock
{
    /// <summary>
    /// The TCP port number for the SSL health check request.
    /// The default value is 443.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformPropertyName("port_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortName { get; set; }

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
    [TerraformPropertyName("port_specification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformPropertyName("proxy_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProxyHeader { get; set; }

    /// <summary>
    /// The application data to send once the SSL connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    [TerraformPropertyName("request")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Request { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [TerraformPropertyName("response")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Response { get; set; }

}

/// <summary>
/// Block type for tcp_health_check in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckTcpHealthCheckBlock : ITerraformBlock
{
    /// <summary>
    /// The TCP port number for the TCP health check request.
    /// The default value is 443.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    [TerraformPropertyName("port_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortName { get; set; }

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
    [TerraformPropertyName("port_specification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PortSpecification { get; set; }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    [TerraformPropertyName("proxy_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProxyHeader { get; set; }

    /// <summary>
    /// The application data to send once the TCP connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    [TerraformPropertyName("request")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Request { get; set; }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    [TerraformPropertyName("response")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Response { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeHealthCheckTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_health_check resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeHealthCheck : TerraformResource
{
    public GoogleComputeHealthCheck(string name) : base("google_compute_health_check", name)
    {
    }

    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    [TerraformPropertyName("check_interval_sec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CheckIntervalSec { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    [TerraformPropertyName("healthy_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HealthyThreshold { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The list of cloud regions from which health checks are performed. If
    /// any regions are specified, then exactly 3 regions should be specified.
    /// The region names must be valid names of Google Cloud regions. This can
    /// only be set for global health check. If this list is non-empty, then
    /// there are restrictions on what other health check fields are supported
    /// and what other resources can use this health check:
    /// 
    /// * SSL, HTTP2, and GRPC protocols are not supported.
    /// 
    /// * The TCP request field is not supported.
    /// 
    /// * The proxyHeader field for HTTP, HTTPS, and TCP is not supported.
    /// 
    /// * The checkIntervalSec field must be at least 30.
    /// 
    /// * The health check cannot be used with BackendService nor with managed
    /// instance group auto-healing.
    /// </summary>
    [TerraformPropertyName("source_regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SourceRegions { get; set; }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    [TerraformPropertyName("timeout_sec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TimeoutSec { get; set; }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    [TerraformPropertyName("unhealthy_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? UnhealthyThreshold { get; set; }

    /// <summary>
    /// Block for grpc_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcHealthCheck block(s) allowed")]
    [TerraformPropertyName("grpc_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeHealthCheckGrpcHealthCheckBlock>>? GrpcHealthCheck { get; set; } = new();

    /// <summary>
    /// Block for grpc_tls_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcTlsHealthCheck block(s) allowed")]
    [TerraformPropertyName("grpc_tls_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeHealthCheckGrpcTlsHealthCheckBlock>>? GrpcTlsHealthCheck { get; set; } = new();

    /// <summary>
    /// Block for http2_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http2HealthCheck block(s) allowed")]
    [TerraformPropertyName("http2_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeHealthCheckHttp2HealthCheckBlock>>? Http2HealthCheck { get; set; } = new();

    /// <summary>
    /// Block for http_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpHealthCheck block(s) allowed")]
    [TerraformPropertyName("http_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeHealthCheckHttpHealthCheckBlock>>? HttpHealthCheck { get; set; } = new();

    /// <summary>
    /// Block for https_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpsHealthCheck block(s) allowed")]
    [TerraformPropertyName("https_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeHealthCheckHttpsHealthCheckBlock>>? HttpsHealthCheck { get; set; } = new();

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformPropertyName("log_config")]
    public TerraformList<TerraformBlock<GoogleComputeHealthCheckLogConfigBlock>>? LogConfig { get; set; } = new();

    /// <summary>
    /// Block for ssl_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslHealthCheck block(s) allowed")]
    [TerraformPropertyName("ssl_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeHealthCheckSslHealthCheckBlock>>? SslHealthCheck { get; set; } = new();

    /// <summary>
    /// Block for tcp_health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpHealthCheck block(s) allowed")]
    [TerraformPropertyName("tcp_health_check")]
    public TerraformList<TerraformBlock<GoogleComputeHealthCheckTcpHealthCheckBlock>>? TcpHealthCheck { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeHealthCheckTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The type of the health check. One of HTTP, HTTPS, TCP, or SSL.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
