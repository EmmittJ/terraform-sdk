using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for grpc_health_check in GoogleComputeHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckGrpcHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_health_check";

    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    ///   - Empty serviceName means the overall status of all services at the backend.
    ///   - Non-empty serviceName means the health of that gRPC service, as defined by the owner of the service.
    /// The grpcServiceName can only be ASCII.
    /// </summary>
    public TerraformValue<string>? GrpcServiceName
    {
        get => GetArgument<TerraformValue<string>>("grpc_service_name");
        set => SetArgument("grpc_service_name", value);
    }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if portName and portSpecification are not set
    /// or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => GetArgument<TerraformValue<string>>("port_name");
        set => SetArgument("port_name", value);
    }

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
    public TerraformValue<string>? PortSpecification
    {
        get => GetArgument<TerraformValue<string>>("port_specification");
        set => SetArgument("port_specification", value);
    }

}


/// <summary>
/// Block type for grpc_tls_health_check in GoogleComputeHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckGrpcTlsHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_tls_health_check";

    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    ///   - Empty serviceName means the overall status of all services at the backend.
    ///   - Non-empty serviceName means the health of that gRPC service, as defined by the owner of the service.
    /// The grpcServiceName can only be ASCII.
    /// </summary>
    public TerraformValue<string>? GrpcServiceName
    {
        get => GetArgument<TerraformValue<string>>("grpc_service_name");
        set => SetArgument("grpc_service_name", value);
    }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

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
    public TerraformValue<string>? PortSpecification
    {
        get => GetArgument<TerraformValue<string>>("port_specification");
        set => SetArgument("port_specification", value);
    }

}


/// <summary>
/// Block type for http2_health_check in GoogleComputeHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckHttp2HealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http2_health_check";

    /// <summary>
    /// The value of the host header in the HTTP2 health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The TCP port number for the HTTP2 health check request.
    /// The default value is 443.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => GetArgument<TerraformValue<string>>("port_name");
        set => SetArgument("port_name", value);
    }

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
    public TerraformValue<string>? PortSpecification
    {
        get => GetArgument<TerraformValue<string>>("port_specification");
        set => SetArgument("port_specification", value);
    }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => GetArgument<TerraformValue<string>>("proxy_header");
        set => SetArgument("proxy_header", value);
    }

    /// <summary>
    /// The request path of the HTTP2 health check request.
    /// The default value is /.
    /// </summary>
    public TerraformValue<string>? RequestPath
    {
        get => GetArgument<TerraformValue<string>>("request_path");
        set => SetArgument("request_path", value);
    }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Response
    {
        get => GetArgument<TerraformValue<string>>("response");
        set => SetArgument("response", value);
    }

}


/// <summary>
/// Block type for http_health_check in GoogleComputeHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckHttpHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_health_check";

    /// <summary>
    /// The value of the host header in the HTTP health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The TCP port number for the HTTP health check request.
    /// The default value is 80.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => GetArgument<TerraformValue<string>>("port_name");
        set => SetArgument("port_name", value);
    }

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
    public TerraformValue<string>? PortSpecification
    {
        get => GetArgument<TerraformValue<string>>("port_specification");
        set => SetArgument("port_specification", value);
    }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => GetArgument<TerraformValue<string>>("proxy_header");
        set => SetArgument("proxy_header", value);
    }

    /// <summary>
    /// The request path of the HTTP health check request.
    /// The default value is /.
    /// </summary>
    public TerraformValue<string>? RequestPath
    {
        get => GetArgument<TerraformValue<string>>("request_path");
        set => SetArgument("request_path", value);
    }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Response
    {
        get => GetArgument<TerraformValue<string>>("response");
        set => SetArgument("response", value);
    }

}


/// <summary>
/// Block type for https_health_check in GoogleComputeHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckHttpsHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "https_health_check";

    /// <summary>
    /// The value of the host header in the HTTPS health check request.
    /// If left empty (default value), the public IP on behalf of which this health
    /// check is performed will be used.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The TCP port number for the HTTPS health check request.
    /// The default value is 443.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => GetArgument<TerraformValue<string>>("port_name");
        set => SetArgument("port_name", value);
    }

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
    public TerraformValue<string>? PortSpecification
    {
        get => GetArgument<TerraformValue<string>>("port_specification");
        set => SetArgument("port_specification", value);
    }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => GetArgument<TerraformValue<string>>("proxy_header");
        set => SetArgument("proxy_header", value);
    }

    /// <summary>
    /// The request path of the HTTPS health check request.
    /// The default value is /.
    /// </summary>
    public TerraformValue<string>? RequestPath
    {
        get => GetArgument<TerraformValue<string>>("request_path");
        set => SetArgument("request_path", value);
    }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Response
    {
        get => GetArgument<TerraformValue<string>>("response");
        set => SetArgument("response", value);
    }

}


/// <summary>
/// Block type for log_config in GoogleComputeHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_config";

    /// <summary>
    /// Indicates whether or not to export logs. This is false by default,
    /// which means no health check logging will be done.
    /// </summary>
    public TerraformValue<bool>? Enable
    {
        get => GetArgument<TerraformValue<bool>>("enable");
        set => SetArgument("enable", value);
    }

}


/// <summary>
/// Block type for ssl_health_check in GoogleComputeHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckSslHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssl_health_check";

    /// <summary>
    /// The TCP port number for the SSL health check request.
    /// The default value is 443.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => GetArgument<TerraformValue<string>>("port_name");
        set => SetArgument("port_name", value);
    }

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
    public TerraformValue<string>? PortSpecification
    {
        get => GetArgument<TerraformValue<string>>("port_specification");
        set => SetArgument("port_specification", value);
    }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => GetArgument<TerraformValue<string>>("proxy_header");
        set => SetArgument("proxy_header", value);
    }

    /// <summary>
    /// The application data to send once the SSL connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Request
    {
        get => GetArgument<TerraformValue<string>>("request");
        set => SetArgument("request", value);
    }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Response
    {
        get => GetArgument<TerraformValue<string>>("response");
        set => SetArgument("response", value);
    }

}


/// <summary>
/// Block type for tcp_health_check in GoogleComputeHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeHealthCheckTcpHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_health_check";

    /// <summary>
    /// The TCP port number for the TCP health check request.
    /// The default value is 443.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => GetArgument<TerraformValue<string>>("port_name");
        set => SetArgument("port_name", value);
    }

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
    public TerraformValue<string>? PortSpecification
    {
        get => GetArgument<TerraformValue<string>>("port_specification");
        set => SetArgument("port_specification", value);
    }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => GetArgument<TerraformValue<string>>("proxy_header");
        set => SetArgument("proxy_header", value);
    }

    /// <summary>
    /// The application data to send once the TCP connection has been
    /// established (default value is empty). If both request and response are
    /// empty, the connection establishment alone will indicate health. The request
    /// data can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Request
    {
        get => GetArgument<TerraformValue<string>>("request");
        set => SetArgument("request", value);
    }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Response
    {
        get => GetArgument<TerraformValue<string>>("response");
        set => SetArgument("response", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeHealthCheck.
/// Nesting mode: single
/// </summary>
public class GoogleComputeHealthCheckTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_health_check Terraform resource.
/// Manages a google_compute_health_check resource.
/// </summary>
public partial class GoogleComputeHealthCheck(string name) : TerraformResource("google_compute_health_check", name)
{
    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    public TerraformValue<double>? CheckIntervalSec
    {
        get => GetArgument<TerraformValue<double>>("check_interval_sec");
        set => SetArgument("check_interval_sec", value);
    }

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
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    public TerraformValue<double>? HealthyThreshold
    {
        get => GetArgument<TerraformValue<double>>("healthy_threshold");
        set => SetArgument("healthy_threshold", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

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
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

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
    public TerraformList<string>? SourceRegions
    {
        get => GetArgument<TerraformList<string>>("source_regions");
        set => SetArgument("source_regions", value);
    }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    public TerraformValue<double>? TimeoutSec
    {
        get => GetArgument<TerraformValue<double>>("timeout_sec");
        set => SetArgument("timeout_sec", value);
    }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    public TerraformValue<double>? UnhealthyThreshold
    {
        get => GetArgument<TerraformValue<double>>("unhealthy_threshold");
        set => SetArgument("unhealthy_threshold", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The type of the health check. One of HTTP, HTTPS, TCP, or SSL.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// GrpcHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeHealthCheckGrpcHealthCheckBlock>? GrpcHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeHealthCheckGrpcHealthCheckBlock>>("grpc_health_check");
        set => SetArgument("grpc_health_check", value);
    }

    /// <summary>
    /// GrpcTlsHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcTlsHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeHealthCheckGrpcTlsHealthCheckBlock>? GrpcTlsHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeHealthCheckGrpcTlsHealthCheckBlock>>("grpc_tls_health_check");
        set => SetArgument("grpc_tls_health_check", value);
    }

    /// <summary>
    /// Http2HealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http2HealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeHealthCheckHttp2HealthCheckBlock>? Http2HealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeHealthCheckHttp2HealthCheckBlock>>("http2_health_check");
        set => SetArgument("http2_health_check", value);
    }

    /// <summary>
    /// HttpHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeHealthCheckHttpHealthCheckBlock>? HttpHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeHealthCheckHttpHealthCheckBlock>>("http_health_check");
        set => SetArgument("http_health_check", value);
    }

    /// <summary>
    /// HttpsHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpsHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeHealthCheckHttpsHealthCheckBlock>? HttpsHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeHealthCheckHttpsHealthCheckBlock>>("https_health_check");
        set => SetArgument("https_health_check", value);
    }

    /// <summary>
    /// LogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public TerraformList<GoogleComputeHealthCheckLogConfigBlock>? LogConfig
    {
        get => GetArgument<TerraformList<GoogleComputeHealthCheckLogConfigBlock>>("log_config");
        set => SetArgument("log_config", value);
    }

    /// <summary>
    /// SslHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeHealthCheckSslHealthCheckBlock>? SslHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeHealthCheckSslHealthCheckBlock>>("ssl_health_check");
        set => SetArgument("ssl_health_check", value);
    }

    /// <summary>
    /// TcpHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeHealthCheckTcpHealthCheckBlock>? TcpHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeHealthCheckTcpHealthCheckBlock>>("tcp_health_check");
        set => SetArgument("tcp_health_check", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeHealthCheckTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeHealthCheckTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
