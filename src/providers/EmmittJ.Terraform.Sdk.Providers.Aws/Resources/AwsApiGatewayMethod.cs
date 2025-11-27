using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_method Terraform resource.
/// Manages a aws_api_gateway_method resource.
/// </summary>
public partial class AwsApiGatewayMethod(string name) : TerraformResource("aws_api_gateway_method", name)
{
    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    public TerraformValue<bool>? ApiKeyRequired
    {
        get => new TerraformReference<bool>(this, "api_key_required");
        set => SetArgument("api_key_required", value);
    }

    /// <summary>
    /// The authorization attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    public required TerraformValue<string> Authorization
    {
        get => new TerraformReference<string>(this, "authorization");
        set => SetArgument("authorization", value);
    }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    public TerraformSet<string>? AuthorizationScopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "authorization_scopes").ResolveNodes(ctx));
        set => SetArgument("authorization_scopes", value);
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizerId
    {
        get => new TerraformReference<string>(this, "authorizer_id");
        set => SetArgument("authorizer_id", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformValue<string> HttpMethod
    {
        get => new TerraformReference<string>(this, "http_method");
        set => SetArgument("http_method", value);
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
    /// The operation_name attribute.
    /// </summary>
    public TerraformValue<string>? OperationName
    {
        get => new TerraformReference<string>(this, "operation_name");
        set => SetArgument("operation_name", value);
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
    /// The request_models attribute.
    /// </summary>
    public TerraformMap<string>? RequestModels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "request_models").ResolveNodes(ctx));
        set => SetArgument("request_models", value);
    }

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    public TerraformMap<bool>? RequestParameters
    {
        get => TerraformMap<bool>.Lazy(ctx => new TerraformReference<TerraformMap<bool>>(this, "request_parameters").ResolveNodes(ctx));
        set => SetArgument("request_parameters", value);
    }

    /// <summary>
    /// The request_validator_id attribute.
    /// </summary>
    public TerraformValue<string>? RequestValidatorId
    {
        get => new TerraformReference<string>(this, "request_validator_id");
        set => SetArgument("request_validator_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => new TerraformReference<string>(this, "rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

}
