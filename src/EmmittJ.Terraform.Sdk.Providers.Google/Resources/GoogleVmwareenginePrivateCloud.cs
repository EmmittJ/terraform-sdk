using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for management_cluster in .
/// Nesting mode: list
/// </summary>
public class GoogleVmwareenginePrivateCloudManagementClusterBlock : TerraformBlock
{
    /// <summary>
    /// The user-provided identifier of the new Cluster. The identifier must meet the following requirements:
    ///   * Only contains 1-63 alphanumeric characters and hyphens
    ///   * Begins with an alphabetical character
    ///   * Ends with a non-hyphen character
    ///   * Not formatted as a UUID
    ///   * Complies with RFC 1034 (https://datatracker.ietf.org/doc/html/rfc1034) (section 3.5)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => WithProperty("cluster_id", value);
    }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVmwareenginePrivateCloudNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// DNS Server IP of the Private Cloud.
    /// </summary>
    public TerraformProperty<string>? DnsServerIp
    {
        get => GetProperty<TerraformProperty<string>>("dns_server_ip");
        set => WithProperty("dns_server_ip", value);
    }

    /// <summary>
    /// Management CIDR used by VMware management appliances.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementCidr is required")]
    public required TerraformProperty<string> ManagementCidr
    {
        get => GetProperty<TerraformProperty<string>>("management_cidr");
        set => WithProperty("management_cidr", value);
    }

    /// <summary>
    /// The IP address layout version of the management IP address range.
    /// Possible versions include:
    /// * managementIpAddressLayoutVersion=1: Indicates the legacy IP address layout used by some existing private clouds. This is no longer supported for new private clouds
    /// as it does not support all features.
    /// * managementIpAddressLayoutVersion=2: Indicates the latest IP address layout
    /// used by all newly created private clouds. This version supports all current features.
    /// </summary>
    public TerraformProperty<double>? ManagementIpAddressLayoutVersion
    {
        get => GetProperty<TerraformProperty<double>>("management_ip_address_layout_version");
        set => WithProperty("management_ip_address_layout_version", value);
    }

    /// <summary>
    /// The relative resource name of the VMware Engine network attached to the private cloud.
    /// Specify the name in the following form: projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// where {project} can either be a project number or a project ID.
    /// </summary>
    public TerraformProperty<string>? VmwareEngineNetwork
    {
        get => GetProperty<TerraformProperty<string>>("vmware_engine_network");
        set => WithProperty("vmware_engine_network", value);
    }

    /// <summary>
    /// The canonical name of the VMware Engine network in
    /// the form: projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    public TerraformProperty<string>? VmwareEngineNetworkCanonical
    {
        get => GetProperty<TerraformProperty<string>>("vmware_engine_network_canonical");
        set => WithProperty("vmware_engine_network_canonical", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVmwareenginePrivateCloudTimeoutsBlock : TerraformBlock
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
/// Manages a google_vmwareengine_private_cloud resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVmwareenginePrivateCloud : TerraformResource
{
    public GoogleVmwareenginePrivateCloud(string name) : base("google_vmwareengine_private_cloud", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("expire_time");
        this.DeclareOutput("hcx");
        this.DeclareOutput("nsx");
        this.DeclareOutput("state");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("vcenter");
    }

    /// <summary>
    /// The number of hours to delay this request. You can set this value to an hour between 0 to 8, where setting it to 0 starts the deletion request immediately. If no value is set, a default value is set at the API Level.
    /// </summary>
    public TerraformProperty<double>? DeletionDelayHours
    {
        get => GetProperty<TerraformProperty<double>>("deletion_delay_hours");
        set => this.WithProperty("deletion_delay_hours", value);
    }

    /// <summary>
    /// User-provided description for this private cloud.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// While set true, deletion_delay_hours value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the deletion_delay_hours field. It can be used both alone and together with deletion_delay_hours.
    /// </summary>
    public TerraformProperty<bool>? SendDeletionDelayHoursIfZero
    {
        get => GetProperty<TerraformProperty<bool>>("send_deletion_delay_hours_if_zero");
        set => this.WithProperty("send_deletion_delay_hours_if_zero", value);
    }

    /// <summary>
    /// Initial type of the private cloud. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;TIME_LIMITED&amp;quot;, &amp;quot;STRETCHED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for management_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagementCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementCluster block(s) allowed")]
    public List<GoogleVmwareenginePrivateCloudManagementClusterBlock>? ManagementCluster
    {
        get => GetProperty<List<GoogleVmwareenginePrivateCloudManagementClusterBlock>>("management_cluster");
        set => this.WithProperty("management_cluster", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleVmwareenginePrivateCloudNetworkConfigBlock>? NetworkConfig
    {
        get => GetProperty<List<GoogleVmwareenginePrivateCloudNetworkConfigBlock>>("network_config");
        set => this.WithProperty("network_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVmwareenginePrivateCloudTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleVmwareenginePrivateCloudTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
    /// Details about a NSX Manager appliance.
    /// </summary>
    public TerraformExpression Nsx => this["nsx"];

    /// <summary>
    /// State of the resource. New values may be added to this enum when appropriate.
    /// </summary>
    public TerraformExpression State => this["state"];

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
