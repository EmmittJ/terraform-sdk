using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRedshiftClusterIamRolesTimeoutsBlock : TerraformBlock
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
/// Manages a aws_redshift_cluster_iam_roles resource.
/// </summary>
public class AwsRedshiftClusterIamRoles : TerraformResource
{
    public AwsRedshiftClusterIamRoles(string name) : base("aws_redshift_cluster_iam_roles", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cluster_identifier");
        SetOutput("default_iam_role_arn");
        SetOutput("iam_role_arns");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> DefaultIamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_iam_role_arn");
        set => SetProperty("default_iam_role_arn", value);
    }

    /// <summary>
    /// The iam_role_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> IamRoleArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("iam_role_arns");
        set => SetProperty("iam_role_arns", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRedshiftClusterIamRolesTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
