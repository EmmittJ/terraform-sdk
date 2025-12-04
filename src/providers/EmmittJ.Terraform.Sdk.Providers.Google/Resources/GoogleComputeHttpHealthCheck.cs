using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeHttpHealthCheck.
/// Nesting mode: single
/// </summary>
public class GoogleComputeHttpHealthCheckTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_http_health_check Terraform resource.
/// Manages a google_compute_http_health_check resource.
/// </summary>
public partial class GoogleComputeHttpHealthCheck(string name) : TerraformResource("google_compute_http_health_check", name)
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
    /// The value of the host header in the HTTP health check request. If
    /// left empty (default value), the public IP on behalf of which this
    /// health check is performed will be used.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
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
    /// The TCP port number for the HTTP health check request.
    /// The default value is 80.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
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
    /// The request path of the HTTP health check request.
    /// The default value is /.
    /// </summary>
    public TerraformValue<string>? RequestPath
    {
        get => GetArgument<TerraformValue<string>>("request_path");
        set => SetArgument("request_path", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeHttpHealthCheckTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeHttpHealthCheckTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
