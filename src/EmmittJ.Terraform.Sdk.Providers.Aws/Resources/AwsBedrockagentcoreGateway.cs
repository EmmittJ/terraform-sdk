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
    public TerraformProperty<string>? AuthorizerType
    {
        get => GetProperty<TerraformProperty<string>>("authorizer_type");
        set => this.WithProperty("authorizer_type", value);
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
    /// The exception_level attribute.
    /// </summary>
    public TerraformProperty<string>? ExceptionLevel
    {
        get => GetProperty<TerraformProperty<string>>("exception_level");
        set => this.WithProperty("exception_level", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
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
    /// The protocol_type attribute.
    /// </summary>
    public TerraformProperty<string>? ProtocolType
    {
        get => GetProperty<TerraformProperty<string>>("protocol_type");
        set => this.WithProperty("protocol_type", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
