using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_quicksight_analysis Terraform data source.
/// Retrieves information about a aws_quicksight_analysis.
/// </summary>
public partial class AwsQuicksightAnalysisDataSource(string name) : TerraformDataSource("aws_quicksight_analysis", name)
{
    /// <summary>
    /// The analysis_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AnalysisId is required")]
    public required TerraformValue<string> AnalysisId
    {
        get => new TerraformReference<string>(this, "analysis_id");
        set => SetArgument("analysis_id", value);
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
        set => SetArgument("aws_account_id", value);
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
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// The definition attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Definition
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "definition").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last_published_time attribute.
    /// </summary>
    public TerraformValue<string> LastPublishedTime
    {
        get => new TerraformReference<string>(this, "last_published_time");
    }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
    {
        get => new TerraformReference<string>(this, "last_updated_time");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Permissions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "permissions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The theme_arn attribute.
    /// </summary>
    public TerraformValue<string> ThemeArn
    {
        get => new TerraformReference<string>(this, "theme_arn");
    }

}
