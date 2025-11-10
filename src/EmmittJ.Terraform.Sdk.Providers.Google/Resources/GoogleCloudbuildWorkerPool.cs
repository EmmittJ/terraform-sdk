using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildWorkerPoolNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Required. Immutable. The network definition that the workers are peered to. If this section is left empty, the workers will be peered to `WorkerPool.project_id` on the service producer network. Must be in the format `projects/{project}/global/networks/{network}`, where `{project}` is a project number, such as `12345`, and `{network}` is the name of a VPC network in the project. See [Understanding network configuration options](https://cloud.google.com/cloud-build/docs/custom-workers/set-up-custom-worker-pool-environment#understanding_the_network_configuration_options)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeredNetwork is required")]
    public required TerraformProperty<string> PeeredNetwork
    {
        get => GetProperty<TerraformProperty<string>>("peered_network");
        set => WithProperty("peered_network", value);
    }

    /// <summary>
    /// Optional. Immutable. Subnet IP range within the peered network. This is specified in CIDR notation with a slash and the subnet prefix size. You can optionally specify an IP address before the subnet prefix value. e.g. `192.168.0.0/29` would specify an IP range starting at 192.168.0.0 with a prefix size of 29 bits. `/16` would specify a prefix size of 16 bits, with an automatically determined IP within the peered VPC. If unspecified, a value of `/24` will be used.
    /// </summary>
    public TerraformProperty<string>? PeeredNetworkIpRange
    {
        get => GetProperty<TerraformProperty<string>>("peered_network_ip_range");
        set => WithProperty("peered_network_ip_range", value);
    }

}

/// <summary>
/// Block type for private_service_connect in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildWorkerPoolPrivateServiceConnectBlock : TerraformBlock
{
    /// <summary>
    /// Required. Immutable. The network attachment that the worker network interface is connected to. Must be in the format `projects/{project}/regions/{region}/networkAttachments/{networkAttachment}`. The region of network attachment must be the same as the worker pool. See [Network Attachments](https://cloud.google.com/vpc/docs/about-network-attachments)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAttachment is required")]
    public required TerraformProperty<string> NetworkAttachment
    {
        get => GetProperty<TerraformProperty<string>>("network_attachment");
        set => WithProperty("network_attachment", value);
    }

    /// <summary>
    /// Immutable. Route all traffic through PSC interface. Enable this if you want full control of traffic in the private pool. Configure Cloud NAT for the subnet of network attachment if you need to access public Internet. If false, Only route private IPs, e.g. 10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16 through PSC interface.
    /// </summary>
    public TerraformProperty<bool>? RouteAllTraffic
    {
        get => GetProperty<TerraformProperty<bool>>("route_all_traffic");
        set => WithProperty("route_all_traffic", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudbuildWorkerPoolTimeoutsBlock : TerraformBlock
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
/// Block type for worker_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildWorkerPoolWorkerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Size of the disk attached to the worker, in GB. See [Worker pool config file](https://cloud.google.com/cloud-build/docs/custom-workers/worker-pool-config-file). Specify a value of up to 1000. If `0` is specified, Cloud Build will use a standard disk size.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// Enable nested virtualization on the worker, if supported by the machine type. See [Worker pool config file](https://cloud.google.com/build/docs/private-pools/worker-pool-config-file-schema). If left blank, Cloud Build will set this to false.
    /// </summary>
    public TerraformProperty<bool>? EnableNestedVirtualization
    {
        get => GetProperty<TerraformProperty<bool>>("enable_nested_virtualization");
        set => WithProperty("enable_nested_virtualization", value);
    }

    /// <summary>
    /// Machine type of a worker, such as `n1-standard-1`. See [Worker pool config file](https://cloud.google.com/cloud-build/docs/custom-workers/worker-pool-config-file). If left blank, Cloud Build will use `n1-standard-1`.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        get => GetProperty<TerraformProperty<string>>("machine_type");
        set => WithProperty("machine_type", value);
    }

    /// <summary>
    /// If true, workers are created without any public address, which prevents network egress to public IPs.
    /// </summary>
    public TerraformProperty<bool>? NoExternalIp
    {
        get => GetProperty<TerraformProperty<bool>>("no_external_ip");
        set => WithProperty("no_external_ip", value);
    }

}

/// <summary>
/// Manages a google_cloudbuild_worker_pool resource.
/// </summary>
public class GoogleCloudbuildWorkerPool : TerraformResource
{
    public GoogleCloudbuildWorkerPool(string name) : base("google_cloudbuild_worker_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("state");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// User specified annotations. See https://google.aip.dev/128#annotations for more details such as format and size limitations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// A user-specified, human-readable name for the `WorkerPool`. If provided, this value must be 1-63 characters.
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
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// User-defined name of the `WorkerPool`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleCloudbuildWorkerPoolNetworkConfigBlock>? NetworkConfig
    {
        get => GetProperty<List<GoogleCloudbuildWorkerPoolNetworkConfigBlock>>("network_config");
        set => this.WithProperty("network_config", value);
    }

    /// <summary>
    /// Block for private_service_connect.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnect block(s) allowed")]
    public List<GoogleCloudbuildWorkerPoolPrivateServiceConnectBlock>? PrivateServiceConnect
    {
        get => GetProperty<List<GoogleCloudbuildWorkerPoolPrivateServiceConnectBlock>>("private_service_connect");
        set => this.WithProperty("private_service_connect", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudbuildWorkerPoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCloudbuildWorkerPoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfig block(s) allowed")]
    public List<GoogleCloudbuildWorkerPoolWorkerConfigBlock>? WorkerConfig
    {
        get => GetProperty<List<GoogleCloudbuildWorkerPoolWorkerConfigBlock>>("worker_config");
        set => this.WithProperty("worker_config", value);
    }

    /// <summary>
    /// Output only. Time at which the request to create the `WorkerPool` was received.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. Time at which the request to delete the `WorkerPool` was received.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// Output only. `WorkerPool` state. Possible values: STATE_UNSPECIFIED, PENDING, APPROVED, REJECTED, CANCELLED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. A unique identifier for the `WorkerPool`.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. Time at which the request to update the `WorkerPool` was received.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
