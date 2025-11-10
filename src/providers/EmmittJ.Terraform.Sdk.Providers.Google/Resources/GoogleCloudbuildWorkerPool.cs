using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildWorkerPoolNetworkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Required. Immutable. The network definition that the workers are peered to. If this section is left empty, the workers will be peered to `WorkerPool.project_id` on the service producer network. Must be in the format `projects/{project}/global/networks/{network}`, where `{project}` is a project number, such as `12345`, and `{network}` is the name of a VPC network in the project. See [Understanding network configuration options](https://cloud.google.com/cloud-build/docs/custom-workers/set-up-custom-worker-pool-environment#understanding_the_network_configuration_options)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeredNetwork is required")]
    [TerraformPropertyName("peered_network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PeeredNetwork { get; set; }

    /// <summary>
    /// Optional. Immutable. Subnet IP range within the peered network. This is specified in CIDR notation with a slash and the subnet prefix size. You can optionally specify an IP address before the subnet prefix value. e.g. `192.168.0.0/29` would specify an IP range starting at 192.168.0.0 with a prefix size of 29 bits. `/16` would specify a prefix size of 16 bits, with an automatically determined IP within the peered VPC. If unspecified, a value of `/24` will be used.
    /// </summary>
    [TerraformPropertyName("peered_network_ip_range")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PeeredNetworkIpRange { get; set; }

}

/// <summary>
/// Block type for private_service_connect in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildWorkerPoolPrivateServiceConnectBlock : ITerraformBlock
{
    /// <summary>
    /// Required. Immutable. The network attachment that the worker network interface is connected to. Must be in the format `projects/{project}/regions/{region}/networkAttachments/{networkAttachment}`. The region of network attachment must be the same as the worker pool. See [Network Attachments](https://cloud.google.com/vpc/docs/about-network-attachments)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAttachment is required")]
    [TerraformPropertyName("network_attachment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkAttachment { get; set; }

    /// <summary>
    /// Immutable. Route all traffic through PSC interface. Enable this if you want full control of traffic in the private pool. Configure Cloud NAT for the subnet of network attachment if you need to access public Internet. If false, Only route private IPs, e.g. 10.0.0.0/8, 172.16.0.0/12, and 192.168.0.0/16 through PSC interface.
    /// </summary>
    [TerraformPropertyName("route_all_traffic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RouteAllTraffic { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudbuildWorkerPoolTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for worker_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudbuildWorkerPoolWorkerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Size of the disk attached to the worker, in GB. See [Worker pool config file](https://cloud.google.com/cloud-build/docs/custom-workers/worker-pool-config-file). Specify a value of up to 1000. If `0` is specified, Cloud Build will use a standard disk size.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DiskSizeGb { get; set; }

    /// <summary>
    /// Enable nested virtualization on the worker, if supported by the machine type. See [Worker pool config file](https://cloud.google.com/build/docs/private-pools/worker-pool-config-file-schema). If left blank, Cloud Build will set this to false.
    /// </summary>
    [TerraformPropertyName("enable_nested_virtualization")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableNestedVirtualization { get; set; }

    /// <summary>
    /// Machine type of a worker, such as `n1-standard-1`. See [Worker pool config file](https://cloud.google.com/cloud-build/docs/custom-workers/worker-pool-config-file). If left blank, Cloud Build will use `n1-standard-1`.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MachineType { get; set; }

    /// <summary>
    /// If true, workers are created without any public address, which prevents network egress to public IPs.
    /// </summary>
    [TerraformPropertyName("no_external_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> NoExternalIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "no_external_ip");

}

/// <summary>
/// Manages a google_cloudbuild_worker_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudbuildWorkerPool : TerraformResource
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// A user-specified, human-readable name for the `WorkerPool`. If provided, this value must be 1-63 characters.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// User-defined name of the `WorkerPool`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<GoogleCloudbuildWorkerPoolNetworkConfigBlock>>? NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for private_service_connect.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnect block(s) allowed")]
    [TerraformPropertyName("private_service_connect")]
    public TerraformList<TerraformBlock<GoogleCloudbuildWorkerPoolPrivateServiceConnectBlock>>? PrivateServiceConnect { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudbuildWorkerPoolTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for worker_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfig block(s) allowed")]
    [TerraformPropertyName("worker_config")]
    public TerraformList<TerraformBlock<GoogleCloudbuildWorkerPoolWorkerConfigBlock>>? WorkerConfig { get; set; } = new();

    /// <summary>
    /// Output only. Time at which the request to create the `WorkerPool` was received.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Output only. Time at which the request to delete the `WorkerPool` was received.
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeleteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// Output only. `WorkerPool` state. Possible values: STATE_UNSPECIFIED, PENDING, APPROVED, REJECTED, CANCELLED
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Output only. A unique identifier for the `WorkerPool`.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Output only. Time at which the request to update the `WorkerPool` was received.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
