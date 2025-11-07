using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_location_tracker_association resource.
/// </summary>
public class AwsLocationTrackerAssociation : TerraformResource
{
    public AwsLocationTrackerAssociation(string name) : base("aws_location_tracker_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The consumer_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ConsumerArn
    {
        get => GetProperty<TerraformProperty<string>>("consumer_arn");
        set => this.WithProperty("consumer_arn", value);
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
    /// The tracker_name attribute.
    /// </summary>
    public TerraformProperty<string>? TrackerName
    {
        get => GetProperty<TerraformProperty<string>>("tracker_name");
        set => this.WithProperty("tracker_name", value);
    }

}
