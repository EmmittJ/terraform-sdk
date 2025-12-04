using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_monitoring_istio_canonical_service Terraform data source.
/// Retrieves information about a google_monitoring_istio_canonical_service.
/// </summary>
public partial class GoogleMonitoringIstioCanonicalServiceDataSource(string name) : TerraformDataSource("google_monitoring_istio_canonical_service", name)
{
    /// <summary>
    /// The name of the canonical service underlying this service.. 
    ///                         Corresponds to the destination_service_name metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CanonicalService is required")]
    public required TerraformValue<string> CanonicalService
    {
        get => GetArgument<TerraformValue<string>>("canonical_service");
        set => SetArgument("canonical_service", value);
    }

    /// <summary>
    /// The namespace of the canonical service underlying this service.
    ///                         Corresponds to the destination_service_namespace metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CanonicalServiceNamespace is required")]
    public required TerraformValue<string> CanonicalServiceNamespace
    {
        get => GetArgument<TerraformValue<string>>("canonical_service_namespace");
        set => SetArgument("canonical_service_namespace", value);
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
    /// Identifier for the Istio mesh in which this canonical service is defined.
    ///                         Corresponds to the meshUid metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeshUid is required")]
    public required TerraformValue<string> MeshUid
    {
        get => GetArgument<TerraformValue<string>>("mesh_uid");
        set => SetArgument("mesh_uid", value);
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
    /// Name used for UI elements listing this Service.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    public TerraformValue<string> ServiceId
        => AsReference("service_id");

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    public TerraformList<TerraformMap<object>> Telemetry
        => AsReference("telemetry");

    /// <summary>
    /// Labels which have been used to annotate the service. Label keys must start
    /// with a letter. Label keys and values may contain lowercase letters,
    /// numbers, underscores, and dashes. Label keys and values have a maximum
    /// length of 63 characters, and must be less than 128 bytes in size. Up to 64
    /// label entries may be stored. For labels which do not have a semantic value,
    /// the empty string may be supplied for the label value.
    /// </summary>
    public TerraformMap<string> UserLabels
        => AsReference("user_labels");

}
