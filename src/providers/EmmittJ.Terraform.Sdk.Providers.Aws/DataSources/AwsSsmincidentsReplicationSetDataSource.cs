using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssmincidents_replication_set Terraform data source.
/// Retrieves information about a aws_ssmincidents_replication_set.
/// </summary>
public partial class AwsSsmincidentsReplicationSetDataSource(string name) : TerraformDataSource("aws_ssmincidents_replication_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
        => AsReference("created_by");

    /// <summary>
    /// The deletion_protected attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtected
        => AsReference("deletion_protected");

    /// <summary>
    /// The last_modified_by attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedBy
        => AsReference("last_modified_by");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformSet<TerraformMap<object>> Region
        => AsReference("region");

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Regions
        => AsReference("regions");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}
