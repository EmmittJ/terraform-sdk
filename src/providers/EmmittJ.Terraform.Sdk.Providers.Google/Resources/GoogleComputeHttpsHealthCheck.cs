using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeHttpsHealthCheck.
/// Nesting mode: single
/// </summary>
public class GoogleComputeHttpsHealthCheckTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_https_health_check Terraform resource.
/// Manages a google_compute_https_health_check resource.
/// </summary>
public partial class GoogleComputeHttpsHealthCheck(string name) : TerraformResource("google_compute_https_health_check", name)
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
    /// The value of the host header in the HTTPS health check request. If
    /// left empty (default value), the public IP on behalf of which this
    /// health check is performed will be used.
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
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
    /// The TCP port number for the HTTPS health check request.
    /// The default value is 443.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
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
    /// The request path of the HTTPS health check request.
    /// The default value is /.
    /// </summary>
    public TerraformValue<string>? RequestPath
    {
        get => new TerraformReference<string>(this, "request_path");
        set => SetArgument("request_path", value);
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
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeHttpsHealthCheckTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeHttpsHealthCheckTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
