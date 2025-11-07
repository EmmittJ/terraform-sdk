using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_gateway_target resource.
/// </summary>
public class AwsBedrockagentcoreGatewayTarget : TerraformResource
{
    public AwsBedrockagentcoreGatewayTarget(string name) : base("aws_bedrockagentcore_gateway_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("target_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The gateway_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("gateway_identifier");
        set => this.WithProperty("gateway_identifier", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    /// The target_id attribute.
    /// </summary>
    public TerraformExpression TargetId => this["target_id"];

}
