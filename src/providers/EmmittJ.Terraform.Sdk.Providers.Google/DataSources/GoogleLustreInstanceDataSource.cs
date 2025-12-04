using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_lustre_instance Terraform data source.
/// Retrieves information about a google_lustre_instance.
/// </summary>
public partial class GoogleLustreInstanceDataSource(string name) : TerraformDataSource("google_lustre_instance", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    public required TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
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
    /// Zone of Lustre instance
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The storage capacity of the instance in gibibytes (GiB). Allowed values
    /// are from &#39;18000&#39; to &#39;954000&#39;, in increments of 9000.
    /// </summary>
    public TerraformValue<string> CapacityGib
        => AsReference("capacity_gib");

    /// <summary>
    /// Timestamp when the instance was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// A user-readable description of the instance.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The filesystem name for this instance. This name is used by client-side
    /// tools, including when mounting the instance. Must be eight characters or
    /// less and can only contain letters and numbers.
    /// </summary>
    public TerraformValue<string> Filesystem
        => AsReference("filesystem");

    /// <summary>
    /// Indicates whether you want to enable support for GKE clients. By default,
    /// GKE clients are not supported.
    /// </summary>
    public TerraformValue<bool> GkeSupportEnabled
        => AsReference("gke_support_enabled");

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
        => AsReference("labels");

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// Mount point of the instance in the format &#39;IP_ADDRESS@tcp:/FILESYSTEM&#39;.
    /// </summary>
    public TerraformValue<string> MountPoint
        => AsReference("mount_point");

    /// <summary>
    /// Identifier. The name of the instance.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The full name of the VPC network to which the instance is connected.
    /// Must be in the format
    /// &#39;projects/{project_id}/global/networks/{network_name}&#39;.
    /// </summary>
    public TerraformValue<string> Network
        => AsReference("network");

    /// <summary>
    /// The throughput of the instance in MB/s/TiB.
    /// Valid values are 125, 250, 500, 1000.
    /// </summary>
    public TerraformValue<string> PerUnitStorageThroughput
        => AsReference("per_unit_storage_throughput");

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
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Timestamp when the instance was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

}
