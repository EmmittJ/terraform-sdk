using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for acl_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAthenaDatabaseAclConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The s3_acl_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3AclOption is required")]
    public required TerraformProperty<string> S3AclOption
    {
        get => GetProperty<TerraformProperty<string>>("s3_acl_option");
        set => WithProperty("s3_acl_option", value);
    }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAthenaDatabaseEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The encryption_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionOption is required")]
    public required TerraformProperty<string> EncryptionOption
    {
        get => GetProperty<TerraformProperty<string>>("encryption_option");
        set => WithProperty("encryption_option", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => WithProperty("kms_key", value);
    }

}

/// <summary>
/// Manages a aws_athena_database resource.
/// </summary>
public class AwsAthenaDatabase : TerraformResource
{
    public AwsAthenaDatabase(string name) : base("aws_athena_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string>? Comment
    {
        get => GetProperty<TerraformProperty<string>>("comment");
        set => this.WithProperty("comment", value);
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
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => this.WithProperty("properties", value);
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
    /// The workgroup attribute.
    /// </summary>
    public TerraformProperty<string>? Workgroup
    {
        get => GetProperty<TerraformProperty<string>>("workgroup");
        set => this.WithProperty("workgroup", value);
    }

    /// <summary>
    /// Block for acl_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AclConfiguration block(s) allowed")]
    public List<AwsAthenaDatabaseAclConfigurationBlock>? AclConfiguration
    {
        get => GetProperty<List<AwsAthenaDatabaseAclConfigurationBlock>>("acl_configuration");
        set => this.WithProperty("acl_configuration", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<AwsAthenaDatabaseEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetProperty<List<AwsAthenaDatabaseEncryptionConfigurationBlock>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

}
