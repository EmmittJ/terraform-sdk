using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_private_cloud.
/// </summary>
public class GoogleVmwareenginePrivateCloudDataSource : TerraformDataSource
{
    public GoogleVmwareenginePrivateCloudDataSource(string name) : base("google_vmwareengine_private_cloud", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("deletion_delay_hours");
        this.DeclareOutput("description");
        this.DeclareOutput("expire_time");
        this.DeclareOutput("hcx");
        this.DeclareOutput("management_cluster");
        this.DeclareOutput("network_config");
        this.DeclareOutput("nsx");
        this.DeclareOutput("send_deletion_delay_hours_if_zero");
        this.DeclareOutput("state");
        this.DeclareOutput("type");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("vcenter");
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
    /// The location where the PrivateCloud should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The ID of the PrivateCloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Time when the resource was scheduled for deletion.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// The number of hours to delay this request. You can set this value to an hour between 0 to 8, where setting it to 0 starts the deletion request immediately. If no value is set, a default value is set at the API Level.
    /// </summary>
    public TerraformExpression DeletionDelayHours => this["deletion_delay_hours"];

    /// <summary>
    /// User-provided description for this private cloud.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Time when the resource will be irreversibly deleted.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// Details about a HCX Cloud Manager appliance.
    /// </summary>
    public TerraformExpression Hcx => this["hcx"];

    /// <summary>
    /// The management cluster for this private cloud. This used for creating and managing the default cluster.
    /// </summary>
    public TerraformExpression ManagementCluster => this["management_cluster"];

    /// <summary>
    /// Network configuration in the consumer project with which the peering has to be done.
    /// </summary>
    public TerraformExpression NetworkConfig => this["network_config"];

    /// <summary>
    /// Details about a NSX Manager appliance.
    /// </summary>
    public TerraformExpression Nsx => this["nsx"];

    /// <summary>
    /// While set true, deletion_delay_hours value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the deletion_delay_hours field. It can be used both alone and together with deletion_delay_hours.
    /// </summary>
    public TerraformExpression SendDeletionDelayHoursIfZero => this["send_deletion_delay_hours_if_zero"];

    /// <summary>
    /// State of the resource. New values may be added to this enum when appropriate.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Initial type of the private cloud. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;TIME_LIMITED&amp;quot;, &amp;quot;STRETCHED&amp;quot;]
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Last update time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Details about a vCenter Server management appliance.
    /// </summary>
    public TerraformExpression Vcenter => this["vcenter"];

}
