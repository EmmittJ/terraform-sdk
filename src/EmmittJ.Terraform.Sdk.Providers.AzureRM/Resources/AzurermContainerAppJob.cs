using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_app_job resource.
/// </summary>
public class AzurermContainerAppJob : TerraformResource
{
    public AzurermContainerAppJob(string name) : base("azurerm_container_app_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("event_stream_endpoint");
        this.DeclareOutput("outbound_ip_addresses");
    }

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("container_app_environment_id");
        set => this.WithProperty("container_app_environment_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The replica_retry_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicaRetryLimit
    {
        get => GetProperty<TerraformProperty<double>>("replica_retry_limit");
        set => this.WithProperty("replica_retry_limit", value);
    }

    /// <summary>
    /// The replica_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ReplicaTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("replica_timeout_in_seconds");
        set => this.WithProperty("replica_timeout_in_seconds", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkloadProfileName
    {
        get => GetProperty<TerraformProperty<string>>("workload_profile_name");
        set => this.WithProperty("workload_profile_name", value);
    }

    /// <summary>
    /// The event_stream_endpoint attribute.
    /// </summary>
    public TerraformExpression EventStreamEndpoint => this["event_stream_endpoint"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

}
