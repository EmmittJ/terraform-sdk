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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The validate_request_body attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ValidateRequestBody
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("validate_request_body");
        set => this.WithProperty("validate_request_body", value);
    }

    /// <summary>
    /// The validate_request_parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ValidateRequestParameters
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("validate_request_parameters");
        set => this.WithProperty("validate_request_parameters", value);
    }

}
