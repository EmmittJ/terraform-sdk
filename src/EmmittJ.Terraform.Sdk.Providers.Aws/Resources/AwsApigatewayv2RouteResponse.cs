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
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ModelSelectionExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model_selection_expression");
        set => this.WithProperty("model_selection_expression", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The response_models attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? ResponseModels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("response_models");
        set => this.WithProperty("response_models", value);
    }

    /// <summary>
    /// The route_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RouteId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_id");
        set => this.WithProperty("route_id", value);
    }

    /// <summary>
    /// The route_response_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RouteResponseKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_response_key");
        set => this.WithProperty("route_response_key", value);
    }

}
