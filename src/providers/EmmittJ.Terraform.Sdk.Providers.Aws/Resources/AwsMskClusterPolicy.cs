using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_msk_cluster_policy Terraform resource.
/// Manages a aws_msk_cluster_policy resource.
/// </summary>
public partial class AwsMskClusterPolicy(string name) : TerraformResource("aws_msk_cluster_policy", name)
{
    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformValue<string> ClusterArn
    {
        get => new TerraformReference<string>(this, "cluster_arn");
        set => SetArgument("cluster_arn", value);
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
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
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
    /// The current_version attribute.
    /// </summary>
    public TerraformValue<string> CurrentVersion
    {
        get => new TerraformReference<string>(this, "current_version");
    }

}
