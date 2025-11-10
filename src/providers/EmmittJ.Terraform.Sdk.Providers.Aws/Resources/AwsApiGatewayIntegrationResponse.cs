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
        SetOutput("content_handling");
        SetOutput("http_method");
        SetOutput("id");
        SetOutput("region");
        SetOutput("resource_id");
        SetOutput("response_parameters");
        SetOutput("response_templates");
        SetOutput("rest_api_id");
        SetOutput("selection_pattern");
        SetOutput("status_code");
    }

    /// <summary>
    /// The content_handling attribute.
    /// </summary>
    public TerraformProperty<string> ContentHandling
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_handling");
        set => SetProperty("content_handling", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// The response_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResponseParameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("response_parameters");
        set => SetProperty("response_parameters", value);
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResponseTemplates
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("response_templates");
        set => SetProperty("response_templates", value);
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

    /// <summary>
    /// The selection_pattern attribute.
    /// </summary>
    public TerraformProperty<string> SelectionPattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("selection_pattern");
        set => SetProperty("selection_pattern", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformProperty<string> StatusCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status_code");
        set => SetProperty("status_code", value);
    }

}
