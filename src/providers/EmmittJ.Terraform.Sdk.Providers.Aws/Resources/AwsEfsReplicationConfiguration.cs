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
        set => SetProperty("availability_zone_name", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemId
    {
        set => SetProperty("file_system_id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
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
/// Manages a aws_efs_replication_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEfsReplicationConfiguration : TerraformResource
{
    public AwsEfsReplicationConfiguration(string name) : base("aws_efs_replication_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_time");
        SetOutput("original_source_file_system_arn");
        SetOutput("source_file_system_arn");
        SetOutput("source_file_system_region");
        SetOutput("id");
        SetOutput("region");
        SetOutput("source_file_system_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The source_file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFileSystemId is required")]
    public required TerraformProperty<string> SourceFileSystemId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_file_system_id");
        set => SetProperty("source_file_system_id", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public List<AwsEfsReplicationConfigurationDestinationBlock>? Destination
    {
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEfsReplicationConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
