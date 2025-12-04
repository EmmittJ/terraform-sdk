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
        get => GetArgument<TerraformValue<string>>("query_string");
        set => SetArgument("query_string", value);
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
    /// The view_arn attribute.
    /// </summary>
    public TerraformValue<string>? ViewArn
    {
        get => GetArgument<TerraformValue<string>>("view_arn");
        set => SetArgument("view_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourceCount
        => AsReference("resource_count");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Resources
        => AsReference("resources");

}
