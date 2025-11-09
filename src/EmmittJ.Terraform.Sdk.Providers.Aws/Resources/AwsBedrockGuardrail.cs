using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrock_guardrail resource.
/// </summary>
public class AwsBedrockGuardrail : TerraformResource
{
    public AwsBedrockGuardrail(string name) : base("aws_bedrock_guardrail", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_at");
        this.DeclareOutput("guardrail_arn");
        this.DeclareOutput("guardrail_id");
        this.DeclareOutput("status");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The blocked_input_messaging attribute.
    /// </summary>
    public TerraformProperty<string>? BlockedInputMessaging
    {
        get => GetProperty<TerraformProperty<string>>("blocked_input_messaging");
        set => this.WithProperty("blocked_input_messaging", value);
    }

    /// <summary>
    /// The blocked_outputs_messaging attribute.
    /// </summary>
    public TerraformProperty<string>? BlockedOutputsMessaging
    {
        get => GetProperty<TerraformProperty<string>>("blocked_outputs_messaging");
        set => this.WithProperty("blocked_outputs_messaging", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The guardrail_arn attribute.
    /// </summary>
    public TerraformExpression GuardrailArn => this["guardrail_arn"];

    /// <summary>
    /// The guardrail_id attribute.
    /// </summary>
    public TerraformExpression GuardrailId => this["guardrail_id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
