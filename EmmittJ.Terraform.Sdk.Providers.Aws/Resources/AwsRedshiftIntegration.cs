using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_integration resource.
/// </summary>
public class AwsRedshiftIntegration : TerraformResource
{
    public AwsRedshiftIntegration(string name) : base("aws_redshift_integration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public Dictionary<string, string>? AdditionalEncryptionContext
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_encryption_context")?.Value;
        set => this.WithProperty("additional_encryption_context", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The integration_name attribute.
    /// </summary>
    public string? IntegrationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_name")?.Value;
        set => this.WithProperty("integration_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public string? SourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_arn")?.Value;
        set => this.WithProperty("source_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_arn attribute.
    /// </summary>
    public string? TargetArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_arn")?.Value;
        set => this.WithProperty("target_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
