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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_type");
        set => this.WithProperty("key_type", value);
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
    /// The usage_plan_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UsagePlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("usage_plan_id");
        set => this.WithProperty("usage_plan_id", value);
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
