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
        get => GetRequiredArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> DefaultIamRoleArn
    {
        get => GetArgument<TerraformValue<string>>("default_iam_role_arn") ?? CreateReference("default_iam_role_arn");
        set => SetArgument("default_iam_role_arn", value);
    }

    /// <summary>
    /// The iam_role_arns attribute.
    /// </summary>
    public TerraformSet<string> IamRoleArns
    {
        get => GetArgument<TerraformSet<string>>("iam_role_arns") ?? CreateReference("iam_role_arns");
        set => SetArgument("iam_role_arns", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
