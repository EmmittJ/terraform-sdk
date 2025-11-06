using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_db_instance_automated_backups_replication resource.
/// </summary>
public class AwsDbInstanceAutomatedBackupsReplication : TerraformResource
{
    public AwsDbInstanceAutomatedBackupsReplication(string name) : base("aws_db_instance_automated_backups_replication", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pre_signed_url attribute.
    /// </summary>
    public string? PreSignedUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pre_signed_url")?.Value;
        set => this.WithProperty("pre_signed_url", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The retention_period attribute.
    /// </summary>
    public double? RetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_period")?.Value;
        set => this.WithProperty("retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The source_db_instance_arn attribute.
    /// </summary>
    public string? SourceDbInstanceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_db_instance_arn")?.Value;
        set => this.WithProperty("source_db_instance_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
