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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
    {
        get => new TerraformReference<string>(this, "created_by");
    }

    /// <summary>
    /// The deletion_protected attribute.
    /// </summary>
    public TerraformValue<bool> DeletionProtected
    {
        get => new TerraformReference<bool>(this, "deletion_protected");
    }

    /// <summary>
    /// The last_modified_by attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedBy
    {
        get => new TerraformReference<string>(this, "last_modified_by");
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformSet<TerraformMap<object>> Region
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "region").ResolveNodes(ctx));
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Regions
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "regions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
