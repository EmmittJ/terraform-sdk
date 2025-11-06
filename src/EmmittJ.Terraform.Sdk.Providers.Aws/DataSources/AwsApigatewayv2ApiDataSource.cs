using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_apigatewayv2_api.
/// </summary>
public class AwsApigatewayv2ApiDataSource : TerraformDataSource
{
    public AwsApigatewayv2ApiDataSource(string name) : base("aws_apigatewayv2_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_endpoint");
        this.DeclareOutput("api_key_selection_expression");
        this.DeclareOutput("arn");
        this.DeclareOutput("cors_configuration");
        this.DeclareOutput("description");
        this.DeclareOutput("disable_execute_api_endpoint");
        this.DeclareOutput("execution_arn");
        this.DeclareOutput("ip_address_type");
        this.DeclareOutput("name");
        this.DeclareOutput("protocol_type");
        this.DeclareOutput("route_selection_expression");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public string? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id")?.Value;
        set => this.WithProperty("api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    public TerraformExpression ApiEndpoint => this["api_endpoint"];

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    public TerraformExpression ApiKeySelectionExpression => this["api_key_selection_expression"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    public TerraformExpression CorsConfiguration => this["cors_configuration"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformExpression DisableExecuteApiEndpoint => this["disable_execute_api_endpoint"];

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionArn => this["execution_arn"];

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformExpression IpAddressType => this["ip_address_type"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public TerraformExpression ProtocolType => this["protocol_type"];

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    public TerraformExpression RouteSelectionExpression => this["route_selection_expression"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
