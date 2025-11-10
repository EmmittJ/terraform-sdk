using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketOwnershipControlsRuleBlock : TerraformBlock
{
    /// <summary>
    /// The object_ownership attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectOwnership is required")]
    public required TerraformProperty<string> ObjectOwnership
    {
        get => GetProperty<TerraformProperty<string>>("object_ownership");
        set => WithProperty("object_ownership", value);
    }

}

/// <summary>
/// Manages a aws_s3_bucket_ownership_controls resource.
/// </summary>
public class AwsS3BucketOwnershipControls : TerraformResource
{
    public AwsS3BucketOwnershipControls(string name) : base("aws_s3_bucket_ownership_controls", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rule block(s) allowed")]
    public List<AwsS3BucketOwnershipControlsRuleBlock>? Rule
    {
        get => GetProperty<List<AwsS3BucketOwnershipControlsRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

}
