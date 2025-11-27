using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_connect_vocabulary Terraform data source.
/// Retrieves information about a aws_connect_vocabulary.
/// </summary>
public partial class AwsConnectVocabularyDataSource(string name) : TerraformDataSource("aws_connect_vocabulary", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vocabulary_id attribute.
    /// </summary>
    public TerraformValue<string> VocabularyId
    {
        get => new TerraformReference<string>(this, "vocabulary_id");
        set => SetArgument("vocabulary_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
    }

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformValue<string> FailureReason
    {
        get => new TerraformReference<string>(this, "failure_reason");
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformValue<string> LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
    {
        get => new TerraformReference<string>(this, "last_modified_time");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}
