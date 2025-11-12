using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public partial class AwsSecretsmanagerSecretReplicaBlock() : TerraformBlock("replica")
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }


    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Region { get; set; }



}

/// <summary>
/// Manages a aws_secretsmanager_secret resource.
/// </summary>
public partial class AwsSecretsmanagerSecret : TerraformResource
{
    public AwsSecretsmanagerSecret(string name) : base("aws_secretsmanager_secret", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The force_overwrite_replica_secret attribute.
    /// </summary>
    [TerraformProperty("force_overwrite_replica_secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceOverwriteReplicaSecret { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// The recovery_window_in_days attribute.
    /// </summary>
    [TerraformProperty("recovery_window_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RecoveryWindowInDays { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("replica")]
    public TerraformSet<AwsSecretsmanagerSecretReplicaBlock> Replica { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
