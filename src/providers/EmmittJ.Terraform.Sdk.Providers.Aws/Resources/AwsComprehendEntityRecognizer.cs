using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_data_config in .
/// Nesting mode: list
/// </summary>
public class AwsComprehendEntityRecognizerInputDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformProperty<string>? DataFormat
    {
        get => GetProperty<TerraformProperty<string>>("data_format");
        set => WithProperty("data_format", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsComprehendEntityRecognizerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsComprehendEntityRecognizerVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnets");
        set => WithProperty("subnets", value);
    }

}

/// <summary>
/// Manages a aws_comprehend_entity_recognizer resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsComprehendEntityRecognizer : TerraformResource
{
    public AwsComprehendEntityRecognizer(string name) : base("aws_comprehend_entity_recognizer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The data_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessRoleArn is required")]
    public required TerraformProperty<string> DataAccessRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_access_role_arn");
        set => this.WithProperty("data_access_role_arn", value);
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
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformProperty<string> LanguageCode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The model_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ModelKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("model_kms_key_id");
        set => this.WithProperty("model_kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The version_name attribute.
    /// </summary>
    public TerraformProperty<string>? VersionName
    {
        get => GetProperty<TerraformProperty<string>>("version_name");
        set => this.WithProperty("version_name", value);
    }

    /// <summary>
    /// The version_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? VersionNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("version_name_prefix");
        set => this.WithProperty("version_name_prefix", value);
    }

    /// <summary>
    /// The volume_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("volume_kms_key_id");
        set => this.WithProperty("volume_kms_key_id", value);
    }

    /// <summary>
    /// Block for input_data_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputDataConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputDataConfig block(s) allowed")]
    public List<AwsComprehendEntityRecognizerInputDataConfigBlock>? InputDataConfig
    {
        get => GetProperty<List<AwsComprehendEntityRecognizerInputDataConfigBlock>>("input_data_config");
        set => this.WithProperty("input_data_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsComprehendEntityRecognizerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsComprehendEntityRecognizerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public List<AwsComprehendEntityRecognizerVpcConfigBlock>? VpcConfig
    {
        get => GetProperty<List<AwsComprehendEntityRecognizerVpcConfigBlock>>("vpc_config");
        set => this.WithProperty("vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
