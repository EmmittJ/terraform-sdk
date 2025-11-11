using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3tables_table_bucket_policy resource.
/// </summary>
public partial class AwsS3tablesTableBucketPolicy : TerraformResource
{
    public AwsS3tablesTableBucketPolicy(string name) : base("aws_s3tables_table_bucket_policy", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourcePolicy is required")]
    [TerraformProperty("resource_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourcePolicy { get; set; }

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    [TerraformProperty("table_bucket_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TableBucketArn { get; set; }

}
