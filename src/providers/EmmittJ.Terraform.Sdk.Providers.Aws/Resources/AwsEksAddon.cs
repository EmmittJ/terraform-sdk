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
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformProperty<string> ServiceAccount
    {
        set => SetProperty("service_account", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("modified_at");
        SetOutput("addon_name");
        SetOutput("addon_version");
        SetOutput("cluster_name");
        SetOutput("configuration_values");
        SetOutput("id");
        SetOutput("preserve");
        SetOutput("region");
        SetOutput("resolve_conflicts_on_create");
        SetOutput("resolve_conflicts_on_update");
        SetOutput("service_account_role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddonName is required")]
    public required TerraformProperty<string> AddonName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("addon_name");
        set => SetProperty("addon_name", value);
    }

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    public TerraformProperty<string> AddonVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("addon_version");
        set => SetProperty("addon_version", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
    }

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    public TerraformProperty<string> ConfigurationValues
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_values");
        set => SetProperty("configuration_values", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The preserve attribute.
    /// </summary>
    public TerraformProperty<bool> Preserve
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("preserve");
        set => SetProperty("preserve", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The resolve_conflicts_on_create attribute.
    /// </summary>
    public TerraformProperty<string> ResolveConflictsOnCreate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resolve_conflicts_on_create");
        set => SetProperty("resolve_conflicts_on_create", value);
    }

    /// <summary>
    /// The resolve_conflicts_on_update attribute.
    /// </summary>
    public TerraformProperty<string> ResolveConflictsOnUpdate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resolve_conflicts_on_update");
        set => SetProperty("resolve_conflicts_on_update", value);
    }

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ServiceAccountRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account_role_arn");
        set => SetProperty("service_account_role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for pod_identity_association.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEksAddonPodIdentityAssociationBlock>? PodIdentityAssociation
    {
        set => SetProperty("pod_identity_association", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEksAddonTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
