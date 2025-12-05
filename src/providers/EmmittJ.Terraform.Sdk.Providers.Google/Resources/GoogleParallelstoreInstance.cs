using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleParallelstoreInstance.
/// Nesting mode: single
/// </summary>
public class GoogleParallelstoreInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_parallelstore_instance Terraform resource.
/// Manages a google_parallelstore_instance resource.
/// </summary>
public partial class GoogleParallelstoreInstance(string name) : TerraformResource("google_parallelstore_instance", name)
{
    /// <summary>
    /// Required. Immutable. Storage capacity of Parallelstore instance in Gibibytes (GiB).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityGib is required")]
    public required TerraformValue<string> CapacityGib
    {
        get => GetRequiredArgument<TerraformValue<string>>("capacity_gib");
        set => SetArgument("capacity_gib", value);
    }

    /// <summary>
    /// Parallelstore Instance deployment type.
    ///   Possible values:
    ///   DEPLOYMENT_TYPE_UNSPECIFIED
    ///   SCRATCH
    ///   PERSISTENT
    /// </summary>
    public TerraformValue<string>? DeploymentType
    {
        get => GetArgument<TerraformValue<string>>("deployment_type");
        set => SetArgument("deployment_type", value);
    }

    /// <summary>
    /// The description of the instance. 2048 characters or less.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Stripe level for directories.
    /// MIN when directory has a small number of files.
    /// MAX when directory has a large number of files.
    ///   Possible values:
    ///   DIRECTORY_STRIPE_LEVEL_UNSPECIFIED
    ///   DIRECTORY_STRIPE_LEVEL_MIN
    ///   DIRECTORY_STRIPE_LEVEL_BALANCED
    ///   DIRECTORY_STRIPE_LEVEL_MAX
    /// </summary>
    public TerraformValue<string>? DirectoryStripeLevel
    {
        get => GetArgument<TerraformValue<string>>("directory_stripe_level");
        set => SetArgument("directory_stripe_level", value);
    }

    /// <summary>
    /// Stripe level for files.
    /// MIN better suited for small size files.
    /// MAX higher throughput performance for larger files.
    ///   Possible values:
    ///   FILE_STRIPE_LEVEL_UNSPECIFIED
    ///   FILE_STRIPE_LEVEL_MIN
    ///   FILE_STRIPE_LEVEL_BALANCED
    ///   FILE_STRIPE_LEVEL_MAX
    /// </summary>
    public TerraformValue<string>? FileStripeLevel
    {
        get => GetArgument<TerraformValue<string>>("file_stripe_level");
        set => SetArgument("file_stripe_level", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The logical name of the Parallelstore instance in the user project with the following restrictions:
    ///   * Must contain only lowercase letters, numbers, and hyphens.
    ///   * Must start with a letter.
    ///   * Must be between 1-63 characters.
    ///   * Must end with a number or a letter.
    ///   * Must be unique within the customer project/ location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// Cloud Labels are a flexible and lightweight mechanism for
    /// organizing cloud resources into groups that reflect a customer&#39;s organizational
    /// needs and deployment strategies. Cloud Labels can be used to filter collections
    /// of resources. They can be used to control how resource metrics are aggregated.
    /// And they can be used as arguments to policy management rules (e.g. route, firewall,
    /// load balancing, etc.).
    /// 
    /// * Label keys must be between 1 and 63 characters long and must conform to
    ///  the following regular expression: &#39;a-z{0,62}&#39;.
    /// * Label values must be between 0 and 63 characters long and must conform
    ///  to the regular expression &#39;[a-z0-9_-]{0,63}&#39;.
    /// * No more than 64 labels can be associated with a given resource.
    /// 
    /// See https://goo.gl/xmQnxf for more information on and examples of labels.
    /// 
    /// If you plan to use labels in your own code, please note that additional
    /// characters may be allowed in the future. Therefore, you are advised to use
    /// an internal label representation, such as JSON, which doesn&#39;t rely upon
    /// specific characters being disallowed.  For example, representing labels
    /// as the string:  &#39;name + &amp;quot;_&amp;quot; + value&#39; would prove problematic if we were to
    /// allow &#39;&amp;quot;_&amp;quot;&#39; in a future release. &amp;quot;
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Immutable. The name of the Google Compute Engine [VPC network](https://cloud.google.com/vpc/docs/vpc)
    /// to which the instance is connected.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Immutable. Contains the id of the allocated IP address range
    /// associated with the private service access connection for example, \&amp;quot;test-default\&amp;quot;
    /// associated with IP range 10.0.0.0/29. If no range id is provided all ranges will
    /// be considered.
    /// </summary>
    public TerraformValue<string>? ReservedIpRange
    {
        get => GetArgument<TerraformValue<string>>("reserved_ip_range");
        set => SetArgument("reserved_ip_range", value);
    }

    /// <summary>
    /// Output only. List of access_points.
    /// Contains a list of IPv4 addresses used for client side configuration.
    /// </summary>
    public TerraformList<string> AccessPoints
        => CreateReference("access_points");

    /// <summary>
    /// The time when the instance was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The version of DAOS software running in the instance.
    /// </summary>
    public TerraformValue<string> DaosVersion
        => CreateReference("daos_version");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Immutable. Contains the id of the allocated IP address
    /// range associated with the private service access connection for example, \&amp;quot;test-default\&amp;quot;
    /// associated with IP range 10.0.0.0/29. This field is populated by the service
    /// and contains the value currently used by the service.
    /// </summary>
    public TerraformValue<string> EffectiveReservedIpRange
        => CreateReference("effective_reserved_ip_range");

    /// <summary>
    /// Identifier. The resource name of the instance, in the format
    /// &#39;projects/{project}/locations/{location}/instances/{instance_id}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The instance state.
    ///   Possible values:
    ///   STATE_UNSPECIFIED
    ///   CREATING
    ///   ACTIVE
    ///   DELETING
    ///   FAILED
    ///   UPGRADING
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleParallelstoreInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleParallelstoreInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
