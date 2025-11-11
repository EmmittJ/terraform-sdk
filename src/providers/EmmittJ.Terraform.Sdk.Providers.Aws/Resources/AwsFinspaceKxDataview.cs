using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for segment_configurations in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxDataviewSegmentConfigurationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The db_paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbPaths is required")]
    [TerraformProperty("db_paths")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? DbPaths { get; set; }

    /// <summary>
    /// The on_demand attribute.
    /// </summary>
    [TerraformProperty("on_demand")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? OnDemand { get; set; }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    [TerraformProperty("volume_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VolumeName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFinspaceKxDataviewTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_finspace_kx_dataview resource.
/// </summary>
public partial class AwsFinspaceKxDataview : TerraformResource
{
    public AwsFinspaceKxDataview(string name) : base("aws_finspace_kx_dataview", name)
    {
    }

    /// <summary>
    /// The auto_update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoUpdate is required")]
    [TerraformProperty("auto_update")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> AutoUpdate { get; set; }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AvailabilityZoneId { get; set; }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzMode is required")]
    [TerraformProperty("az_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AzMode { get; set; }

    /// <summary>
    /// The changeset_id attribute.
    /// </summary>
    [TerraformProperty("changeset_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ChangesetId { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    [TerraformProperty("environment_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The read_write attribute.
    /// </summary>
    [TerraformProperty("read_write")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ReadWrite { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for segment_configurations.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("segment_configurations")]
    public TerraformList<TerraformBlock<AwsFinspaceKxDataviewSegmentConfigurationsBlock>>? SegmentConfigurations { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsFinspaceKxDataviewTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    [TerraformProperty("created_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedTimestamp { get; }

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    [TerraformProperty("last_modified_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedTimestamp { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
