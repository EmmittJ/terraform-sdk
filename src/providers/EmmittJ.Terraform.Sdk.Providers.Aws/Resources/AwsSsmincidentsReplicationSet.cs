using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for region in AwsSsmincidentsReplicationSet.
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsSsmincidentsReplicationSetRegionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "region";

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
    {
        get => new TerraformReference<string>(this, "status_message");
    }

}


/// <summary>
/// Block type for regions in AwsSsmincidentsReplicationSet.
/// Nesting mode: set
/// </summary>
public class AwsSsmincidentsReplicationSetRegionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regions";

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
    {
        get => new TerraformReference<string>(this, "status_message");
    }

}


/// <summary>
/// Block type for timeouts in AwsSsmincidentsReplicationSet.
/// Nesting mode: single
/// </summary>
public class AwsSsmincidentsReplicationSetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ssmincidents_replication_set Terraform resource.
/// Manages a aws_ssmincidents_replication_set resource.
/// </summary>
public partial class AwsSsmincidentsReplicationSet(string name) : TerraformResource("aws_ssmincidents_replication_set", name)
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Region block (nesting mode: set).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformSet<AwsSsmincidentsReplicationSetRegionBlock>? Region
    {
        get => GetArgument<TerraformSet<AwsSsmincidentsReplicationSetRegionBlock>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Regions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSsmincidentsReplicationSetRegionsBlock>? Regions
    {
        get => GetArgument<TerraformSet<AwsSsmincidentsReplicationSetRegionsBlock>>("regions");
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSsmincidentsReplicationSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSsmincidentsReplicationSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
