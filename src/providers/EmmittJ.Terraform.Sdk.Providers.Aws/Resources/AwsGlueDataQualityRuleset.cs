using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_table in AwsGlueDataQualityRuleset.
/// Nesting mode: list
/// </summary>
public class AwsGlueDataQualityRulesetTargetTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_table";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

}


/// <summary>
/// Represents a aws_glue_data_quality_ruleset Terraform resource.
/// Manages a aws_glue_data_quality_ruleset resource.
/// </summary>
public partial class AwsGlueDataQualityRuleset(string name) : TerraformResource("aws_glue_data_quality_ruleset", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The ruleset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ruleset is required")]
    public required TerraformValue<string> Ruleset
    {
        get => GetArgument<TerraformValue<string>>("ruleset");
        set => SetArgument("ruleset", value);
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
    /// The created_on attribute.
    /// </summary>
    public TerraformValue<string> CreatedOn
        => AsReference("created_on");

    /// <summary>
    /// The last_modified_on attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedOn
        => AsReference("last_modified_on");

    /// <summary>
    /// The recommendation_run_id attribute.
    /// </summary>
    public TerraformValue<string> RecommendationRunId
        => AsReference("recommendation_run_id");

    /// <summary>
    /// TargetTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTable block(s) allowed")]
    public TerraformList<AwsGlueDataQualityRulesetTargetTableBlock>? TargetTable
    {
        get => GetArgument<TerraformList<AwsGlueDataQualityRulesetTargetTableBlock>>("target_table");
        set => SetArgument("target_table", value);
    }

}
