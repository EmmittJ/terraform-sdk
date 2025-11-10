using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbInstanceAutomatedBackupsReplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The pre_signed_url attribute.
    /// </summary>
    public TerraformProperty<string>? PreSignedUrl
    {
        get => GetProperty<TerraformProperty<string>>("pre_signed_url");
        set => this.WithProperty("pre_signed_url", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("retention_period");
        set => this.WithProperty("retention_period", value);
    }

    /// <summary>
    /// The source_db_instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDbInstanceArn is required")]
    public required TerraformProperty<string> SourceDbInstanceArn
    {
        get => GetProperty<TerraformProperty<string>>("source_db_instance_arn");
        set => this.WithProperty("source_db_instance_arn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbInstanceAutomatedBackupsReplicationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDbInstanceAutomatedBackupsReplicationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
