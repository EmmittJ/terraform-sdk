using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_monitoring_mesh_istio_service.
/// </summary>
public class GoogleMonitoringMeshIstioServiceDataSource : TerraformDataSource
{
    public GoogleMonitoringMeshIstioServiceDataSource(string name) : base("google_monitoring_mesh_istio_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("display_name");
        SetOutput("name");
        SetOutput("service_id");
        SetOutput("telemetry");
        SetOutput("user_labels");
        SetOutput("id");
        SetOutput("mesh_uid");
        SetOutput("project");
        SetOutput("service_name");
        SetOutput("service_namespace");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Identifier for the mesh in which this Istio service is defined.
    ///                         Corresponds to the meshUid metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeshUid is required")]
    public required TerraformProperty<string> MeshUid
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mesh_uid");
        set => SetProperty("mesh_uid", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The name of the Istio service underlying this service. 
    ///                         Corresponds to the destination_service_name metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
    }

    /// <summary>
    /// The namespace of the Istio service underlying this service.
    ///                         Corresponds to the destination_service_namespace metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformProperty<string> ServiceNamespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_namespace");
        set => SetProperty("service_namespace", value);
    }

    /// <summary>
    /// Name used for UI elements listing this Service.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    public TerraformExpression ServiceId => this["service_id"];

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    public TerraformExpression Telemetry => this["telemetry"];

    /// <summary>
    /// Labels which have been used to annotate the service. Label keys must start
    /// with a letter. Label keys and values may contain lowercase letters,
    /// numbers, underscores, and dashes. Label keys and values have a maximum
    /// length of 63 characters, and must be less than 128 bytes in size. Up to 64
    /// label entries may be stored. For labels which do not have a semantic value,
    /// the empty string may be supplied for the label value.
    /// </summary>
    public TerraformExpression UserLabels => this["user_labels"];

}
