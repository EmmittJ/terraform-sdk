using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_apigatewayv2_route_response Terraform resource.
/// Manages a aws_apigatewayv2_route_response resource.
/// </summary>
public partial class AwsApigatewayv2RouteResponse(string name) : TerraformResource("aws_apigatewayv2_route_response", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => new TerraformReference<string>(this, "api_id");
        set => SetArgument("api_id", value);
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
    /// The model_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? ModelSelectionExpression
    {
        get => new TerraformReference<string>(this, "model_selection_expression");
        set => SetArgument("model_selection_expression", value);
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
    /// The response_models attribute.
    /// </summary>
    public TerraformMap<string>? ResponseModels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "response_models").ResolveNodes(ctx));
        set => SetArgument("response_models", value);
    }

    /// <summary>
    /// The route_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteId is required")]
    public required TerraformValue<string> RouteId
    {
        get => new TerraformReference<string>(this, "route_id");
        set => SetArgument("route_id", value);
    }

    /// <summary>
    /// The route_response_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteResponseKey is required")]
    public required TerraformValue<string> RouteResponseKey
    {
        get => new TerraformReference<string>(this, "route_response_key");
        set => SetArgument("route_response_key", value);
    }

}
