using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeTargetPool.
/// Nesting mode: single
/// </summary>
public class GoogleComputeTargetPoolTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_target_pool Terraform resource.
/// Manages a google_compute_target_pool resource.
/// </summary>
public partial class GoogleComputeTargetPool(string name) : TerraformResource("google_compute_target_pool", name)
{
    /// <summary>
    /// URL to the backup target pool. Must also set failover_ratio.
    /// </summary>
    public TerraformValue<string>? BackupPool
    {
        get => GetArgument<TerraformValue<string>>("backup_pool");
        set => SetArgument("backup_pool", value);
    }

    /// <summary>
    /// Textual description field.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Ratio (0 to 1) of failed nodes before using the backup pool (which must also be set).
    /// </summary>
    public TerraformValue<double>? FailoverRatio
    {
        get => GetArgument<TerraformValue<double>>("failover_ratio");
        set => SetArgument("failover_ratio", value);
    }

    /// <summary>
    /// List of zero or one health check name or self_link. Only legacy google_compute_http_health_check is supported.
    /// </summary>
    public TerraformList<string>? HealthChecks
    {
        get => GetArgument<TerraformList<string>>("health_checks");
        set => SetArgument("health_checks", value);
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
    /// List of instances in the pool. They can be given as URLs, or in the form of &amp;quot;zone/name&amp;quot;. Note that the instances need not exist at the time of target pool creation, so there is no need to use the Terraform interpolators to create a dependency on the instances from the target pool.
    /// </summary>
    public TerraformSet<string>? Instances
    {
        get => GetArgument<TerraformSet<string>>("instances");
        set => SetArgument("instances", value);
    }

    /// <summary>
    /// A unique name for the resource, required by GCE. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Where the target pool resides. Defaults to project region.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// How to distribute load. Options are &amp;quot;NONE&amp;quot; (no affinity). &amp;quot;CLIENT_IP&amp;quot; (hash of the source/dest addresses / ports), and &amp;quot;CLIENT_IP_PROTO&amp;quot; also includes the protocol (default &amp;quot;NONE&amp;quot;).
    /// </summary>
    public TerraformValue<string>? SessionAffinity
    {
        get => GetArgument<TerraformValue<string>>("session_affinity");
        set => SetArgument("session_affinity", value);
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeTargetPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeTargetPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
