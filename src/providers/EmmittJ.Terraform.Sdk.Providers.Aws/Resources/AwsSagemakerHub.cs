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
        get => new TerraformReference<string>(this, "s3_output_path");
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
        get => new TerraformReference<string>(this, "hub_description");
        set => SetArgument("hub_description", value);
    }

    /// <summary>
    /// The hub_display_name attribute.
    /// </summary>
    public TerraformValue<string>? HubDisplayName
    {
        get => new TerraformReference<string>(this, "hub_display_name");
        set => SetArgument("hub_display_name", value);
    }

    /// <summary>
    /// The hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubName is required")]
    public required TerraformValue<string> HubName
    {
        get => new TerraformReference<string>(this, "hub_name");
        set => SetArgument("hub_name", value);
    }

    /// <summary>
    /// The hub_search_keywords attribute.
    /// </summary>
    public TerraformSet<string>? HubSearchKeywords
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "hub_search_keywords").ResolveNodes(ctx));
        set => SetArgument("hub_search_keywords", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

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
