using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for pod_identity_association in .
/// Nesting mode: set
/// </summary>
public class AwsEksAddonPodIdentityAssociationBlock : TerraformBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformProperty<string> ServiceAccount
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_account");
        set => WithProperty("service_account", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEksAddonTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_eks_addon resource.
/// </summary>
public class AwsEksAddon : TerraformResource
{
    public AwsEksAddon(string name) : base("aws_eks_addon", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("created_at");
        this.WithOutput("modified_at");
    }

    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddonName is required")]
    public required TerraformProperty<string> AddonName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("addon_name");
        set => this.WithProperty("addon_name", value);
    }

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    public TerraformProperty<string>? AddonVersion
    {
        get => GetProperty<TerraformProperty<string>>("addon_version");
        set => this.WithProperty("addon_version", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationValues
    {
        get => GetProperty<TerraformProperty<string>>("configuration_values");
        set => this.WithProperty("configuration_values", value);
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
    /// The preserve attribute.
    /// </summary>
    public TerraformProperty<bool>? Preserve
    {
        get => GetProperty<TerraformProperty<bool>>("preserve");
        set => this.WithProperty("preserve", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resolve_conflicts_on_create attribute.
    /// </summary>
    public TerraformProperty<string>? ResolveConflictsOnCreate
    {
        get => GetProperty<TerraformProperty<string>>("resolve_conflicts_on_create");
        set => this.WithProperty("resolve_conflicts_on_create", value);
    }

    /// <summary>
    /// The resolve_conflicts_on_update attribute.
    /// </summary>
    public TerraformProperty<string>? ResolveConflictsOnUpdate
    {
        get => GetProperty<TerraformProperty<string>>("resolve_conflicts_on_update");
        set => this.WithProperty("resolve_conflicts_on_update", value);
    }

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_account_role_arn");
        set => this.WithProperty("service_account_role_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for pod_identity_association.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEksAddonPodIdentityAssociationBlock>? PodIdentityAssociation
    {
        get => GetProperty<HashSet<AwsEksAddonPodIdentityAssociationBlock>>("pod_identity_association");
        set => this.WithProperty("pod_identity_association", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEksAddonTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEksAddonTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformExpression ModifiedAt => this["modified_at"];

}
