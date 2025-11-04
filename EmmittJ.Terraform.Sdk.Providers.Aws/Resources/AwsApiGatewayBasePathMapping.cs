using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_base_path_mapping resource.
/// </summary>
public class AwsApiGatewayBasePathMapping : TerraformResource
{
    public AwsApiGatewayBasePathMapping(string name) : base("aws_api_gateway_base_path_mapping", name)
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
    /// The base_path attribute.
    /// </summary>
    public string? BasePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("base_path")?.Value;
        set => this.WithProperty("base_path", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The domain_name_id attribute.
    /// </summary>
    public string? DomainNameId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name_id")?.Value;
        set => this.WithProperty("domain_name_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The stage_name attribute.
    /// </summary>
    public string? StageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage_name")?.Value;
        set => this.WithProperty("stage_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
