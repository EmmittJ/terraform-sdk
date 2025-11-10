using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_method_response resource.
/// </summary>
public class AwsApiGatewayMethodResponse : TerraformResource
{
    public AwsApiGatewayMethodResponse(string name) : base("aws_api_gateway_method_response", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The response_models attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResponseModels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("response_models");
        set => this.WithProperty("response_models", value);
    }

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<bool>>? ResponseParameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<bool>>>("response_parameters");
        set => this.WithProperty("response_parameters", value);
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

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformProperty<string> StatusCode
    {
        get => GetProperty<TerraformProperty<string>>("status_code");
        set => this.WithProperty("status_code", value);
    }

}
