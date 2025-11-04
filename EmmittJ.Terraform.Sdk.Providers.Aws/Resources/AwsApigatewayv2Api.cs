using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_api resource.
/// </summary>
public class AwsApigatewayv2Api : TerraformResource
{
    public AwsApigatewayv2Api(string name) : base("aws_apigatewayv2_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_endpoint");
        this.DeclareOutput("arn");
        this.DeclareOutput("execution_arn");
    }

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    public string? ApiKeySelectionExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_key_selection_expression")?.Value;
        set => this.WithProperty("api_key_selection_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public string? Body
    {
        get => GetProperty<TerraformLiteralProperty<string>>("body")?.Value;
        set => this.WithProperty("body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    public string? CredentialsArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credentials_arn")?.Value;
        set => this.WithProperty("credentials_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public bool? DisableExecuteApiEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_execute_api_endpoint")?.Value;
        set => this.WithProperty("disable_execute_api_endpoint", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public bool? FailOnWarnings
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fail_on_warnings")?.Value;
        set => this.WithProperty("fail_on_warnings", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The ip_address_type attribute.
    /// </summary>
    public string? IpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address_type")?.Value;
        set => this.WithProperty("ip_address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public string? ProtocolType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol_type")?.Value;
        set => this.WithProperty("protocol_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The route_key attribute.
    /// </summary>
    public string? RouteKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_key")?.Value;
        set => this.WithProperty("route_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    public string? RouteSelectionExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_selection_expression")?.Value;
        set => this.WithProperty("route_selection_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public string? Target
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target")?.Value;
        set => this.WithProperty("target", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    public TerraformExpression ApiEndpoint => this["api_endpoint"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionArn => this["execution_arn"];

}
