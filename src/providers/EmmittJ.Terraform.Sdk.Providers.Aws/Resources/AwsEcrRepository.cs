using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in AwsEcrRepository.
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionType
    {
        get => GetArgument<TerraformValue<string>>("encryption_type");
        set => SetArgument("encryption_type", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformValue<string> KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key") ?? AsReference("kms_key");
        set => SetArgument("kms_key", value);
    }

}


/// <summary>
/// Block type for image_scanning_configuration in AwsEcrRepository.
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryImageScanningConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_scanning_configuration";

    /// <summary>
    /// The scan_on_push attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanOnPush is required")]
    public required TerraformValue<bool> ScanOnPush
    {
        get => GetRequiredArgument<TerraformValue<bool>>("scan_on_push");
        set => SetArgument("scan_on_push", value);
    }

}


/// <summary>
/// Block type for image_tag_mutability_exclusion_filter in AwsEcrRepository.
/// Nesting mode: list
/// </summary>
public class AwsEcrRepositoryImageTagMutabilityExclusionFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_tag_mutability_exclusion_filter";

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformValue<string> FilterType
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter_type");
        set => SetArgument("filter_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEcrRepository.
/// Nesting mode: single
/// </summary>
public class AwsEcrRepositoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_ecr_repository Terraform resource.
/// Manages a aws_ecr_repository resource.
/// </summary>
public partial class AwsEcrRepository(string name) : TerraformResource("aws_ecr_repository", name)
{
    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDelete
    {
        get => GetArgument<TerraformValue<bool>>("force_delete");
        set => SetArgument("force_delete", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_tag_mutability attribute.
    /// </summary>
    public TerraformValue<string>? ImageTagMutability
    {
        get => GetArgument<TerraformValue<string>>("image_tag_mutability");
        set => SetArgument("image_tag_mutability", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
        => AsReference("registry_id");

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformValue<string> RepositoryUrl
        => AsReference("repository_url");

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcrRepositoryEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsEcrRepositoryEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// ImageScanningConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageScanningConfiguration block(s) allowed")]
    public TerraformList<AwsEcrRepositoryImageScanningConfigurationBlock>? ImageScanningConfiguration
    {
        get => GetArgument<TerraformList<AwsEcrRepositoryImageScanningConfigurationBlock>>("image_scanning_configuration");
        set => SetArgument("image_scanning_configuration", value);
    }

    /// <summary>
    /// ImageTagMutabilityExclusionFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ImageTagMutabilityExclusionFilter block(s) allowed")]
    public TerraformList<AwsEcrRepositoryImageTagMutabilityExclusionFilterBlock>? ImageTagMutabilityExclusionFilter
    {
        get => GetArgument<TerraformList<AwsEcrRepositoryImageTagMutabilityExclusionFilterBlock>>("image_tag_mutability_exclusion_filter");
        set => SetArgument("image_tag_mutability_exclusion_filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEcrRepositoryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEcrRepositoryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
