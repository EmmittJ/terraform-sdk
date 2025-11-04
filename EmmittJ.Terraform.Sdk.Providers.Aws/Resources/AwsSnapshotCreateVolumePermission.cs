using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_snapshot_create_volume_permission resource.
/// </summary>
public class AwsSnapshotCreateVolumePermission : TerraformResource
{
    public AwsSnapshotCreateVolumePermission(string name) : base("aws_snapshot_create_volume_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The snapshot_id attribute.
    /// </summary>
    public string? SnapshotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_id")?.Value;
        set => this.WithProperty("snapshot_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
