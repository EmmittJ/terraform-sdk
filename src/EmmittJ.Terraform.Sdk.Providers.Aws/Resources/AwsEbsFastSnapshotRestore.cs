using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ebs_fast_snapshot_restore resource.
/// </summary>
public class AwsEbsFastSnapshotRestore : TerraformResource
{
    public AwsEbsFastSnapshotRestore(string name) : base("aws_ebs_fast_snapshot_restore", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The snapshot_id attribute.
    /// </summary>
    public string? SnapshotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_id")?.Value;
        set => this.WithProperty("snapshot_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
