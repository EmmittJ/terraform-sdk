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
    public TerraformLiteralProperty<string>? HttpMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_method");
        set => this.WithProperty("http_method", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// The response_models attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? ResponseModels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("response_models");
        set => this.WithProperty("response_models", value);
    }

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, bool>>? ResponseParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, bool>>>("response_parameters");
        set => this.WithProperty("response_parameters", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StatusCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status_code");
        set => this.WithProperty("status_code", value);
    }

}
