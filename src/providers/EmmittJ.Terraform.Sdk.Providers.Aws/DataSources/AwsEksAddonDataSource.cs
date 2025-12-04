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
        get => GetArgument<TerraformValue<string>>("addon_name");
        set => SetArgument("addon_name", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    /// The addon_version attribute.
    /// </summary>
    public TerraformValue<string> AddonVersion
        => AsReference("addon_version");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationValues
        => AsReference("configuration_values");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformValue<string> ModifiedAt
        => AsReference("modified_at");

    /// <summary>
    /// The pod_identity_association attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PodIdentityAssociation
        => AsReference("pod_identity_association");

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceAccountRoleArn
        => AsReference("service_account_role_arn");

}
