using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_monitoring_cluster_istio_service.
/// </summary>
public class GoogleMonitoringClusterIstioServiceDataSource : TerraformDataSource
{
    public GoogleMonitoringClusterIstioServiceDataSource(string name) : base("google_monitoring_cluster_istio_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("display_name");
        this.WithOutput("name");
        this.WithOutput("service_id");
        this.WithOutput("telemetry");
        this.WithOutput("user_labels");
    }

    /// <summary>
    /// The name of the Kubernetes cluster in which this Istio service is defined. 
    ///                         Corresponds to the clusterName resource label in k8s_cluster resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
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
    /// The location of the Kubernetes cluster in which this Istio service is defined. 
    ///                         Corresponds to the location resource label in k8s_cluster resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The name of the Istio service underlying this service. 
    ///                         Corresponds to the destination_service_name metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
    }

    /// <summary>
    /// The namespace of the Istio service underlying this service. 
    ///                         Corresponds to the destination_service_namespace metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    public required TerraformProperty<string> ServiceNamespace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_namespace");
        set => this.WithProperty("service_namespace", value);
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
