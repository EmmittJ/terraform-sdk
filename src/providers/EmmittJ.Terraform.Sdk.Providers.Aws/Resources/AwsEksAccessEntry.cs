using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEksAccessEntry.
/// Nesting mode: single
/// </summary>
public class AwsEksAccessEntryTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_eks_access_entry Terraform resource.
/// Manages a aws_eks_access_entry resource.
/// </summary>
public partial class AwsEksAccessEntry(string name) : TerraformResource("aws_eks_access_entry", name)
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubernetes_groups attribute.
    /// </summary>
    public TerraformSet<string> KubernetesGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "kubernetes_groups").ResolveNodes(ctx));
        set => SetArgument("kubernetes_groups", value);
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalArn is required")]
    public required TerraformValue<string> PrincipalArn
    {
        get => new TerraformReference<string>(this, "principal_arn");
        set => SetArgument("principal_arn", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The access_entry_arn attribute.
    /// </summary>
    public TerraformValue<string> AccessEntryArn
    {
        get => new TerraformReference<string>(this, "access_entry_arn");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformValue<string> ModifiedAt
    {
        get => new TerraformReference<string>(this, "modified_at");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEksAccessEntryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEksAccessEntryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
