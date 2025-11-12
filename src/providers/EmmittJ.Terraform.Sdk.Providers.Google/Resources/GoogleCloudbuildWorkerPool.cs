using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudbuildWorkerPoolNetworkConfigBlock() : TerraformBlock("network_config")
{
    /// <summary>
    /// Required. Immutable. The network definition that the workers are peered to. If this section is left empty, the workers will be peered to `WorkerPool.project_id` on the service producer network. Must be in the format `projects/{project}/global/networks/{network}`, where `{project}` is a project number, such as `12345`, and `{network}` is the name of a VPC network in the project. See [Understanding network configuration options](https://cloud.google.com/cloud-build/docs/custom-workers/set-up-custom-worker-pool-environment#understanding_the_network_configuration_options)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeredNetwork is required")]
    [TerraformProperty("peered_network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeeredNetwork { get; set; }

    /// <summary>
    /// Optional. Immutable. Subnet IP range within the peered network. This is specified in CIDR notation with a slash and the subnet prefix size. You can optionally specify an IP address before the subnet prefix value. e.g. `192.168.0.0/29` would specify an IP range starting at 192.168.0.0 with a prefix size of 29 bits. `/16` would specify a prefix size of 16 bits, with an automatically determined IP within the peered VPC. If unspecified, a value of `/24` will be used.
    /// </summary>
    [TerraformProperty("peered_network_ip_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PeeredNetworkIpRange { get; set; }

}

/// <summary>
/// Block type for private_service_connect in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudbuildWorkerPoolPrivateServiceConnectBlock() : TerraformBlock("private_service_connect")
{
    /// <summary>
    /// Required. Immutable. The network attachment that the worker network interface is connected to. Must be in the format `projects/{project}/regions/{region}/networkAttachments/{networkAttachment}`. The region of network attachment must be the same as the worker pool. See [Network Attachments](https://cloud.google.com/vpc/docs/about-network-attachments)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAttachment is required")]
    [TerraformProperty("network_attachment")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkAttachment { get; set; }

    /// <summary>
    /// Immutable. Route all traffic through PSC interface. Enable this if you want full control of traffic in the private pool. Configure Cloud NAT for the subnet of network attachment if you need to access public Internet. If false, Only route private IPs, e.g. 10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16 through PSC interface.
    /// </summary>
    [TerraformProperty("route_all_traffic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RouteAllTraffic { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudbuildWorkerPoolTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for worker_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudbuildWorkerPoolWorkerConfigBlock() : TerraformBlock("worker_config")
{
    /// <summary>
    /// Size of the disk attached to the worker, in GB. See [Worker pool config file](https://cloud.google.com/cloud-build/docs/custom-workers/worker-pool-config-file). Specify a value of up to 1000. If `0` is specified, Cloud Build will use a standard disk size.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DiskSizeGb { get; set; }

    /// <summary>
    /// Enable nested virtualization on the worker, if supported by the machine type. See [Worker pool config file](https://cloud.google.com/build/docs/private-pools/worker-pool-config-file-schema). If left blank, Cloud Build will set this to false.
    /// </summary>
    [TerraformProperty("enable_nested_virtualization")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableNestedVirtualization { get; set; }

    /// <summary>
    /// Machine type of a worker, such as `n1-standard-1`. See [Worker pool config file](https://cloud.google.com/cloud-build/docs/custom-workers/worker-pool-config-file). If left blank, Cloud Build will use `n1-standard-1`.
    /// </summary>
    [TerraformProperty("machine_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MachineType { get; set; }

    /// <summary>
    /// If true, workers are created without any public address, which prevents network egress to public IPs.
    /// </summary>
    [TerraformProperty("no_external_ip")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> NoExternalIp { get; set; }

}

/// <summary>
/// Manages a google_cloudbuild_worker_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudbuildWorkerPool : TerraformResource
{
    public GoogleCloudbuildWorkerPool(string name) : base("google_cloudbuild_worker_pool", name)
    {
    }

    /// <summary>
    /// User specified annotations. See https://google.aip.dev/128#annotations for more details such as format and size limitations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// A user-specified, human-readable name for the `WorkerPool`. If provided, this value must be 1-63 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// User-defined name of the `WorkerPool`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public TerraformList<GoogleCloudbuildWorkerPoolNetworkConfigBlock> NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for private_service_connect.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnect block(s) allowed")]
    [TerraformProperty("private_service_connect")]
    public TerraformList<GoogleCloudbuildWorkerPoolPrivateServiceConnectBlock> PrivateServiceConnect { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleCloudbuildWorkerPoolTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfig block(s) allowed")]
    [TerraformProperty("worker_config")]
    public TerraformList<GoogleCloudbuildWorkerPoolWorkerConfigBlock> WorkerConfig { get; set; } = new();

    /// <summary>
    /// Output only. Time at which the request to create the `WorkerPool` was received.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. Time at which the request to delete the `WorkerPool` was received.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// Output only. `WorkerPool` state. Possible values: STATE_UNSPECIFIED, PENDING, APPROVED, REJECTED, CANCELLED
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Output only. A unique identifier for the `WorkerPool`.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. Time at which the request to update the `WorkerPool` was received.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
