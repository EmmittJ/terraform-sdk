using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_integration_response Terraform resource.
/// Manages a aws_api_gateway_integration_response resource.
/// </summary>
public partial class AwsApiGatewayIntegrationResponse(string name) : TerraformResource("aws_api_gateway_integration_response", name)
{
    /// <summary>
    /// The content_handling attribute.
    /// </summary>
    public TerraformValue<string>? ContentHandling
    {
        get => new TerraformReference<string>(this, "content_handling");
        set => SetArgument("content_handling", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
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
    /// The response_parameters attribute.
    /// </summary>
    public TerraformMap<string>? ResponseParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "response_parameters").ResolveNodes(ctx));
        set => SetArgument("response_parameters", value);
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public TerraformMap<string>? ResponseTemplates
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "response_templates").ResolveNodes(ctx));
        set => SetArgument("response_templates", value);
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

    /// <summary>
    /// The selection_pattern attribute.
    /// </summary>
    public TerraformValue<string>? SelectionPattern
    {
        get => new TerraformReference<string>(this, "selection_pattern");
        set => SetArgument("selection_pattern", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<string> StatusCode
    {
        get => new TerraformReference<string>(this, "status_code");
        set => SetArgument("status_code", value);
    }

}
