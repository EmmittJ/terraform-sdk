using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_gateway_response resource.
/// </summary>
public class AwsApiGatewayGatewayResponse : TerraformResource
{
    public AwsApiGatewayGatewayResponse(string name) : base("aws_api_gateway_gateway_response", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("region");
        SetOutput("response_parameters");
        SetOutput("response_templates");
        SetOutput("response_type");
        SetOutput("rest_api_id");
        SetOutput("status_code");
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
    /// The response_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseType is required")]
    public required TerraformProperty<string> ResponseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("response_type");
        set => SetProperty("response_type", value);
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
    public TerraformProperty<string> StatusCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status_code");
        set => SetProperty("status_code", value);
    }

}
