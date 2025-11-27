using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for grpc_health_check in GoogleComputeRegionHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionHealthCheckGrpcHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_health_check";

    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    /// 
    /// * Empty serviceName means the overall status of all services at the backend.
    /// * Non-empty serviceName means the health of that gRPC service, as defined by the owner of the service.
    /// 
    /// The grpcServiceName can only be ASCII.
    /// </summary>
    public TerraformValue<string>? GrpcServiceName
    {
        get => new TerraformReference<string>(this, "grpc_service_name");
        set => SetArgument("grpc_service_name", value);
    }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if portName and portSpecification are not set
    /// or if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => new TerraformReference<string>(this, "port_name");
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
        get => new TerraformReference<string>(this, "port_specification");
        set => SetArgument("port_specification", value);
    }

}


/// <summary>
/// Block type for grpc_tls_health_check in GoogleComputeRegionHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionHealthCheckGrpcTlsHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_tls_health_check";

    /// <summary>
    /// The gRPC service name for the health check.
    /// The value of grpcServiceName has the following meanings by convention:
    /// 
    /// * Empty serviceName means the overall status of all services at the backend.
    /// * Non-empty serviceName means the health of that gRPC service, as defined by the owner of the service.
    /// 
    /// The grpcServiceName can only be ASCII.
    /// </summary>
    public TerraformValue<string>? GrpcServiceName
    {
        get => new TerraformReference<string>(this, "grpc_service_name");
        set => SetArgument("grpc_service_name", value);
    }

    /// <summary>
    /// The port number for the health check request.
    /// Must be specified if port_specification is USE_FIXED_PORT. Valid values are 1 through 65535.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
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
    /// If not specified, gRPC health check follows behavior specified in the &#39;port&#39; field. Possible values: [&amp;quot;USE_FIXED_PORT&amp;quot;, &amp;quot;USE_NAMED_PORT&amp;quot;, &amp;quot;USE_SERVING_PORT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PortSpecification
    {
        get => new TerraformReference<string>(this, "port_specification");
        set => SetArgument("port_specification", value);
    }

}


/// <summary>
/// Block type for http2_health_check in GoogleComputeRegionHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionHealthCheckHttp2HealthCheckBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The TCP port number for the HTTP2 health check request.
    /// The default value is 443.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => new TerraformReference<string>(this, "port_name");
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
        get => new TerraformReference<string>(this, "port_specification");
        set => SetArgument("port_specification", value);
    }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => new TerraformReference<string>(this, "proxy_header");
        set => SetArgument("proxy_header", value);
    }

    /// <summary>
    /// The request path of the HTTP2 health check request.
    /// The default value is /.
    /// </summary>
    public TerraformValue<string>? RequestPath
    {
        get => new TerraformReference<string>(this, "request_path");
        set => SetArgument("request_path", value);
    }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Response
    {
        get => new TerraformReference<string>(this, "response");
        set => SetArgument("response", value);
    }

}


/// <summary>
/// Block type for http_health_check in GoogleComputeRegionHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionHealthCheckHttpHealthCheckBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The TCP port number for the HTTP health check request.
    /// The default value is 80.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => new TerraformReference<string>(this, "port_name");
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
        get => new TerraformReference<string>(this, "port_specification");
        set => SetArgument("port_specification", value);
    }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => new TerraformReference<string>(this, "proxy_header");
        set => SetArgument("proxy_header", value);
    }

    /// <summary>
    /// The request path of the HTTP health check request.
    /// The default value is /.
    /// </summary>
    public TerraformValue<string>? RequestPath
    {
        get => new TerraformReference<string>(this, "request_path");
        set => SetArgument("request_path", value);
    }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Response
    {
        get => new TerraformReference<string>(this, "response");
        set => SetArgument("response", value);
    }

}


/// <summary>
/// Block type for https_health_check in GoogleComputeRegionHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionHealthCheckHttpsHealthCheckBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The TCP port number for the HTTPS health check request.
    /// The default value is 443.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => new TerraformReference<string>(this, "port_name");
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
        get => new TerraformReference<string>(this, "port_specification");
        set => SetArgument("port_specification", value);
    }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => new TerraformReference<string>(this, "proxy_header");
        set => SetArgument("proxy_header", value);
    }

    /// <summary>
    /// The request path of the HTTPS health check request.
    /// The default value is /.
    /// </summary>
    public TerraformValue<string>? RequestPath
    {
        get => new TerraformReference<string>(this, "request_path");
        set => SetArgument("request_path", value);
    }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Response
    {
        get => new TerraformReference<string>(this, "response");
        set => SetArgument("response", value);
    }

}


/// <summary>
/// Block type for log_config in GoogleComputeRegionHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionHealthCheckLogConfigBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "enable");
        set => SetArgument("enable", value);
    }

}


/// <summary>
/// Block type for ssl_health_check in GoogleComputeRegionHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionHealthCheckSslHealthCheckBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => new TerraformReference<string>(this, "port_name");
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
        get => new TerraformReference<string>(this, "port_specification");
        set => SetArgument("port_specification", value);
    }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => new TerraformReference<string>(this, "proxy_header");
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
        get => new TerraformReference<string>(this, "request");
        set => SetArgument("request", value);
    }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Response
    {
        get => new TerraformReference<string>(this, "response");
        set => SetArgument("response", value);
    }

}


/// <summary>
/// Block type for tcp_health_check in GoogleComputeRegionHealthCheck.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionHealthCheckTcpHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_health_check";

    /// <summary>
    /// The TCP port number for the TCP health check request.
    /// The default value is 80.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Port name as defined in InstanceGroup#NamedPort#name. If both port and
    /// port_name are defined, port takes precedence.
    /// </summary>
    public TerraformValue<string>? PortName
    {
        get => new TerraformReference<string>(this, "port_name");
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
        get => new TerraformReference<string>(this, "port_specification");
        set => SetArgument("port_specification", value);
    }

    /// <summary>
    /// Specifies the type of proxy header to append before sending data to the
    /// backend. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;PROXY_V1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ProxyHeader
    {
        get => new TerraformReference<string>(this, "proxy_header");
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
        get => new TerraformReference<string>(this, "request");
        set => SetArgument("request", value);
    }

    /// <summary>
    /// The bytes to match against the beginning of the response data. If left empty
    /// (the default value), any response will indicate health. The response data
    /// can only be ASCII.
    /// </summary>
    public TerraformValue<string>? Response
    {
        get => new TerraformReference<string>(this, "response");
        set => SetArgument("response", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRegionHealthCheck.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionHealthCheckTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_region_health_check Terraform resource.
/// Manages a google_compute_region_health_check resource.
/// </summary>
public partial class GoogleComputeRegionHealthCheck(string name) : TerraformResource("google_compute_region_health_check", name)
{
    /// <summary>
    /// How often (in seconds) to send a health check. The default value is 5
    /// seconds.
    /// </summary>
    public TerraformValue<double>? CheckIntervalSec
    {
        get => new TerraformReference<double>(this, "check_interval_sec");
        set => SetArgument("check_interval_sec", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A so-far unhealthy instance will be marked healthy after this many
    /// consecutive successes. The default value is 2.
    /// </summary>
    public TerraformValue<double>? HealthyThreshold
    {
        get => new TerraformReference<double>(this, "healthy_threshold");
        set => SetArgument("healthy_threshold", value);
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
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
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
    /// The Region in which the created health check should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// How long (in seconds) to wait before claiming failure.
    /// The default value is 5 seconds.  It is invalid for timeoutSec to have
    /// greater value than checkIntervalSec.
    /// </summary>
    public TerraformValue<double>? TimeoutSec
    {
        get => new TerraformReference<double>(this, "timeout_sec");
        set => SetArgument("timeout_sec", value);
    }

    /// <summary>
    /// A so-far healthy instance will be marked unhealthy after this many
    /// consecutive failures. The default value is 2.
    /// </summary>
    public TerraformValue<double>? UnhealthyThreshold
    {
        get => new TerraformReference<double>(this, "unhealthy_threshold");
        set => SetArgument("unhealthy_threshold", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> HealthCheckId
    {
        get => new TerraformReference<double>(this, "health_check_id");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The type of the health check. One of HTTP, HTTP2, HTTPS, TCP, or SSL.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// GrpcHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeRegionHealthCheckGrpcHealthCheckBlock>? GrpcHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeRegionHealthCheckGrpcHealthCheckBlock>>("grpc_health_check");
        set => SetArgument("grpc_health_check", value);
    }

    /// <summary>
    /// GrpcTlsHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcTlsHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeRegionHealthCheckGrpcTlsHealthCheckBlock>? GrpcTlsHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeRegionHealthCheckGrpcTlsHealthCheckBlock>>("grpc_tls_health_check");
        set => SetArgument("grpc_tls_health_check", value);
    }

    /// <summary>
    /// Http2HealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http2HealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeRegionHealthCheckHttp2HealthCheckBlock>? Http2HealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeRegionHealthCheckHttp2HealthCheckBlock>>("http2_health_check");
        set => SetArgument("http2_health_check", value);
    }

    /// <summary>
    /// HttpHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeRegionHealthCheckHttpHealthCheckBlock>? HttpHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeRegionHealthCheckHttpHealthCheckBlock>>("http_health_check");
        set => SetArgument("http_health_check", value);
    }

    /// <summary>
    /// HttpsHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpsHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeRegionHealthCheckHttpsHealthCheckBlock>? HttpsHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeRegionHealthCheckHttpsHealthCheckBlock>>("https_health_check");
        set => SetArgument("https_health_check", value);
    }

    /// <summary>
    /// LogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public TerraformList<GoogleComputeRegionHealthCheckLogConfigBlock>? LogConfig
    {
        get => GetArgument<TerraformList<GoogleComputeRegionHealthCheckLogConfigBlock>>("log_config");
        set => SetArgument("log_config", value);
    }

    /// <summary>
    /// SslHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SslHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeRegionHealthCheckSslHealthCheckBlock>? SslHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeRegionHealthCheckSslHealthCheckBlock>>("ssl_health_check");
        set => SetArgument("ssl_health_check", value);
    }

    /// <summary>
    /// TcpHealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TcpHealthCheck block(s) allowed")]
    public TerraformList<GoogleComputeRegionHealthCheckTcpHealthCheckBlock>? TcpHealthCheck
    {
        get => GetArgument<TerraformList<GoogleComputeRegionHealthCheckTcpHealthCheckBlock>>("tcp_health_check");
        set => SetArgument("tcp_health_check", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionHealthCheckTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionHealthCheckTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
