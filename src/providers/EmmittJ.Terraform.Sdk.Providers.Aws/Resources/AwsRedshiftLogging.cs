using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_logging resource.
/// </summary>
public partial class AwsRedshiftLogging : TerraformResource
{
    public AwsRedshiftLogging(string name) : base("aws_redshift_logging", name)
    {
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [TerraformProperty("bucket_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BucketName { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformProperty("cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    [TerraformProperty("log_destination_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogDestinationType { get; set; }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    [TerraformProperty("log_exports")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? LogExports { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformProperty("s3_key_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3KeyPrefix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
