using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_api_mapping resource.
/// </summary>
public class AwsApigatewayv2ApiMapping : TerraformResource
{
    public AwsApigatewayv2ApiMapping(string name) : base("aws_apigatewayv2_api_mapping", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public string? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id")?.Value;
        set => this.WithProperty("api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_mapping_key attribute.
    /// </summary>
    public string? ApiMappingKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_mapping_key")?.Value;
        set => this.WithProperty("api_mapping_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The stage attribute.
    /// </summary>
    public string? Stage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage")?.Value;
        set => this.WithProperty("stage", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
