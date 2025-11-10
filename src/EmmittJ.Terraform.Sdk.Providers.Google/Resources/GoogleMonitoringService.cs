using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_service in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringServiceBasicServiceBlock : TerraformBlock
{
    /// <summary>
    /// Labels that specify the resource that emits the monitoring data
    /// which is used for SLO reporting of this &#39;Service&#39;.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ServiceLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("service_labels");
        set => WithProperty("service_labels", value);
    }

    /// <summary>
    /// The type of service that this basic service defines, e.g.
    /// APP_ENGINE service type
    /// </summary>
    public TerraformProperty<string>? ServiceType
    {
        get => GetProperty<TerraformProperty<string>>("service_type");
        set => WithProperty("service_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_monitoring_service resource.
/// </summary>
public class GoogleMonitoringService : TerraformResource
{
    public GoogleMonitoringService(string name) : base("google_monitoring_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("telemetry");
    }

    /// <summary>
    /// Name used for UI elements listing this Service.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformProperty<string> ServiceId
    {
        get => GetProperty<TerraformProperty<string>>("service_id");
        set => this.WithProperty("service_id", value);
    }

    /// <summary>
    /// Labels which have been used to annotate the service. Label keys must start
    /// with a letter. Label keys and values may contain lowercase letters,
    /// numbers, underscores, and dashes. Label keys and values have a maximum
    /// length of 63 characters, and must be less than 128 bytes in size. Up to 64
    /// label entries may be stored. For labels which do not have a semantic value,
    /// the empty string may be supplied for the label value.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? UserLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("user_labels");
        set => this.WithProperty("user_labels", value);
    }

    /// <summary>
    /// Block for basic_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicService block(s) allowed")]
    public List<GoogleMonitoringServiceBasicServiceBlock>? BasicService
    {
        get => GetProperty<List<GoogleMonitoringServiceBasicServiceBlock>>("basic_service");
        set => this.WithProperty("basic_service", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMonitoringServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleMonitoringServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    public TerraformExpression Telemetry => this["telemetry"];

}
