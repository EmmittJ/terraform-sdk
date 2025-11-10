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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("pre_signed_url");
        SetOutput("region");
        SetOutput("retention_period");
        SetOutput("source_db_instance_arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The pre_signed_url attribute.
    /// </summary>
    public TerraformProperty<string> PreSignedUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pre_signed_url");
        set => SetProperty("pre_signed_url", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    public TerraformProperty<double> RetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_period");
        set => SetProperty("retention_period", value);
    }

    /// <summary>
    /// The source_db_instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDbInstanceArn is required")]
    public required TerraformProperty<string> SourceDbInstanceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_db_instance_arn");
        set => SetProperty("source_db_instance_arn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbInstanceAutomatedBackupsReplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
