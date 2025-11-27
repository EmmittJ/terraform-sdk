using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_gateway_response Terraform resource.
/// Manages a aws_api_gateway_gateway_response resource.
/// </summary>
public partial class AwsApiGatewayGatewayResponse(string name) : TerraformResource("aws_api_gateway_gateway_response", name)
{
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
    /// The response_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseType is required")]
    public required TerraformValue<string> ResponseType
    {
        get => new TerraformReference<string>(this, "response_type");
        set => SetArgument("response_type", value);
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
    /// The status_code attribute.
    /// </summary>
    public TerraformValue<string>? StatusCode
    {
        get => new TerraformReference<string>(this, "status_code");
        set => SetArgument("status_code", value);
    }

}
