using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_usage_limit resource.
/// </summary>
public class AwsRedshiftserverlessUsageLimit : TerraformResource
{
    public AwsRedshiftserverlessUsageLimit(string name) : base("aws_redshiftserverless_usage_limit", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    public double? Amount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("amount")?.Value;
        set => this.WithProperty("amount", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    public string? BreachAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("breach_action")?.Value;
        set => this.WithProperty("breach_action", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The period attribute.
    /// </summary>
    public string? Period
    {
        get => GetProperty<TerraformLiteralProperty<string>>("period")?.Value;
        set => this.WithProperty("period", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public string? ResourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_arn")?.Value;
        set => this.WithProperty("resource_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    public string? UsageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("usage_type")?.Value;
        set => this.WithProperty("usage_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
