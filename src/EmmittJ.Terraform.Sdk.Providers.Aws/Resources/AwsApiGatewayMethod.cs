using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_method resource.
/// </summary>
public class AwsApiGatewayMethod : TerraformResource
{
    public AwsApiGatewayMethod(string name) : base("aws_api_gateway_method", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The authorization attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    public required TerraformProperty<string> Authorization
    {
        get => GetProperty<TerraformProperty<string>>("authorization");
        set => this.WithProperty("authorization", value);
    }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AuthorizationScopes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("authorization_scopes");
        set => this.WithProperty("authorization_scopes", value);
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
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformProperty<string> HttpMethod
    {
        get => GetProperty<TerraformProperty<string>>("http_method");
        set => this.WithProperty("http_method", value);
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
    public Dictionary<string, TerraformProperty<string>>? RequestModels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("request_models");
        set => this.WithProperty("request_models", value);
    }

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<bool>>? RequestParameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<bool>>>("request_parameters");
        set => this.WithProperty("request_parameters", value);
    }

    /// <summary>
    /// The request_validator_id attribute.
    /// </summary>
    public TerraformProperty<string>? RequestValidatorId
    {
        get => GetProperty<TerraformProperty<string>>("request_validator_id");
        set => this.WithProperty("request_validator_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

}
