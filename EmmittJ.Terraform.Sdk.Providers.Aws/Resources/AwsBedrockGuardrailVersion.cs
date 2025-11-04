using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrock_guardrail_version resource.
/// </summary>
public class AwsBedrockGuardrailVersion : TerraformResource
{
    public AwsBedrockGuardrailVersion(string name) : base("aws_bedrock_guardrail_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("version");
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
    /// The guardrail_arn attribute.
    /// </summary>
    public string? GuardrailArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("guardrail_arn")?.Value;
        set => this.WithProperty("guardrail_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public bool? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy")?.Value;
        set => this.WithProperty("skip_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
