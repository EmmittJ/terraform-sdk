using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kinesisanalyticsv2_application_snapshot resource.
/// </summary>
public class AwsKinesisanalyticsv2ApplicationSnapshot : TerraformResource
{
    public AwsKinesisanalyticsv2ApplicationSnapshot(string name) : base("aws_kinesisanalyticsv2_application_snapshot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("application_version_id");
        this.DeclareOutput("snapshot_creation_timestamp");
    }

    /// <summary>
    /// The application_name attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationName
    {
        get => GetProperty<TerraformProperty<string>>("application_name");
        set => this.WithProperty("application_name", value);
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
    /// The snapshot_name attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotName
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_name");
        set => this.WithProperty("snapshot_name", value);
    }

    /// <summary>
    /// The application_version_id attribute.
    /// </summary>
    public TerraformExpression ApplicationVersionId => this["application_version_id"];

    /// <summary>
    /// The snapshot_creation_timestamp attribute.
    /// </summary>
    public TerraformExpression SnapshotCreationTimestamp => this["snapshot_creation_timestamp"];

}
