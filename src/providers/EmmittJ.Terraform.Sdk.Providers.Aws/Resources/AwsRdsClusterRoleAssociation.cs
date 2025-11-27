using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRdsClusterRoleAssociation.
/// Nesting mode: single
/// </summary>
public class AwsRdsClusterRoleAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_rds_cluster_role_association Terraform resource.
/// Manages a aws_rds_cluster_role_association resource.
/// </summary>
public partial class AwsRdsClusterRoleAssociation(string name) : TerraformResource("aws_rds_cluster_role_association", name)
{
    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbClusterIdentifier is required")]
    public required TerraformValue<string> DbClusterIdentifier
    {
        get => new TerraformReference<string>(this, "db_cluster_identifier");
        set => SetArgument("db_cluster_identifier", value);
    }

    /// <summary>
    /// The feature_name attribute.
    /// </summary>
    public TerraformValue<string>? FeatureName
    {
        get => new TerraformReference<string>(this, "feature_name");
        set => SetArgument("feature_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRdsClusterRoleAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRdsClusterRoleAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
