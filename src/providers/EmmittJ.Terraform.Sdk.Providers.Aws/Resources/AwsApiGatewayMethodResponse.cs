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
        SetOutput("http_method");
        SetOutput("id");
        SetOutput("region");
        SetOutput("resource_id");
        SetOutput("response_models");
        SetOutput("response_parameters");
        SetOutput("rest_api_id");
        SetOutput("status_code");
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
    /// The response_models attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResponseModels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("response_models");
        set => SetProperty("response_models", value);
    }

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<bool>> ResponseParameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<bool>>>("response_parameters");
        set => SetProperty("response_parameters", value);
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
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformProperty<string> StatusCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status_code");
        set => SetProperty("status_code", value);
    }

}
