using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for versioning_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketVersioningVersioningConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The mfa_delete attribute.
    /// </summary>
    public TerraformProperty<string>? MfaDelete
    {
        get => GetProperty<TerraformProperty<string>>("mfa_delete");
        set => WithProperty("mfa_delete", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformProperty<string> Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Manages a aws_s3_bucket_versioning resource.
/// </summary>
public class AwsS3BucketVersioning : TerraformResource
{
    public AwsS3BucketVersioning(string name) : base("aws_s3_bucket_versioning", name)
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
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string>? ExpectedBucketOwner
    {
        get => GetProperty<TerraformProperty<string>>("expected_bucket_owner");
        set => this.WithProperty("expected_bucket_owner", value);
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
    /// The mfa attribute.
    /// </summary>
    public TerraformProperty<string>? Mfa
    {
        get => GetProperty<TerraformProperty<string>>("mfa");
        set => this.WithProperty("mfa", value);
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
    /// Block for versioning_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VersioningConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VersioningConfiguration block(s) allowed")]
    public List<AwsS3BucketVersioningVersioningConfigurationBlock>? VersioningConfiguration
    {
        get => GetProperty<List<AwsS3BucketVersioningVersioningConfigurationBlock>>("versioning_configuration");
        set => this.WithProperty("versioning_configuration", value);
    }

}
