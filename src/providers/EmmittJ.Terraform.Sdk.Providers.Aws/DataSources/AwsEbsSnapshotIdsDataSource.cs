using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEbsSnapshotIdsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEbsSnapshotIdsDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEbsSnapshotIdsDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEbsSnapshotIdsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_ebs_snapshot_ids Terraform data source.
/// Retrieves information about a aws_ebs_snapshot_ids.
/// </summary>
public partial class AwsEbsSnapshotIdsDataSource(string name) : TerraformDataSource("aws_ebs_snapshot_ids", name)
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
    /// The owners attribute.
    /// </summary>
    public TerraformList<string>? Owners
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "owners").ResolveNodes(ctx));
        set => SetArgument("owners", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The restorable_by_user_ids attribute.
    /// </summary>
    public TerraformList<string>? RestorableByUserIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "restorable_by_user_ids").ResolveNodes(ctx));
        set => SetArgument("restorable_by_user_ids", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformList<string> Ids
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEbsSnapshotIdsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEbsSnapshotIdsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEbsSnapshotIdsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEbsSnapshotIdsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
