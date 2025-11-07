using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The source_file_system_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceFileSystemId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_file_system_id");
        set => this.WithProperty("source_file_system_id", value);
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
