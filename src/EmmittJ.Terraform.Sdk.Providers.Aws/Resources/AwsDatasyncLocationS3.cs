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
        get => GetProperty<TerraformProperty<string>>("bucket_access_role_arn");
        set => WithProperty("bucket_access_role_arn", value);
    }

}

/// <summary>
/// Manages a aws_datasync_location_s3 resource.
/// </summary>
public class AwsDatasyncLocationS3 : TerraformResource
{
    public AwsDatasyncLocationS3(string name) : base("aws_datasync_location_s3", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("uri");
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AgentArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("agent_arns");
        set => this.WithProperty("agent_arns", value);
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
    /// The s3_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketArn is required")]
    public required TerraformProperty<string> S3BucketArn
    {
        get => GetProperty<TerraformProperty<string>>("s3_bucket_arn");
        set => this.WithProperty("s3_bucket_arn", value);
    }

    /// <summary>
    /// The s3_storage_class attribute.
    /// </summary>
    public TerraformProperty<string>? S3StorageClass
    {
        get => GetProperty<TerraformProperty<string>>("s3_storage_class");
        set => this.WithProperty("s3_storage_class", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subdirectory is required")]
    public required TerraformProperty<string> Subdirectory
    {
        get => GetProperty<TerraformProperty<string>>("subdirectory");
        set => this.WithProperty("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for s3_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Config block(s) allowed")]
    public List<AwsDatasyncLocationS3S3ConfigBlock>? S3Config
    {
        get => GetProperty<List<AwsDatasyncLocationS3S3ConfigBlock>>("s3_config");
        set => this.WithProperty("s3_config", value);
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
