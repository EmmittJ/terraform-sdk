using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_data_config in .
/// Nesting mode: list
/// </summary>
public class AwsComprehendDocumentClassifierInputDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformProperty<string>? DataFormat
    {
        set => SetProperty("data_format", value);
    }

    /// <summary>
    /// The label_delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? LabelDelimiter
    {
        set => SetProperty("label_delimiter", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    public TerraformProperty<string>? S3Uri
    {
        set => SetProperty("s3_uri", value);
    }

    /// <summary>
    /// The test_s3_uri attribute.
    /// </summary>
    public TerraformProperty<string>? TestS3Uri
    {
        set => SetProperty("test_s3_uri", value);
    }

}

/// <summary>
/// Block type for output_data_config in .
/// Nesting mode: list
/// </summary>
public class AwsComprehendDocumentClassifierOutputDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The output_s3_uri attribute.
    /// </summary>
    public TerraformProperty<string>? OutputS3Uri
    {
        set => SetProperty("output_s3_uri", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformProperty<string> S3Uri
    {
        set => SetProperty("s3_uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsComprehendDocumentClassifierTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsComprehendDocumentClassifierVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        set => SetProperty("subnets", value);
    }

}

/// <summary>
/// Manages a aws_comprehend_document_classifier resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsComprehendDocumentClassifier : TerraformResource
{
    public AwsComprehendDocumentClassifier(string name) : base("aws_comprehend_document_classifier", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("data_access_role_arn");
        SetOutput("id");
        SetOutput("language_code");
        SetOutput("mode");
        SetOutput("model_kms_key_id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("version_name");
        SetOutput("version_name_prefix");
        SetOutput("volume_kms_key_id");
    }

    /// <summary>
    /// The data_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessRoleArn is required")]
    public required TerraformProperty<string> DataAccessRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_access_role_arn");
        set => SetProperty("data_access_role_arn", value);
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
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformProperty<string> LanguageCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language_code");
        set => SetProperty("language_code", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string> Mode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mode");
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The model_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> ModelKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("model_kms_key_id");
        set => SetProperty("model_kms_key_id", value);
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
    /// The version_name attribute.
    /// </summary>
    public TerraformProperty<string> VersionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_name");
        set => SetProperty("version_name", value);
    }

    /// <summary>
    /// The version_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> VersionNamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_name_prefix");
        set => SetProperty("version_name_prefix", value);
    }

    /// <summary>
    /// The volume_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> VolumeKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("volume_kms_key_id");
        set => SetProperty("volume_kms_key_id", value);
    }

    /// <summary>
    /// Block for input_data_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputDataConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputDataConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputDataConfig block(s) allowed")]
    public List<AwsComprehendDocumentClassifierInputDataConfigBlock>? InputDataConfig
    {
        set => SetProperty("input_data_config", value);
    }

    /// <summary>
    /// Block for output_data_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputDataConfig block(s) allowed")]
    public List<AwsComprehendDocumentClassifierOutputDataConfigBlock>? OutputDataConfig
    {
        set => SetProperty("output_data_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsComprehendDocumentClassifierTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsComprehendDocumentClassifierVpcConfigBlock>? VpcConfig
    {
        set => SetProperty("vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
