using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_usage_plan_key resource.
/// </summary>
public class AwsApiGatewayUsagePlanKey : TerraformResource
{
    public AwsApiGatewayUsagePlanKey(string name) : base("aws_api_gateway_usage_plan_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("value");
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
    /// The key_id attribute.
    /// </summary>
    public string? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id")?.Value;
        set => this.WithProperty("key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public string? KeyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_type")?.Value;
        set => this.WithProperty("key_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The usage_plan_id attribute.
    /// </summary>
    public string? UsagePlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("usage_plan_id")?.Value;
        set => this.WithProperty("usage_plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformExpression Value => this["value"];

}
