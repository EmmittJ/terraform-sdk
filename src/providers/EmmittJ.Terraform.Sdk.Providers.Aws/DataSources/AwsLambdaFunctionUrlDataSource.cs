using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lambda_function_url Terraform data source.
/// Retrieves information about a aws_lambda_function_url.
/// </summary>
public partial class AwsLambdaFunctionUrlDataSource(string name) : TerraformDataSource("aws_lambda_function_url", name)
{
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformValue<string>? Qualifier
    {
        get => new TerraformReference<string>(this, "qualifier");
        set => SetArgument("qualifier", value);
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
    /// The authorization_type attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationType
    {
        get => new TerraformReference<string>(this, "authorization_type");
    }

    /// <summary>
    /// The cors attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Cors
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cors").ResolveNodes(ctx));
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    public TerraformValue<string> FunctionArn
    {
        get => new TerraformReference<string>(this, "function_arn");
    }

    /// <summary>
    /// The function_url attribute.
    /// </summary>
    public TerraformValue<string> FunctionUrl
    {
        get => new TerraformReference<string>(this, "function_url");
    }

    /// <summary>
    /// The invoke_mode attribute.
    /// </summary>
    public TerraformValue<string> InvokeMode
    {
        get => new TerraformReference<string>(this, "invoke_mode");
    }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTime
    {
        get => new TerraformReference<string>(this, "last_modified_time");
    }

    /// <summary>
    /// The url_id attribute.
    /// </summary>
    public TerraformValue<string> UrlId
    {
        get => new TerraformReference<string>(this, "url_id");
    }

}
