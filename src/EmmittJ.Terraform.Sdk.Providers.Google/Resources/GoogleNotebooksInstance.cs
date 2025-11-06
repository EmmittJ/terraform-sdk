using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_notebooks_instance resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class GoogleNotebooksInstance : TerraformResource
{
    public GoogleNotebooksInstance(string name) : base("google_notebooks_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("proxy_uri");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The size of the boot disk in GB attached to this instance,
    /// up to a maximum of 64000 GB (64 TB). The minimum recommended value is 100 GB.
    /// If not specified, this defaults to 100.
    /// </summary>
    public double? BootDiskSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("boot_disk_size_gb")?.Value;
        set => this.WithProperty("boot_disk_size_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Possible disk types for notebook instances. Possible values: [&amp;quot;DISK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PD_STANDARD&amp;quot;, &amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_BALANCED&amp;quot;, &amp;quot;PD_EXTREME&amp;quot;]
    /// </summary>
    public string? BootDiskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("boot_disk_type")?.Value;
        set => this.WithProperty("boot_disk_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Instance creation time
    /// </summary>
    public string? CreateTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_time")?.Value;
        set => this.WithProperty("create_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specify a custom Cloud Storage path where the GPU driver is stored.
    /// If not specified, we&#39;ll automatically choose from official GPU drivers.
    /// </summary>
    public string? CustomGpuDriverPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_gpu_driver_path")?.Value;
        set => this.WithProperty("custom_gpu_driver_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The size of the data disk in GB attached to this instance,
    /// up to a maximum of 64000 GB (64 TB).
    /// You can choose the size of the data disk based on how big your notebooks and data are.
    /// If not specified, this defaults to 100.
    /// </summary>
    public double? DataDiskSizeGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("data_disk_size_gb")?.Value;
        set => this.WithProperty("data_disk_size_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Possible disk types for notebook instances. Possible values: [&amp;quot;DISK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PD_STANDARD&amp;quot;, &amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_BALANCED&amp;quot;, &amp;quot;PD_EXTREME&amp;quot;]
    /// </summary>
    public string? DataDiskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_disk_type")?.Value;
        set => this.WithProperty("data_disk_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Desired state of the Notebook Instance. Set this field to &#39;ACTIVE&#39; to start the Instance, and &#39;STOPPED&#39; to stop the Instance.
    /// </summary>
    public string? DesiredState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("desired_state")?.Value;
        set => this.WithProperty("desired_state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Disk encryption method used on the boot and data disks, defaults to GMEK. Possible values: [&amp;quot;DISK_ENCRYPTION_UNSPECIFIED&amp;quot;, &amp;quot;GMEK&amp;quot;, &amp;quot;CMEK&amp;quot;]
    /// </summary>
    public string? DiskEncryption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_encryption")?.Value;
        set => this.WithProperty("disk_encryption", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Whether the end user authorizes Google Cloud to install GPU driver
    /// on this instance. If this field is empty or set to false, the GPU driver
    /// won&#39;t be installed. Only applicable to instances with GPUs.
    /// </summary>
    public bool? InstallGpuDriver
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("install_gpu_driver")?.Value;
        set => this.WithProperty("install_gpu_driver", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The list of owners of this instance after creation.
    /// Format: alias@example.com.
    /// Currently supports one owner only.
    /// If not specified, all of the service account users of
    /// your VM instance&#39;s service account can use the instance.
    /// </summary>
    public List<string>? InstanceOwners
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("instance_owners")?.Value;
        set => this.WithProperty("instance_owners", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The KMS key used to encrypt the disks, only applicable if diskEncryption is CMEK.
    /// Format: projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}
    /// </summary>
    public string? KmsKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key")?.Value;
        set => this.WithProperty("kms_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Labels to apply to this instance. These can be later modified by the setLabels method.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A reference to a machine type which defines VM kind.
    /// </summary>
    public string? MachineType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("machine_type")?.Value;
        set => this.WithProperty("machine_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Custom metadata to apply to this instance.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The name specified for the Notebook instance.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the VPC that this instance is in.
    /// Format: projects/{project_id}/global/networks/{network_id}
    /// </summary>
    public string? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network")?.Value;
        set => this.WithProperty("network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of vNIC driver. Possible values: [&amp;quot;UNSPECIFIED_NIC_TYPE&amp;quot;, &amp;quot;VIRTIO_NET&amp;quot;, &amp;quot;GVNIC&amp;quot;]
    /// </summary>
    public string? NicType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nic_type")?.Value;
        set => this.WithProperty("nic_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notebook instance will not register with the proxy..
    /// </summary>
    public bool? NoProxyAccess
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("no_proxy_access")?.Value;
        set => this.WithProperty("no_proxy_access", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// No public IP will be assigned to this instance.
    /// </summary>
    public bool? NoPublicIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("no_public_ip")?.Value;
        set => this.WithProperty("no_public_ip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// If true, the data disk will not be auto deleted when deleting the instance.
    /// </summary>
    public bool? NoRemoveDataDisk
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("no_remove_data_disk")?.Value;
        set => this.WithProperty("no_remove_data_disk", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Path to a Bash script that automatically runs after a
    /// notebook instance fully boots up. The path must be a URL
    /// or Cloud Storage path (gs://path-to-file/file-name).
    /// </summary>
    public string? PostStartupScript
    {
        get => GetProperty<TerraformLiteralProperty<string>>("post_startup_script")?.Value;
        set => this.WithProperty("post_startup_script", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The service account on this instance, giving access to other
    /// Google Cloud services. You can use any service account within
    /// the same project, but you must have the service account user
    /// permission to use the instance. If not specified,
    /// the Compute Engine default service account is used.
    /// </summary>
    public string? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account")?.Value;
        set => this.WithProperty("service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. The URIs of service account scopes to be included in Compute Engine instances.
    /// If not specified, the following scopes are defined:
    /// - https://www.googleapis.com/auth/cloud-platform
    /// - https://www.googleapis.com/auth/userinfo.email
    /// </summary>
    public List<string>? ServiceAccountScopes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("service_account_scopes")?.Value;
        set => this.WithProperty("service_account_scopes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The name of the subnet that this instance is in.
    /// Format: projects/{project_id}/regions/{region}/subnetworks/{subnetwork_id}
    /// </summary>
    public string? Subnet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet")?.Value;
        set => this.WithProperty("subnet", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Compute Engine tags to add to instance.
    /// </summary>
    public List<string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Instance update time.
    /// </summary>
    public string? UpdateTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("update_time")?.Value;
        set => this.WithProperty("update_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The proxy endpoint that is used to access the Jupyter notebook.
    /// Only returned when the resource is in a &#39;PROVISIONED&#39; state. If
    /// needed you can utilize &#39;terraform apply -refresh-only&#39; to await
    /// the population of this value.
    /// </summary>
    public TerraformExpression ProxyUri => this["proxy_uri"];

    /// <summary>
    /// The state of this instance.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
