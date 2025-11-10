using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionType
    {
        get => GetProperty<TerraformProperty<string>>("encryption_type");
        set => WithProperty("encryption_type", value);
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
/// Block type for image_scanning_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryImageScanningConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The scan_on_push attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanOnPush is required")]
    public required TerraformProperty<bool> ScanOnPush
    {
        get => GetProperty<TerraformProperty<bool>>("scan_on_push");
        set => WithProperty("scan_on_push", value);
    }

}

/// <summary>
/// Block type for image_tag_mutability_exclusion_filter in .
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryImageTagMutabilityExclusionFilterBlock : TerraformBlock
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => WithProperty("filter", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformProperty<string> FilterType
    {
        get => GetProperty<TerraformProperty<string>>("filter_type");
        set => WithProperty("filter_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEcrRepositoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_ecr_repository resource.
/// </summary>
public class AwsEcrRepository : TerraformResource
{
    public AwsEcrRepository(string name) : base("aws_ecr_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("registry_id");
        this.DeclareOutput("repository_url");
    }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDelete
    {
        get => GetProperty<TerraformProperty<bool>>("force_delete");
        set => this.WithProperty("force_delete", value);
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
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformProperty<string>? ImageTagMutability
    {
        get => GetProperty<TerraformProperty<string>>("image_tag_mutability");
        set => this.WithProperty("image_tag_mutability", value);
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
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEcrRepositoryEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetProperty<List<AwsEcrRepositoryEncryptionConfigurationBlock>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for image_scanning_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageScanningConfiguration block(s) allowed")]
    public List<AwsEcrRepositoryImageScanningConfigurationBlock>? ImageScanningConfiguration
    {
        get => GetProperty<List<AwsEcrRepositoryImageScanningConfigurationBlock>>("image_scanning_configuration");
        set => this.WithProperty("image_scanning_configuration", value);
    }

    /// <summary>
    /// Block for image_tag_mutability_exclusion_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ImageTagMutabilityExclusionFilter block(s) allowed")]
    public List<AwsEcrRepositoryImageTagMutabilityExclusionFilterBlock>? ImageTagMutabilityExclusionFilter
    {
        get => GetProperty<List<AwsEcrRepositoryImageTagMutabilityExclusionFilterBlock>>("image_tag_mutability_exclusion_filter");
        set => this.WithProperty("image_tag_mutability_exclusion_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEcrRepositoryTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEcrRepositoryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformExpression RepositoryUrl => this["repository_url"];

}
