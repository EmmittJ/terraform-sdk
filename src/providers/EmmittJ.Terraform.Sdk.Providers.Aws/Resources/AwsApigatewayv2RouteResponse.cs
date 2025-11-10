using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_route_response resource.
/// </summary>
public class AwsApigatewayv2RouteResponse : TerraformResource
{
    public AwsApigatewayv2RouteResponse(string name) : base("aws_apigatewayv2_route_response", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_id");
        SetOutput("id");
        SetOutput("model_selection_expression");
        SetOutput("region");
        SetOutput("response_models");
        SetOutput("route_id");
        SetOutput("route_response_key");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_id");
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string> ModelSelectionExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("model_selection_expression");
        set => SetProperty("model_selection_expression", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The response_models attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResponseModels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("response_models");
        set => SetProperty("response_models", value);
    }

    /// <summary>
    /// The route_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteId is required")]
    public required TerraformProperty<string> RouteId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_id");
        set => SetProperty("route_id", value);
    }

    /// <summary>
    /// The route_response_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteResponseKey is required")]
    public required TerraformProperty<string> RouteResponseKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_response_key");
        set => SetProperty("route_response_key", value);
    }

}
