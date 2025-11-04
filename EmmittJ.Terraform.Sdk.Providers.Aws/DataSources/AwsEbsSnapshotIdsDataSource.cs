using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ebs_snapshot_ids.
/// </summary>
public class AwsEbsSnapshotIdsDataSource : TerraformDataSource
{
    public AwsEbsSnapshotIdsDataSource(string name) : base("aws_ebs_snapshot_ids", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ids");
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
    /// The owners attribute.
    /// </summary>
    public List<string>? Owners
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("owners")?.Value;
        set => this.WithProperty("owners", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The restorable_by_user_ids attribute.
    /// </summary>
    public List<string>? RestorableByUserIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("restorable_by_user_ids")?.Value;
        set => this.WithProperty("restorable_by_user_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

}
