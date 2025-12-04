using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsS3BucketIntelligentTieringConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketIntelligentTieringConfigurationFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Block type for tiering in AwsS3BucketIntelligentTieringConfiguration.
/// Nesting mode: set
/// </summary>
public class AwsS3BucketIntelligentTieringConfigurationTieringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tiering";

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessTier is required")]
    public required TerraformValue<string> AccessTier
    {
        get => GetRequiredArgument<TerraformValue<string>>("access_tier");
        set => SetArgument("access_tier", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Days is required")]
    public required TerraformValue<double> Days
    {
        get => GetRequiredArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_intelligent_tiering_configuration Terraform resource.
/// Manages a aws_s3_bucket_intelligent_tiering_configuration resource.
/// </summary>
public partial class AwsS3BucketIntelligentTieringConfiguration(string name) : TerraformResource("aws_s3_bucket_intelligent_tiering_configuration", name)
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AwsS3BucketIntelligentTieringConfigurationFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsS3BucketIntelligentTieringConfigurationFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Tiering block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tiering is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Tiering block(s) required")]
    public required TerraformSet<AwsS3BucketIntelligentTieringConfigurationTieringBlock> Tiering
    {
        get => GetRequiredArgument<TerraformSet<AwsS3BucketIntelligentTieringConfigurationTieringBlock>>("tiering");
        set => SetArgument("tiering", value);
    }

}
