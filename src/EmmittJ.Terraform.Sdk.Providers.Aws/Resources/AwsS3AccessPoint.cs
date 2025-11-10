using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for public_access_block_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3AccessPointPublicAccessBlockConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    public TerraformProperty<bool>? BlockPublicAcls
    {
        get => GetProperty<TerraformProperty<bool>>("block_public_acls");
        set => WithProperty("block_public_acls", value);
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformProperty<bool>? BlockPublicPolicy
    {
        get => GetProperty<TerraformProperty<bool>>("block_public_policy");
        set => WithProperty("block_public_policy", value);
    }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnorePublicAcls
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_public_acls");
        set => WithProperty("ignore_public_acls", value);
    }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformProperty<bool>? RestrictPublicBuckets
    {
        get => GetProperty<TerraformProperty<bool>>("restrict_public_buckets");
        set => WithProperty("restrict_public_buckets", value);
    }

}

/// <summary>
/// Block type for vpc_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3AccessPointVpcConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
    }

}

/// <summary>
/// Manages a aws_s3_access_point resource.
/// </summary>
public class AwsS3AccessPoint : TerraformResource
{
    public AwsS3AccessPoint(string name) : base("aws_s3_access_point", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alias");
        this.DeclareOutput("arn");
        this.DeclareOutput("domain_name");
        this.DeclareOutput("endpoints");
        this.DeclareOutput("has_public_access_policy");
        this.DeclareOutput("network_origin");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    /// The bucket_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? BucketAccountId
    {
        get => GetProperty<TerraformProperty<string>>("bucket_account_id");
        set => this.WithProperty("bucket_account_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
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
    /// Block for public_access_block_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicAccessBlockConfiguration block(s) allowed")]
    public List<AwsS3AccessPointPublicAccessBlockConfigurationBlock>? PublicAccessBlockConfiguration
    {
        get => GetProperty<List<AwsS3AccessPointPublicAccessBlockConfigurationBlock>>("public_access_block_configuration");
        set => this.WithProperty("public_access_block_configuration", value);
    }

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    public List<AwsS3AccessPointVpcConfigurationBlock>? VpcConfiguration
    {
        get => GetProperty<List<AwsS3AccessPointVpcConfigurationBlock>>("vpc_configuration");
        set => this.WithProperty("vpc_configuration", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformExpression Endpoints => this["endpoints"];

    /// <summary>
    /// The has_public_access_policy attribute.
    /// </summary>
    public TerraformExpression HasPublicAccessPolicy => this["has_public_access_policy"];

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    public TerraformExpression NetworkOrigin => this["network_origin"];

}
