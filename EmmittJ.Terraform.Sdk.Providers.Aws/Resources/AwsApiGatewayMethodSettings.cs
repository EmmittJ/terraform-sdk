using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_method_settings resource.
/// </summary>
public class AwsApiGatewayMethodSettings : TerraformResource
{
    public AwsApiGatewayMethodSettings(string name) : base("aws_api_gateway_method_settings", name)
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
    /// The method_path attribute.
    /// </summary>
    public string? MethodPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("method_path")?.Value;
        set => this.WithProperty("method_path", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The stage_name attribute.
    /// </summary>
    public string? StageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage_name")?.Value;
        set => this.WithProperty("stage_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
