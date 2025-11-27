using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_db_proxy_target Terraform resource.
/// Manages a aws_db_proxy_target resource.
/// </summary>
public partial class AwsDbProxyTarget(string name) : TerraformResource("aws_db_proxy_target", name)
{
    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? DbClusterIdentifier
    {
        get => new TerraformReference<string>(this, "db_cluster_identifier");
        set => SetArgument("db_cluster_identifier", value);
    }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    public TerraformValue<string>? DbInstanceIdentifier
    {
        get => new TerraformReference<string>(this, "db_instance_identifier");
        set => SetArgument("db_instance_identifier", value);
    }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    public required TerraformValue<string> DbProxyName
    {
        get => new TerraformReference<string>(this, "db_proxy_name");
        set => SetArgument("db_proxy_name", value);
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
    /// The target_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupName is required")]
    public required TerraformValue<string> TargetGroupName
    {
        get => new TerraformReference<string>(this, "target_group_name");
        set => SetArgument("target_group_name", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The rds_resource_id attribute.
    /// </summary>
    public TerraformValue<string> RdsResourceId
    {
        get => new TerraformReference<string>(this, "rds_resource_id");
    }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    public TerraformValue<string> TargetArn
    {
        get => new TerraformReference<string>(this, "target_arn");
    }

    /// <summary>
    /// The tracked_cluster_id attribute.
    /// </summary>
    public TerraformValue<string> TrackedClusterId
    {
        get => new TerraformReference<string>(this, "tracked_cluster_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}
