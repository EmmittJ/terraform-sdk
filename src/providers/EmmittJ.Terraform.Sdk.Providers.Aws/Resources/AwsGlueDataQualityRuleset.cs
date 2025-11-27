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
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
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
    /// The ruleset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ruleset is required")]
    public required TerraformValue<string> Ruleset
    {
        get => new TerraformReference<string>(this, "ruleset");
        set => SetArgument("ruleset", value);
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
    /// The created_on attribute.
    /// </summary>
    public TerraformValue<string> CreatedOn
    {
        get => new TerraformReference<string>(this, "created_on");
    }

    /// <summary>
    /// The last_modified_on attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedOn
    {
        get => new TerraformReference<string>(this, "last_modified_on");
    }

    /// <summary>
    /// The recommendation_run_id attribute.
    /// </summary>
    public TerraformValue<string> RecommendationRunId
    {
        get => new TerraformReference<string>(this, "recommendation_run_id");
    }

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
