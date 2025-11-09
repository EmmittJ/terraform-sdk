using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpclattice_access_log_subscription resource.
/// </summary>
public class AwsVpclatticeAccessLogSubscription : TerraformResource
{
    public AwsVpclatticeAccessLogSubscription(string name) : base("aws_vpclattice_access_log_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("resource_arn");
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationArn
    {
        get => GetProperty<TerraformProperty<string>>("destination_arn");
        set => this.WithProperty("destination_arn", value);
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
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("resource_identifier");
        set => this.WithProperty("resource_identifier", value);
    }

    /// <summary>
    /// The service_network_log_type attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceNetworkLogType
    {
        get => GetProperty<TerraformProperty<string>>("service_network_log_type");
        set => this.WithProperty("service_network_log_type", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

}
