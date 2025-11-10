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
        SetOutput("api_endpoint");
        SetOutput("api_key_selection_expression");
        SetOutput("arn");
        SetOutput("cors_configuration");
        SetOutput("description");
        SetOutput("disable_execute_api_endpoint");
        SetOutput("execution_arn");
        SetOutput("ip_address_type");
        SetOutput("name");
        SetOutput("protocol_type");
        SetOutput("route_selection_expression");
        SetOutput("version");
        SetOutput("api_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
