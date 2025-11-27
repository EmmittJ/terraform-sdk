using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_resourceexplorer2_search Terraform data source.
/// Retrieves information about a aws_resourceexplorer2_search.
/// </summary>
public partial class AwsResourceexplorer2SearchDataSource(string name) : TerraformDataSource("aws_resourceexplorer2_search", name)
{
    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    public required TerraformValue<string> QueryString
    {
        get => new TerraformReference<string>(this, "query_string");
        set => SetArgument("query_string", value);
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
    /// The view_arn attribute.
    /// </summary>
    public TerraformValue<string> ViewArn
    {
        get => new TerraformReference<string>(this, "view_arn");
        set => SetArgument("view_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourceCount
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "resource_count").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Resources
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "resources").ResolveNodes(ctx));
    }

}
