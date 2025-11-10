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
        SetOutput("endpoint");
        SetOutput("port");
        SetOutput("rds_resource_id");
        SetOutput("target_arn");
        SetOutput("tracked_cluster_id");
        SetOutput("type");
        SetOutput("db_cluster_identifier");
        SetOutput("db_instance_identifier");
        SetOutput("db_proxy_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("target_group_name");
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string> DbClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_cluster_identifier");
        set => SetProperty("db_cluster_identifier", value);
    }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    public TerraformProperty<string> DbInstanceIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_instance_identifier");
        set => SetProperty("db_instance_identifier", value);
    }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    public required TerraformProperty<string> DbProxyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_proxy_name");
        set => SetProperty("db_proxy_name", value);
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
    /// The target_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupName is required")]
    public required TerraformProperty<string> TargetGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_group_name");
        set => SetProperty("target_group_name", value);
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
