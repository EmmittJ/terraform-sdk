using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_request_validator resource.
/// </summary>
public class AwsApiGatewayRequestValidator : TerraformResource
{
    public AwsApiGatewayRequestValidator(string name) : base("aws_api_gateway_request_validator", name)
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The validate_request_body attribute.
    /// </summary>
    public bool? ValidateRequestBody
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("validate_request_body")?.Value;
        set => this.WithProperty("validate_request_body", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The validate_request_parameters attribute.
    /// </summary>
    public bool? ValidateRequestParameters
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("validate_request_parameters")?.Value;
        set => this.WithProperty("validate_request_parameters", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
