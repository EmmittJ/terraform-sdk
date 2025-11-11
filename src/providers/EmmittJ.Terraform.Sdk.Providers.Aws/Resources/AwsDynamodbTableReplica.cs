using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDynamodbTableReplicaTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_dynamodb_table_replica resource.
/// </summary>
public partial class AwsDynamodbTableReplica : TerraformResource
{
    public AwsDynamodbTableReplica(string name) : base("aws_dynamodb_table_replica", name)
    {
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// The global_table_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalTableArn is required")]
    [TerraformProperty("global_table_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GlobalTableArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeyArn { get; set; }

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    [TerraformProperty("point_in_time_recovery")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PointInTimeRecovery { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The table_class_override attribute.
    /// </summary>
    [TerraformProperty("table_class_override")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TableClassOverride { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsDynamodbTableReplicaTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
