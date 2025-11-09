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
    public TerraformProperty<string>? HttpMethod
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
    public TerraformProperty<string>? ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// The response_models attribute.
    /// </summary>
    public TerraformMapProperty<string>? ResponseModels
    {
        get => GetProperty<TerraformMapProperty<string>>("response_models");
        set => this.WithProperty("response_models", value);
    }

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    public TerraformMapProperty<bool>? ResponseParameters
    {
        get => GetProperty<TerraformMapProperty<bool>>("response_parameters");
        set => this.WithProperty("response_parameters", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public TerraformProperty<string>? RestApiId
    {
        get => GetProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformProperty<string>? StatusCode
    {
        get => GetProperty<TerraformProperty<string>>("status_code");
        set => this.WithProperty("status_code", value);
    }

}
