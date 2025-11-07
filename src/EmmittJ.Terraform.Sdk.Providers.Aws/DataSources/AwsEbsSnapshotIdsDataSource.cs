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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Owners
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("owners");
        set => this.WithProperty("owners", value);
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
    /// The restorable_by_user_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? RestorableByUserIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("restorable_by_user_ids");
        set => this.WithProperty("restorable_by_user_ids", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

}
