using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleLustreInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a google_lustre_instance resource.
/// </summary>
public class GoogleLustreInstance : TerraformResource
{
    public GoogleLustreInstance(string name) : base("google_lustre_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("mount_point");
        this.WithOutput("name");
        this.WithOutput("state");
        this.WithOutput("terraform_labels");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The storage capacity of the instance in gibibytes (GiB). Allowed values
    /// are from &#39;18000&#39; to &#39;954000&#39;, in increments of 9000.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityGib is required")]
    public required TerraformProperty<string> CapacityGib
    {
        get => GetRequiredProperty<TerraformProperty<string>>("capacity_gib");
        set => this.WithProperty("capacity_gib", value);
    }

    /// <summary>
    /// A user-readable description of the instance.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The filesystem name for this instance. This name is used by client-side
    /// tools, including when mounting the instance. Must be eight characters or
    /// less and can only contain letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filesystem is required")]
    public required TerraformProperty<string> Filesystem
    {
        get => GetRequiredProperty<TerraformProperty<string>>("filesystem");
        set => this.WithProperty("filesystem", value);
    }

    /// <summary>
    /// Indicates whether you want to enable support for GKE clients. By default,
    /// GKE clients are not supported.
    /// </summary>
    public TerraformProperty<bool>? GkeSupportEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("gke_support_enabled");
        set => this.WithProperty("gke_support_enabled", value);
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
    /// The name of the Managed Lustre instance.
    /// 
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The full name of the VPC network to which the instance is connected.
    /// Must be in the format
    /// &#39;projects/{project_id}/global/networks/{network_name}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The throughput of the instance in MB/s/TiB.
    /// Valid values are 125, 250, 500, 1000.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerUnitStorageThroughput is required")]
    public required TerraformProperty<string> PerUnitStorageThroughput
    {
        get => GetRequiredProperty<TerraformProperty<string>>("per_unit_storage_throughput");
        set => this.WithProperty("per_unit_storage_throughput", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleLustreInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleLustreInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Timestamp when the instance was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Mount point of the instance in the format &#39;IP_ADDRESS@tcp:/FILESYSTEM&#39;.
    /// </summary>
    public TerraformExpression MountPoint => this["mount_point"];

    /// <summary>
    /// Identifier. The name of the instance.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The state of the instance.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// CREATING
    /// DELETING
    /// UPGRADING
    /// REPAIRING
    /// STOPPED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Timestamp when the instance was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
