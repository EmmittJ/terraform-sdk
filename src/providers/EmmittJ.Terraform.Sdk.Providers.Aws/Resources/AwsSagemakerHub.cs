using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_storage_config in AwsSagemakerHub.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerHubS3StorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_storage_config";

    /// <summary>
    /// The s3_output_path attribute.
    /// </summary>
    public TerraformValue<string>? S3OutputPath
    {
        get => GetArgument<TerraformValue<string>>("s3_output_path");
        set => SetArgument("s3_output_path", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_hub Terraform resource.
/// Manages a aws_sagemaker_hub resource.
/// </summary>
public partial class AwsSagemakerHub(string name) : TerraformResource("aws_sagemaker_hub", name)
{
    /// <summary>
    /// The hub_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubDescription is required")]
    public required TerraformValue<string> HubDescription
    {
        get => GetArgument<TerraformValue<string>>("hub_description");
        set => SetArgument("hub_description", value);
    }

    /// <summary>
    /// The hub_display_name attribute.
    /// </summary>
    public TerraformValue<string>? HubDisplayName
    {
        get => GetArgument<TerraformValue<string>>("hub_display_name");
        set => SetArgument("hub_display_name", value);
    }

    /// <summary>
    /// The hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubName is required")]
    public required TerraformValue<string> HubName
    {
        get => GetArgument<TerraformValue<string>>("hub_name");
        set => SetArgument("hub_name", value);
    }

    /// <summary>
    /// The hub_search_keywords attribute.
    /// </summary>
    public TerraformSet<string>? HubSearchKeywords
    {
        get => GetArgument<TerraformSet<string>>("hub_search_keywords");
        set => SetArgument("hub_search_keywords", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// S3StorageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3StorageConfig block(s) allowed")]
    public TerraformList<AwsSagemakerHubS3StorageConfigBlock>? S3StorageConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerHubS3StorageConfigBlock>>("s3_storage_config");
        set => SetArgument("s3_storage_config", value);
    }

}
