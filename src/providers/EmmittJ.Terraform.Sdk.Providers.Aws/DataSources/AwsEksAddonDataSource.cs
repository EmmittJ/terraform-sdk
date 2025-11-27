using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_eks_addon Terraform data source.
/// Retrieves information about a aws_eks_addon.
/// </summary>
public partial class AwsEksAddonDataSource(string name) : TerraformDataSource("aws_eks_addon", name)
{
    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddonName is required")]
    public required TerraformValue<string> AddonName
    {
        get => new TerraformReference<string>(this, "addon_name");
        set => SetArgument("addon_name", value);
    }

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
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    public TerraformValue<string> AddonVersion
    {
        get => new TerraformReference<string>(this, "addon_version");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationValues
    {
        get => new TerraformReference<string>(this, "configuration_values");
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
    /// The pod_identity_association attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PodIdentityAssociation
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "pod_identity_association").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceAccountRoleArn
    {
        get => new TerraformReference<string>(this, "service_account_role_arn");
    }

}
