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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    public Dictionary<string, string>? ResponseParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("response_parameters")?.Value;
        set => this.WithProperty("response_parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public Dictionary<string, string>? ResponseTemplates
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("response_templates")?.Value;
        set => this.WithProperty("response_templates", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The response_type attribute.
    /// </summary>
    public string? ResponseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("response_type")?.Value;
        set => this.WithProperty("response_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public string? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id")?.Value;
        set => this.WithProperty("rest_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public string? StatusCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status_code")?.Value;
        set => this.WithProperty("status_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
