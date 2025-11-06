using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_gateway resource.
/// </summary>
public class AwsBedrockagentcoreGateway : TerraformResource
{
    public AwsBedrockagentcoreGateway(string name) : base("aws_bedrockagentcore_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("gateway_arn");
        this.DeclareOutput("gateway_id");
        this.DeclareOutput("gateway_url");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("workload_identity_details");
    }

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    public string? AuthorizerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_type")?.Value;
        set => this.WithProperty("authorizer_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The exception_level attribute.
    /// </summary>
    public string? ExceptionLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("exception_level")?.Value;
        set => this.WithProperty("exception_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public string? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn")?.Value;
        set => this.WithProperty("kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    public string? ProtocolType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol_type")?.Value;
        set => this.WithProperty("protocol_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    public TerraformExpression GatewayArn => this["gateway_arn"];

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformExpression GatewayId => this["gateway_id"];

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    public TerraformExpression GatewayUrl => this["gateway_url"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The workload_identity_details attribute.
    /// </summary>
    public TerraformExpression WorkloadIdentityDetails => this["workload_identity_details"];

}
