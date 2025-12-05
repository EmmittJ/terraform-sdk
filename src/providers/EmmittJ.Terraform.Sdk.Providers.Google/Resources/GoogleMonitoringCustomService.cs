using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for telemetry in GoogleMonitoringCustomService.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringCustomServiceTelemetryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "telemetry";

    /// <summary>
    /// The full name of the resource that defines this service.
    /// Formatted as described in
    /// https://cloud.google.com/apis/design/resource_names.
    /// </summary>
    public TerraformValue<string>? ResourceNameAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_name");
        set => SetArgument("resource_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleMonitoringCustomService.
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringCustomServiceTimeoutsBlock : TerraformBlock
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
/// Represents a google_monitoring_custom_service Terraform resource.
/// Manages a google_monitoring_custom_service resource.
/// </summary>
public partial class GoogleMonitoringCustomService(string name) : TerraformResource("google_monitoring_custom_service", name)
{
    /// <summary>
    /// Name used for UI elements listing this Service.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    public TerraformValue<string> ServiceId
    {
        get => GetArgument<TerraformValue<string>>("service_id") ?? CreateReference("service_id");
        set => SetArgument("service_id", value);
    }

    /// <summary>
    /// Labels which have been used to annotate the service. Label keys must start
    /// with a letter. Label keys and values may contain lowercase letters,
    /// numbers, underscores, and dashes. Label keys and values have a maximum
    /// length of 63 characters, and must be less than 128 bytes in size. Up to 64
    /// label entries may be stored. For labels which do not have a semantic value,
    /// the empty string may be supplied for the label value.
    /// </summary>
    public TerraformMap<string>? UserLabels
    {
        get => GetArgument<TerraformMap<string>>("user_labels");
        set => SetArgument("user_labels", value);
    }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Telemetry block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Telemetry block(s) allowed")]
    public TerraformList<GoogleMonitoringCustomServiceTelemetryBlock>? Telemetry
    {
        get => GetArgument<TerraformList<GoogleMonitoringCustomServiceTelemetryBlock>>("telemetry");
        set => SetArgument("telemetry", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMonitoringCustomServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMonitoringCustomServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
