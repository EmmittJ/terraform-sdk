using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public string? DefaultIamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_iam_role_arn")?.Value;
        set => this.WithProperty("default_iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_role_arns attribute.
    /// </summary>
    public HashSet<string>? IamRoleArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("iam_role_arns")?.Value;
        set => this.WithProperty("iam_role_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
