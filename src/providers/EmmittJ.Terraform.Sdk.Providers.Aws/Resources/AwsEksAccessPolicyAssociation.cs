using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_scope in AwsEksAccessPolicyAssociation.
/// Nesting mode: list
/// </summary>
public class AwsEksAccessPolicyAssociationAccessScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_scope";

    /// <summary>
    /// The namespaces attribute.
    /// </summary>
    public TerraformSet<string>? Namespaces
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "namespaces").ResolveNodes(ctx));
        set => SetArgument("namespaces", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEksAccessPolicyAssociation.
/// Nesting mode: single
/// </summary>
public class AwsEksAccessPolicyAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_eks_access_policy_association Terraform resource.
/// Manages a aws_eks_access_policy_association resource.
/// </summary>
public partial class AwsEksAccessPolicyAssociation(string name) : TerraformResource("aws_eks_access_policy_association", name)
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
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    public required TerraformValue<string> PolicyArn
    {
        get => new TerraformReference<string>(this, "policy_arn");
        set => SetArgument("policy_arn", value);
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
    /// The associated_at attribute.
    /// </summary>
    public TerraformValue<string> AssociatedAt
    {
        get => new TerraformReference<string>(this, "associated_at");
    }

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformValue<string> ModifiedAt
    {
        get => new TerraformReference<string>(this, "modified_at");
    }

    /// <summary>
    /// AccessScope block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessScope is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessScope block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessScope block(s) allowed")]
    public required TerraformList<AwsEksAccessPolicyAssociationAccessScopeBlock> AccessScope
    {
        get => GetRequiredArgument<TerraformList<AwsEksAccessPolicyAssociationAccessScopeBlock>>("access_scope");
        set => SetArgument("access_scope", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEksAccessPolicyAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEksAccessPolicyAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
