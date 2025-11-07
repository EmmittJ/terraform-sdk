using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_route resource.
/// </summary>
public class AwsApigatewayv2Route : TerraformResource
{
    public AwsApigatewayv2Route(string name) : base("aws_apigatewayv2_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApiId
    {
        get => GetProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    public TerraformProperty<bool>? ApiKeyRequired
    {
        get => GetProperty<TerraformProperty<bool>>("api_key_required");
        set => this.WithProperty("api_key_required", value);
    }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AuthorizationScopes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("authorization_scopes");
        set => this.WithProperty("authorization_scopes", value);
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizationType
    {
        get => GetProperty<TerraformProperty<string>>("authorization_type");
        set => this.WithProperty("authorization_type", value);
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizerId
    {
        get => GetProperty<TerraformProperty<string>>("authorizer_id");
        set => this.WithProperty("authorizer_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string>? ModelSelectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("model_selection_expression");
        set => this.WithProperty("model_selection_expression", value);
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    public TerraformProperty<string>? OperationName
    {
        get => GetProperty<TerraformProperty<string>>("operation_name");
        set => this.WithProperty("operation_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The request_models attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? RequestModels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("request_models");
        set => this.WithProperty("request_models", value);
    }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    public TerraformProperty<string>? RouteKey
    {
        get => GetProperty<TerraformProperty<string>>("route_key");
        set => this.WithProperty("route_key", value);
    }

    /// <summary>
    /// The route_response_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string>? RouteResponseSelectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("route_response_selection_expression");
        set => this.WithProperty("route_response_selection_expression", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string>? Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => this.WithProperty("target", value);
    }

}
