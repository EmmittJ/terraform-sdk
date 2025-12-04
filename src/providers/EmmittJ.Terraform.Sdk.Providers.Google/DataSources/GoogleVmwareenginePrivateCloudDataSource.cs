using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_vmwareengine_private_cloud Terraform data source.
/// Retrieves information about a google_vmwareengine_private_cloud.
/// </summary>
public partial class GoogleVmwareenginePrivateCloudDataSource(string name) : TerraformDataSource("google_vmwareengine_private_cloud", name)
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
    /// The location where the PrivateCloud should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the PrivateCloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Time when the resource was scheduled for deletion.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => AsReference("delete_time");

    /// <summary>
    /// The number of hours to delay this request. You can set this value to an hour between 0 to 8, where setting it to 0 starts the deletion request immediately. If no value is set, a default value is set at the API Level.
    /// </summary>
    public TerraformValue<double> DeletionDelayHours
        => AsReference("deletion_delay_hours");

    /// <summary>
    /// User-provided description for this private cloud.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// Time when the resource will be irreversibly deleted.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> ExpireTime
        => AsReference("expire_time");

    /// <summary>
    /// Details about a HCX Cloud Manager appliance.
    /// </summary>
    public TerraformList<TerraformMap<object>> Hcx
        => AsReference("hcx");

    /// <summary>
    /// The management cluster for this private cloud. This used for creating and managing the default cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagementCluster
        => AsReference("management_cluster");

    /// <summary>
    /// Network configuration in the consumer project with which the peering has to be done.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkConfig
        => AsReference("network_config");

    /// <summary>
    /// Details about a NSX Manager appliance.
    /// </summary>
    public TerraformList<TerraformMap<object>> Nsx
        => AsReference("nsx");

    /// <summary>
    /// While set true, deletion_delay_hours value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the deletion_delay_hours field. It can be used both alone and together with deletion_delay_hours.
    /// </summary>
    public TerraformValue<bool> SendDeletionDelayHoursIfZero
        => AsReference("send_deletion_delay_hours_if_zero");

    /// <summary>
    /// State of the resource. New values may be added to this enum when appropriate.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Initial type of the private cloud. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;TIME_LIMITED&amp;quot;, &amp;quot;STRETCHED&amp;quot;]
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Last update time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Details about a vCenter Server management appliance.
    /// </summary>
    public TerraformList<TerraformMap<object>> Vcenter
        => AsReference("vcenter");

}
