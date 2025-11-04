using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_monitoring_istio_canonical_service.
/// </summary>
public class GoogleMonitoringIstioCanonicalServiceDataSource : TerraformDataSource
{
    public GoogleMonitoringIstioCanonicalServiceDataSource(string name) : base("google_monitoring_istio_canonical_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("display_name");
        this.DeclareOutput("name");
        this.DeclareOutput("service_id");
        this.DeclareOutput("telemetry");
        this.DeclareOutput("user_labels");
    }

    /// <summary>
    /// The name of the canonical service underlying this service.. 
    ///                         Corresponds to the destination_service_name metric label in Istio metrics.
    /// </summary>
    public string? CanonicalService
    {
        get => GetProperty<TerraformLiteralProperty<string>>("canonical_service")?.Value;
        set => this.WithProperty("canonical_service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace of the canonical service underlying this service.
    ///                         Corresponds to the destination_service_namespace metric label in Istio metrics.
    /// </summary>
    public string? CanonicalServiceNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("canonical_service_namespace")?.Value;
        set => this.WithProperty("canonical_service_namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Identifier for the Istio mesh in which this canonical service is defined.
    ///                         Corresponds to the meshUid metric label in Istio metrics.
    /// </summary>
    public string? MeshUid
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mesh_uid")?.Value;
        set => this.WithProperty("mesh_uid", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
