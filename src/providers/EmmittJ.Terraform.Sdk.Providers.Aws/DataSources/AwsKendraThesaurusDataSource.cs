using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kendra_thesaurus Terraform data source.
/// Retrieves information about a aws_kendra_thesaurus.
/// </summary>
public partial class AwsKendraThesaurusDataSource(string name) : TerraformDataSource("aws_kendra_thesaurus", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    public required TerraformValue<string> IndexId
    {
        get => GetArgument<TerraformValue<string>>("index_id");
        set => SetArgument("index_id", value);
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
    /// The thesaurus_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThesaurusId is required")]
    public required TerraformValue<string> ThesaurusId
    {
        get => GetArgument<TerraformValue<string>>("thesaurus_id");
        set => SetArgument("thesaurus_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformValue<string> ErrorMessage
        => AsReference("error_message");

    /// <summary>
    /// The file_size_bytes attribute.
    /// </summary>
    public TerraformValue<double> FileSizeBytes
        => AsReference("file_size_bytes");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => AsReference("role_arn");

    /// <summary>
    /// The source_s3_path attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceS3Path
        => AsReference("source_s3_path");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The synonym_rule_count attribute.
    /// </summary>
    public TerraformValue<double> SynonymRuleCount
        => AsReference("synonym_rule_count");

    /// <summary>
    /// The term_count attribute.
    /// </summary>
    public TerraformValue<double> TermCount
        => AsReference("term_count");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

}
