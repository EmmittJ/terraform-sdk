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
        SetOutput("api_key_required");
        SetOutput("authorization");
        SetOutput("authorization_scopes");
        SetOutput("authorizer_id");
        SetOutput("http_method");
        SetOutput("id");
        SetOutput("operation_name");
        SetOutput("region");
        SetOutput("request_models");
        SetOutput("request_parameters");
        SetOutput("request_validator_id");
        SetOutput("resource_id");
        SetOutput("rest_api_id");
    }

    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    public TerraformProperty<bool> ApiKeyRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("api_key_required");
        set => SetProperty("api_key_required", value);
    }

    /// <summary>
    /// The authorization attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    public required TerraformProperty<string> Authorization
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorization");
        set => SetProperty("authorization", value);
    }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AuthorizationScopes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("authorization_scopes");
        set => SetProperty("authorization_scopes", value);
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorizer_id");
        set => SetProperty("authorizer_id", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformProperty<string> HttpMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_method");
        set => SetProperty("http_method", value);
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
    /// The operation_name attribute.
    /// </summary>
    public TerraformProperty<string> OperationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("operation_name");
        set => SetProperty("operation_name", value);
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
    /// The request_models attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> RequestModels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("request_models");
        set => SetProperty("request_models", value);
    }

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<bool>> RequestParameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<bool>>>("request_parameters");
        set => SetProperty("request_parameters", value);
    }

    /// <summary>
    /// The request_validator_id attribute.
    /// </summary>
    public TerraformProperty<string> RequestValidatorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_validator_id");
        set => SetProperty("request_validator_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_id");
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rest_api_id");
        set => SetProperty("rest_api_id", value);
    }

}
