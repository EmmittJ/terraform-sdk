using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class AwsEfsReplicationConfigurationDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZoneName
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_name");
        set => WithProperty("availability_zone_name", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemId
    {
        get => GetProperty<TerraformProperty<string>>("file_system_id");
        set => WithProperty("file_system_id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEfsReplicationConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a aws_efs_replication_configuration resource.
/// </summary>
public class AwsEfsReplicationConfiguration : TerraformResource
{
    public AwsEfsReplicationConfiguration(string name) : base("aws_efs_replication_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_time");
        this.DeclareOutput("original_source_file_system_arn");
        this.DeclareOutput("source_file_system_arn");
        this.DeclareOutput("source_file_system_region");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The source_file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFileSystemId is required")]
    public required TerraformProperty<string> SourceFileSystemId
    {
        get => GetProperty<TerraformProperty<string>>("source_file_system_id");
        set => this.WithProperty("source_file_system_id", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public List<AwsEfsReplicationConfigurationDestinationBlock>? Destination
    {
        get => GetProperty<List<AwsEfsReplicationConfigurationDestinationBlock>>("destination");
        set => this.WithProperty("destination", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEfsReplicationConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEfsReplicationConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The original_source_file_system_arn attribute.
    /// </summary>
    public TerraformExpression OriginalSourceFileSystemArn => this["original_source_file_system_arn"];

    /// <summary>
    /// The source_file_system_arn attribute.
    /// </summary>
    public TerraformExpression SourceFileSystemArn => this["source_file_system_arn"];

    /// <summary>
    /// The source_file_system_region attribute.
    /// </summary>
    public TerraformExpression SourceFileSystemRegion => this["source_file_system_region"];

}
