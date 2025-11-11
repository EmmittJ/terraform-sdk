using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_destination in .
/// Nesting mode: list
/// </summary>
public partial class AwsMacie2ClassificationExportConfigurationS3DestinationBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformProperty("bucket_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The key_prefix attribute.
    /// </summary>
    [TerraformProperty("key_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyPrefix { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    [TerraformProperty("kms_key_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KmsKeyArn { get; set; }

}

/// <summary>
/// Manages a aws_macie2_classification_export_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMacie2ClassificationExportConfiguration : TerraformResource
{
    public AwsMacie2ClassificationExportConfiguration(string name) : base("aws_macie2_classification_export_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for s3_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Destination block(s) allowed")]
    [TerraformProperty("s3_destination")]
    public TerraformList<TerraformBlock<AwsMacie2ClassificationExportConfigurationS3DestinationBlock>>? S3Destination { get; set; }

}
