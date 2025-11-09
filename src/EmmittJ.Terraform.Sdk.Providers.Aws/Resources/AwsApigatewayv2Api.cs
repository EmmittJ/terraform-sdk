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
    public TerraformProperty<string>? ApiKeySelectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("api_key_selection_expression");
        set => this.WithProperty("api_key_selection_expression", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformProperty<string>? Body
    {
        get => GetProperty<TerraformProperty<string>>("body");
        set => this.WithProperty("body", value);
    }

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CredentialsArn
    {
        get => GetProperty<TerraformProperty<string>>("credentials_arn");
        set => this.WithProperty("credentials_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableExecuteApiEndpoint
    {
        get => GetProperty<TerraformProperty<bool>>("disable_execute_api_endpoint");
        set => this.WithProperty("disable_execute_api_endpoint", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformProperty<bool>? FailOnWarnings
    {
        get => GetProperty<TerraformProperty<bool>>("fail_on_warnings");
        set => this.WithProperty("fail_on_warnings", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public TerraformProperty<string>? ProtocolType
    {
        get => GetProperty<TerraformProperty<string>>("protocol_type");
        set => this.WithProperty("protocol_type", value);
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
    /// The route_key attribute.
    /// </summary>
    public TerraformProperty<string>? RouteKey
    {
        get => GetProperty<TerraformProperty<string>>("route_key");
        set => this.WithProperty("route_key", value);
    }

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string>? RouteSelectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("route_selection_expression");
        set => this.WithProperty("route_selection_expression", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string>? Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
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
