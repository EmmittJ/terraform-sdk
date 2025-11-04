using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_db_proxy_target resource.
/// </summary>
public class AwsDbProxyTarget : TerraformResource
{
    public AwsDbProxyTarget(string name) : base("aws_db_proxy_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint");
        this.DeclareOutput("port");
        this.DeclareOutput("rds_resource_id");
        this.DeclareOutput("target_arn");
        this.DeclareOutput("tracked_cluster_id");
        this.DeclareOutput("type");
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
    /// The db_instance_identifier attribute.
    /// </summary>
    public string? DbInstanceIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_instance_identifier")?.Value;
        set => this.WithProperty("db_instance_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    public string? DbProxyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_proxy_name")?.Value;
        set => this.WithProperty("db_proxy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_group_name attribute.
    /// </summary>
    public string? TargetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_group_name")?.Value;
        set => this.WithProperty("target_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The rds_resource_id attribute.
    /// </summary>
    public TerraformExpression RdsResourceId => this["rds_resource_id"];

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    public TerraformExpression TargetArn => this["target_arn"];

    /// <summary>
    /// The tracked_cluster_id attribute.
    /// </summary>
    public TerraformExpression TrackedClusterId => this["tracked_cluster_id"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
