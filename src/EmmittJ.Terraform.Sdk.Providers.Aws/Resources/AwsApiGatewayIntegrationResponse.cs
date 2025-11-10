using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_integration_response resource.
/// </summary>
public class AwsApiGatewayIntegrationResponse : TerraformResource
{
    public AwsApiGatewayIntegrationResponse(string name) : base("aws_api_gateway_integration_response", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The content_handling attribute.
    /// </summary>
    public TerraformProperty<string>? ContentHandling
    {
        get => GetProperty<TerraformProperty<string>>("content_handling");
        set => this.WithProperty("content_handling", value);
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
    /// The response_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResponseParameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("response_parameters");
        set => this.WithProperty("response_parameters", value);
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResponseTemplates
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("response_templates");
        set => this.WithProperty("response_templates", value);
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
    /// The selection_pattern attribute.
    /// </summary>
    public TerraformProperty<string>? SelectionPattern
    {
        get => GetProperty<TerraformProperty<string>>("selection_pattern");
        set => this.WithProperty("selection_pattern", value);
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
