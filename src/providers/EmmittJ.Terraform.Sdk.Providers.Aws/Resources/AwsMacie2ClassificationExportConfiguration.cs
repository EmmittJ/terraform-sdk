using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_destination in AwsMacie2ClassificationExportConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsMacie2ClassificationExportConfigurationS3DestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_destination";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? KeyPrefix
    {
        get => new TerraformReference<string>(this, "key_prefix");
        set => SetArgument("key_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    public required TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}


/// <summary>
/// Represents a aws_macie2_classification_export_configuration Terraform resource.
/// Manages a aws_macie2_classification_export_configuration resource.
/// </summary>
public partial class AwsMacie2ClassificationExportConfiguration(string name) : TerraformResource("aws_macie2_classification_export_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// S3Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Destination block(s) allowed")]
    public required TerraformList<AwsMacie2ClassificationExportConfigurationS3DestinationBlock> S3Destination
    {
        get => GetRequiredArgument<TerraformList<AwsMacie2ClassificationExportConfigurationS3DestinationBlock>>("s3_destination");
        set => SetArgument("s3_destination", value);
    }

}
