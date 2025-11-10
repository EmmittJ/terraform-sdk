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
        set => SetProperty("s3_acl_option", value);
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
        set => SetProperty("encryption_option", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        set => SetProperty("kms_key", value);
    }

}

/// <summary>
/// Manages a aws_athena_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAthenaDatabase : TerraformResource
{
    public AwsAthenaDatabase(string name) : base("aws_athena_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("bucket");
        SetOutput("comment");
        SetOutput("expected_bucket_owner");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("name");
        SetOutput("properties");
        SetOutput("region");
        SetOutput("workgroup");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string> Comment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("comment");
        set => SetProperty("comment", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string> ExpectedBucketOwner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expected_bucket_owner");
        set => SetProperty("expected_bucket_owner", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Properties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("properties");
        set => SetProperty("properties", value);
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
    /// The workgroup attribute.
    /// </summary>
    public TerraformProperty<string> Workgroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workgroup");
        set => SetProperty("workgroup", value);
    }

    /// <summary>
    /// Block for acl_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AclConfiguration block(s) allowed")]
    public List<AwsAthenaDatabaseAclConfigurationBlock>? AclConfiguration
    {
        set => SetProperty("acl_configuration", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<AwsAthenaDatabaseEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        set => SetProperty("encryption_configuration", value);
    }

}
