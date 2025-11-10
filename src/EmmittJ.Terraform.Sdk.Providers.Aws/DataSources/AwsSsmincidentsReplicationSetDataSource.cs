using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmincidents_replication_set.
/// </summary>
public class AwsSsmincidentsReplicationSetDataSource : TerraformDataSource
{
    public AwsSsmincidentsReplicationSetDataSource(string name) : base("aws_ssmincidents_replication_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_by");
        this.DeclareOutput("deletion_protected");
        this.DeclareOutput("last_modified_by");
        this.DeclareOutput("region");
        this.DeclareOutput("regions");
        this.DeclareOutput("status");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The deletion_protected attribute.
    /// </summary>
    public TerraformExpression DeletionProtected => this["deletion_protected"];

    /// <summary>
    /// The last_modified_by attribute.
    /// </summary>
    public TerraformExpression LastModifiedBy => this["last_modified_by"];

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformExpression Region => this["region"];

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformExpression Regions => this["regions"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
