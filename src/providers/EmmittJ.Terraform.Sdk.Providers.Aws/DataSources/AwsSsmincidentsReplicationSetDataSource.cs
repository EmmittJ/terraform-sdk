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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
        => CreateReference("created_by");

    /// <summary>
    /// The deletion_protected attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtected
        => CreateReference("deletion_protected");

    /// <summary>
    /// The last_modified_by attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedBy
        => CreateReference("last_modified_by");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformSet<TerraformMap<object>> Region
        => CreateReference("region");

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Regions
        => CreateReference("regions");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

}
