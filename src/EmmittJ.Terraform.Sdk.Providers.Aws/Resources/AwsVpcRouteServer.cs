using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_route_server resource.
/// </summary>
public class AwsVpcRouteServer : TerraformResource
{
    public AwsVpcRouteServer(string name) : base("aws_vpc_route_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("route_server_id");
        this.DeclareOutput("sns_topic_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public TerraformProperty<double>? AmazonSideAsn
    {
        get => GetProperty<TerraformProperty<double>>("amazon_side_asn");
        set => this.WithProperty("amazon_side_asn", value);
    }

    /// <summary>
    /// The persist_routes attribute.
    /// </summary>
    public TerraformProperty<string>? PersistRoutes
    {
        get => GetProperty<TerraformProperty<string>>("persist_routes");
        set => this.WithProperty("persist_routes", value);
    }

    /// <summary>
    /// The persist_routes_duration attribute.
    /// </summary>
    public TerraformProperty<double>? PersistRoutesDuration
    {
        get => GetProperty<TerraformProperty<double>>("persist_routes_duration");
        set => this.WithProperty("persist_routes_duration", value);
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
    /// The sns_notifications_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SnsNotificationsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sns_notifications_enabled");
        set => this.WithProperty("sns_notifications_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    public TerraformExpression RouteServerId => this["route_server_id"];

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformExpression SnsTopicArn => this["sns_topic_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
