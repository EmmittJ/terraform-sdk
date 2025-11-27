using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRedshiftClusterIamRoles.
/// Nesting mode: single
/// </summary>
public class AwsRedshiftClusterIamRolesTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_redshift_cluster_iam_roles Terraform resource.
/// Manages a aws_redshift_cluster_iam_roles resource.
/// </summary>
public partial class AwsRedshiftClusterIamRoles(string name) : TerraformResource("aws_redshift_cluster_iam_roles", name)
{
    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => new TerraformReference<string>(this, "cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> DefaultIamRoleArn
    {
        get => new TerraformReference<string>(this, "default_iam_role_arn");
        set => SetArgument("default_iam_role_arn", value);
    }

    /// <summary>
    /// The iam_role_arns attribute.
    /// </summary>
    public TerraformSet<string> IamRoleArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "iam_role_arns").ResolveNodes(ctx));
        set => SetArgument("iam_role_arns", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRedshiftClusterIamRolesTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRedshiftClusterIamRolesTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
