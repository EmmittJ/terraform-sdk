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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_group_names attribute.
    /// </summary>
    public TerraformList<string>? LogGroupNames
    {
        get => GetArgument<TerraformList<string>>("log_group_names");
        set => SetArgument("log_group_names", value);
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
    /// The query_definition_id attribute.
    /// </summary>
    public TerraformValue<string> QueryDefinitionId
        => AsReference("query_definition_id");

}
