using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for pod_identity_association in AwsEksAddon.
/// Nesting mode: set
/// </summary>
public class AwsEksAddonPodIdentityAssociationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pod_identity_association";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformValue<string> ServiceAccount
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEksAddon.
/// Nesting mode: single
/// </summary>
public class AwsEksAddonTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_eks_addon Terraform resource.
/// Manages a aws_eks_addon resource.
/// </summary>
public partial class AwsEksAddon(string name) : TerraformResource("aws_eks_addon", name)
{
    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddonName is required")]
    public required TerraformValue<string> AddonName
    {
        get => GetRequiredArgument<TerraformValue<string>>("addon_name");
        set => SetArgument("addon_name", value);
    }

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    public TerraformValue<string> AddonVersion
    {
        get => GetArgument<TerraformValue<string>>("addon_version") ?? CreateReference("addon_version");
        set => SetArgument("addon_version", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationValues
    {
        get => GetArgument<TerraformValue<string>>("configuration_values") ?? CreateReference("configuration_values");
        set => SetArgument("configuration_values", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The preserve attribute.
    /// </summary>
    public TerraformValue<bool>? Preserve
    {
        get => GetArgument<TerraformValue<bool>>("preserve");
        set => SetArgument("preserve", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resolve_conflicts_on_create attribute.
    /// </summary>
    public TerraformValue<string>? ResolveConflictsOnCreate
    {
        get => GetArgument<TerraformValue<string>>("resolve_conflicts_on_create");
        set => SetArgument("resolve_conflicts_on_create", value);
    }

    /// <summary>
    /// The resolve_conflicts_on_update attribute.
    /// </summary>
    public TerraformValue<string>? ResolveConflictsOnUpdate
    {
        get => GetArgument<TerraformValue<string>>("resolve_conflicts_on_update");
        set => SetArgument("resolve_conflicts_on_update", value);
    }

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ServiceAccountRoleArn
    {
        get => GetArgument<TerraformValue<string>>("service_account_role_arn");
        set => SetArgument("service_account_role_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformValue<string> ModifiedAt
        => CreateReference("modified_at");

    /// <summary>
    /// PodIdentityAssociation block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEksAddonPodIdentityAssociationBlock>? PodIdentityAssociation
    {
        get => GetArgument<TerraformSet<AwsEksAddonPodIdentityAssociationBlock>>("pod_identity_association");
        set => SetArgument("pod_identity_association", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEksAddonTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEksAddonTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
