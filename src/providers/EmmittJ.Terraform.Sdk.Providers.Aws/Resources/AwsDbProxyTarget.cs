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
        this.WithOutput("endpoint");
        this.WithOutput("port");
        this.WithOutput("rds_resource_id");
        this.WithOutput("target_arn");
        this.WithOutput("tracked_cluster_id");
        this.WithOutput("type");
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DbClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("db_cluster_identifier");
        set => this.WithProperty("db_cluster_identifier", value);
    }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DbInstanceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("db_instance_identifier");
        set => this.WithProperty("db_instance_identifier", value);
    }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    public required TerraformProperty<string> DbProxyName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("db_proxy_name");
        set => this.WithProperty("db_proxy_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The target_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupName is required")]
    public required TerraformProperty<string> TargetGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_group_name");
        set => this.WithProperty("target_group_name", value);
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
