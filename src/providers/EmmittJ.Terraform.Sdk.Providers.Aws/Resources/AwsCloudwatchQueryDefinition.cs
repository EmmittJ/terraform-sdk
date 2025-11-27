using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_query_definition Terraform resource.
/// Manages a aws_cloudwatch_query_definition resource.
/// </summary>
public partial class AwsCloudwatchQueryDefinition(string name) : TerraformResource("aws_cloudwatch_query_definition", name)
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
    /// The log_group_names attribute.
    /// </summary>
    public TerraformList<string>? LogGroupNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "log_group_names").ResolveNodes(ctx));
        set => SetArgument("log_group_names", value);
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
    /// The query_definition_id attribute.
    /// </summary>
    public TerraformValue<string> QueryDefinitionId
    {
        get => new TerraformReference<string>(this, "query_definition_id");
    }

}
