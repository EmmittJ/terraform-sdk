using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_cluster_role_association resource.
/// </summary>
public class AwsRdsClusterRoleAssociation : TerraformResource
{
    public AwsRdsClusterRoleAssociation(string name) : base("aws_rds_cluster_role_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    public string? DbClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_cluster_identifier")?.Value;
        set => this.WithProperty("db_cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The feature_name attribute.
    /// </summary>
    public string? FeatureName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("feature_name")?.Value;
        set => this.WithProperty("feature_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
