using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3BucketReplicationConfigurationRuleBlock() : TerraformBlock("rule")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Prefix { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [TerraformProperty("status")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Status { get; set; }

}

/// <summary>
/// Manages a aws_s3_bucket_replication_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3BucketReplicationConfiguration : TerraformResource
{
    public AwsS3BucketReplicationConfiguration(string name) : base("aws_s3_bucket_replication_configuration", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

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
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Role { get; set; }

    /// <summary>
    /// The token attribute.
    /// </summary>
    [TerraformProperty("token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Token { get; set; }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 Rule block(s) allowed")]
    [TerraformProperty("rule")]
    public required TerraformList<AwsS3BucketReplicationConfigurationRuleBlock> Rule { get; set; } = new();

}
