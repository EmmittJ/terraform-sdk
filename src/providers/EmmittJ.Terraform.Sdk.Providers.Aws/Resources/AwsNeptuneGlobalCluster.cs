using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNeptuneGlobalClusterTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_neptune_global_cluster resource.
/// </summary>
public partial class AwsNeptuneGlobalCluster : TerraformResource
{
    public AwsNeptuneGlobalCluster(string name) : base("aws_neptune_global_cluster", name)
    {
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The global_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalClusterIdentifier is required")]
    [TerraformProperty("global_cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GlobalClusterIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_db_cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("source_db_cluster_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SourceDbClusterIdentifier { get; set; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> StorageEncrypted { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsNeptuneGlobalClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The global_cluster_members attribute.
    /// </summary>
    [TerraformProperty("global_cluster_members")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> GlobalClusterMembers { get; }

    /// <summary>
    /// The global_cluster_resource_id attribute.
    /// </summary>
    [TerraformProperty("global_cluster_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GlobalClusterResourceId { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
