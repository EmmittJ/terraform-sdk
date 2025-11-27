using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_monitoring_cluster_istio_service Terraform data source.
/// Retrieves information about a google_monitoring_cluster_istio_service.
/// </summary>
public partial class GoogleMonitoringClusterIstioServiceDataSource(string name) : TerraformDataSource("google_monitoring_cluster_istio_service", name)
{
    /// <summary>
    /// The name of the Kubernetes cluster in which this Istio service is defined. 
    ///                         Corresponds to the clusterName resource label in k8s_cluster resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
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
    /// The location of the Kubernetes cluster in which this Istio service is defined. 
    ///                         Corresponds to the location resource label in k8s_cluster resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the Istio service underlying this service. 
    ///                         Corresponds to the destination_service_name metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The namespace of the Istio service underlying this service. 
    ///                         Corresponds to the destination_service_namespace metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformValue<string> ServiceNamespace
    {
        get => new TerraformReference<string>(this, "service_namespace");
        set => SetArgument("service_namespace", value);
    }

    /// <summary>
    /// Name used for UI elements listing this Service.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    public TerraformValue<string> ServiceId
    {
        get => new TerraformReference<string>(this, "service_id");
    }

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    public TerraformList<TerraformMap<object>> Telemetry
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "telemetry").ResolveNodes(ctx));
    }

    /// <summary>
    /// Labels which have been used to annotate the service. Label keys must start
    /// with a letter. Label keys and values may contain lowercase letters,
    /// numbers, underscores, and dashes. Label keys and values have a maximum
    /// length of 63 characters, and must be less than 128 bytes in size. Up to 64
    /// label entries may be stored. For labels which do not have a semantic value,
    /// the empty string may be supplied for the label value.
    /// </summary>
    public TerraformMap<string> UserLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "user_labels").ResolveNodes(ctx));
    }

}
