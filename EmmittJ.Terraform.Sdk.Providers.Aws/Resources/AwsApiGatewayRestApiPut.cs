using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_rest_api_put resource.
/// </summary>
public class AwsApiGatewayRestApiPut : TerraformResource
{
    public AwsApiGatewayRestApiPut(string name) : base("aws_api_gateway_rest_api_put", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public string? Body
    {
        get => GetProperty<TerraformLiteralProperty<string>>("body")?.Value;
        set => this.WithProperty("body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public bool? FailOnWarnings
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fail_on_warnings")?.Value;
        set => this.WithProperty("fail_on_warnings", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, string>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers")?.Value;
        set => this.WithProperty("triggers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
