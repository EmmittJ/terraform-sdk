using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_config in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationS3S3ConfigBlock : TerraformBlock
{
    /// <summary>
    /// The bucket_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketAccessRoleArn is required")]
    public required TerraformProperty<string> BucketAccessRoleArn
    {
        set => SetProperty("bucket_access_role_arn", value);
    }

}

/// <summary>
/// Manages a aws_datasync_location_s3 resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDatasyncLocationS3 : TerraformResource
{
    public AwsDatasyncLocationS3(string name) : base("aws_datasync_location_s3", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("uri");
        SetOutput("agent_arns");
        SetOutput("id");
        SetOutput("region");
        SetOutput("s3_bucket_arn");
        SetOutput("s3_storage_class");
        SetOutput("subdirectory");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AgentArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("agent_arns");
        set => SetProperty("agent_arns", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketArn is required")]
    public required TerraformProperty<string> S3BucketArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_bucket_arn");
        set => SetProperty("s3_bucket_arn", value);
    }

    /// <summary>
    /// The s3_storage_class attribute.
    /// </summary>
    public TerraformProperty<string> S3StorageClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_storage_class");
        set => SetProperty("s3_storage_class", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subdirectory is required")]
    public required TerraformProperty<string> Subdirectory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subdirectory");
        set => SetProperty("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for s3_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Config block(s) allowed")]
    public List<AwsDatasyncLocationS3S3ConfigBlock>? S3Config
    {
        set => SetProperty("s3_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}
