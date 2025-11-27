using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for routing_config in AwsLambdaAlias.
/// Nesting mode: list
/// </summary>
public class AwsLambdaAliasRoutingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing_config";

    /// <summary>
    /// The additional_version_weights attribute.
    /// </summary>
    public TerraformMap<double>? AdditionalVersionWeights
    {
        get => TerraformMap<double>.Lazy(ctx => new TerraformReference<TerraformMap<double>>(this, "additional_version_weights").ResolveNodes(ctx));
        set => SetArgument("additional_version_weights", value);
    }

}


/// <summary>
/// Represents a aws_lambda_alias Terraform resource.
/// Manages a aws_lambda_alias resource.
/// </summary>
public partial class AwsLambdaAlias(string name) : TerraformResource("aws_lambda_alias", name)
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
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => new TerraformReference<string>(this, "function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The function_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionVersion is required")]
    public required TerraformValue<string> FunctionVersion
    {
        get => new TerraformReference<string>(this, "function_version");
        set => SetArgument("function_version", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    public TerraformValue<string> InvokeArn
    {
        get => new TerraformReference<string>(this, "invoke_arn");
    }

    /// <summary>
    /// RoutingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingConfig block(s) allowed")]
    public TerraformList<AwsLambdaAliasRoutingConfigBlock>? RoutingConfig
    {
        get => GetArgument<TerraformList<AwsLambdaAliasRoutingConfigBlock>>("routing_config");
        set => SetArgument("routing_config", value);
    }

}
