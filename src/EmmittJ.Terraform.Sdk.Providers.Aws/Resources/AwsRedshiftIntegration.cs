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
    public TerraformMapProperty<string>? AdditionalEncryptionContext
    {
        get => GetProperty<TerraformMapProperty<string>>("additional_encryption_context");
        set => this.WithProperty("additional_encryption_context", value);
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
    /// The integration_name attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationName
    {
        get => GetProperty<TerraformProperty<string>>("integration_name");
        set => this.WithProperty("integration_name", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
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
    /// The source_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceArn
    {
        get => GetProperty<TerraformProperty<string>>("source_arn");
        set => this.WithProperty("source_arn", value);
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
    /// The target_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TargetArn
    {
        get => GetProperty<TerraformProperty<string>>("target_arn");
        set => this.WithProperty("target_arn", value);
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
