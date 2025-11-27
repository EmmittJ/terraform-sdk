using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_db_event_categories Terraform data source.
/// Retrieves information about a aws_db_event_categories.
/// </summary>
public partial class AwsDbEventCategoriesDataSource(string name) : TerraformDataSource("aws_db_event_categories", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    public TerraformValue<string>? SourceType
    {
        get => new TerraformReference<string>(this, "source_type");
        set => SetArgument("source_type", value);
    }

    /// <summary>
    /// The event_categories attribute.
    /// </summary>
    public TerraformList<string> EventCategories
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "event_categories").ResolveNodes(ctx));
    }

}
