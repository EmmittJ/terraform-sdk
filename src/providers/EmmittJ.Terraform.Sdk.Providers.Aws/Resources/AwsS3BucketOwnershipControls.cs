using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in AwsS3BucketOwnershipControls.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketOwnershipControlsRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The object_ownership attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectOwnership is required")]
    public required TerraformValue<string> ObjectOwnership
    {
        get => GetRequiredArgument<TerraformValue<string>>("object_ownership");
        set => SetArgument("object_ownership", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_ownership_controls Terraform resource.
/// Manages a aws_s3_bucket_ownership_controls resource.
/// </summary>
public partial class AwsS3BucketOwnershipControls(string name) : TerraformResource("aws_s3_bucket_ownership_controls", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rule block(s) allowed")]
    public required TerraformList<AwsS3BucketOwnershipControlsRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketOwnershipControlsRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}
