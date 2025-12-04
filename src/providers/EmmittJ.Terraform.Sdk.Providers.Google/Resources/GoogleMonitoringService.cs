using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_service in GoogleMonitoringService.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringServiceBasicServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic_service";

    /// <summary>
    /// Labels that specify the resource that emits the monitoring data
    /// which is used for SLO reporting of this &#39;Service&#39;.
    /// </summary>
    public TerraformMap<string>? ServiceLabels
    {
        get => GetArgument<TerraformMap<string>>("service_labels");
        set => SetArgument("service_labels", value);
    }

    /// <summary>
    /// The type of service that this basic service defines, e.g.
    /// APP_ENGINE service type
    /// </summary>
    public TerraformValue<string>? ServiceType
    {
        get => GetArgument<TerraformValue<string>>("service_type");
        set => SetArgument("service_type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleMonitoringService.
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringServiceTimeoutsBlock : TerraformBlock
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
/// Represents a google_monitoring_service Terraform resource.
/// Manages a google_monitoring_service resource.
/// </summary>
public partial class GoogleMonitoringService(string name) : TerraformResource("google_monitoring_service", name)
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformValue<string> ServiceId
    {
        get => GetArgument<TerraformValue<string>>("service_id");
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
        => AsReference("name");

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    public TerraformList<TerraformMap<object>> Telemetry
        => AsReference("telemetry");

    /// <summary>
    /// BasicService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicService block(s) allowed")]
    public TerraformList<GoogleMonitoringServiceBasicServiceBlock>? BasicService
    {
        get => GetArgument<TerraformList<GoogleMonitoringServiceBasicServiceBlock>>("basic_service");
        set => SetArgument("basic_service", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMonitoringServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMonitoringServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
