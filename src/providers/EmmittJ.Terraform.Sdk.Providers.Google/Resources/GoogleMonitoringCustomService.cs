using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for telemetry in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringCustomServiceTelemetryBlock : TerraformBlock
{
    /// <summary>
    /// The full name of the resource that defines this service.
    /// Formatted as described in
    /// https://cloud.google.com/apis/design/resource_names.
    /// </summary>
    public TerraformProperty<string>? ResourceName
    {
        get => GetProperty<TerraformProperty<string>>("resource_name");
        set => WithProperty("resource_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringCustomServiceTimeoutsBlock : TerraformBlock
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
/// Manages a google_monitoring_custom_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMonitoringCustomService : TerraformResource
{
    public GoogleMonitoringCustomService(string name) : base("google_monitoring_custom_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
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
    public TerraformProperty<string>? ServiceId
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
    /// Block for telemetry.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Telemetry block(s) allowed")]
    public List<GoogleMonitoringCustomServiceTelemetryBlock>? Telemetry
    {
        get => GetProperty<List<GoogleMonitoringCustomServiceTelemetryBlock>>("telemetry");
        set => this.WithProperty("telemetry", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMonitoringCustomServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleMonitoringCustomServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    public TerraformExpression Name => this["name"];

}
