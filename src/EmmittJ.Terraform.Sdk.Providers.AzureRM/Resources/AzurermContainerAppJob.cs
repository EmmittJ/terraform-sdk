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
    public string? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_app_environment_id")?.Value;
        set => this.WithProperty("container_app_environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replica_retry_limit attribute.
    /// </summary>
    public double? ReplicaRetryLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replica_retry_limit")?.Value;
        set => this.WithProperty("replica_retry_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The replica_timeout_in_seconds attribute.
    /// </summary>
    public double? ReplicaTimeoutInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replica_timeout_in_seconds")?.Value;
        set => this.WithProperty("replica_timeout_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    public string? WorkloadProfileName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workload_profile_name")?.Value;
        set => this.WithProperty("workload_profile_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
