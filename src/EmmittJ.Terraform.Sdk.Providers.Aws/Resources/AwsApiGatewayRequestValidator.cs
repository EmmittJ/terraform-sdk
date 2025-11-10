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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The validate_request_body attribute.
    /// </summary>
    public TerraformProperty<bool>? ValidateRequestBody
    {
        get => GetProperty<TerraformProperty<bool>>("validate_request_body");
        set => this.WithProperty("validate_request_body", value);
    }

    /// <summary>
    /// The validate_request_parameters attribute.
    /// </summary>
    public TerraformProperty<bool>? ValidateRequestParameters
    {
        get => GetProperty<TerraformProperty<bool>>("validate_request_parameters");
        set => this.WithProperty("validate_request_parameters", value);
    }

}
