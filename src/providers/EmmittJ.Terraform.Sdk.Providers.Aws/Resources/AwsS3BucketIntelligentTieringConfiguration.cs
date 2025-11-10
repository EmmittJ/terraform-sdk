using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketIntelligentTieringConfigurationFilterBlock : TerraformBlock
{
    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        set => SetProperty("prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

}

/// <summary>
/// Block type for tiering in .
/// Nesting mode: set
/// </summary>
public class AwsS3BucketIntelligentTieringConfigurationTieringBlock : TerraformBlock
{
    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessTier is required")]
    public required TerraformProperty<string> AccessTier
    {
        set => SetProperty("access_tier", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Days is required")]
    public required TerraformProperty<double> Days
    {
        set => SetProperty("days", value);
    }

}

/// <summary>
/// Manages a aws_s3_bucket_intelligent_tiering_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3BucketIntelligentTieringConfiguration : TerraformResource
{
    public AwsS3BucketIntelligentTieringConfiguration(string name) : base("aws_s3_bucket_intelligent_tiering_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("bucket");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("status");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<AwsS3BucketIntelligentTieringConfigurationFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for tiering.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tiering is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Tiering block(s) required")]
    public HashSet<AwsS3BucketIntelligentTieringConfigurationTieringBlock>? Tiering
    {
        set => SetProperty("tiering", value);
    }

}
